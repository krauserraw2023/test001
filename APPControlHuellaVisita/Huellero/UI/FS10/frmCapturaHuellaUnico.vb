﻿Imports Futronic.MathAPIHelper
Imports System.Threading
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.IO
Imports APPControlHuellaVisita.Type.Enumeracion
Imports System.Drawing
Imports System.Windows.Forms
Imports APPControlHuellaVisita.Huellero.DLL.FS88H
Imports APPControlHuellaVisita.Lector.Futronic.LoadDll.WSQ
Imports APPControlHuellaVisita.Lector.Futronic

Namespace Huellero.UI.FS10
    Public Class frmCapturaHuellaUnico
        Dim dispositivoAbierto As Boolean = False

        Private Enum OPERATION_MODE
            OM_CAPTURE = 0
            OM_CREATE = 1
            OM_VERIFY = 2
            OM_IDENTIFY = 3
        End Enum

        Private Shared FTR_MATCH_SCORE_VALUE As Integer() = {37, 65, 93, 121, 146, 189}

        Dim m_ImageSize As Huellero.DLL.FS88H.FTRSCAN_IMAGE_SIZE
        Dim m_pImage As Byte() = Nothing
        Dim m_pTemplate As Byte() = Nothing
        Dim m_OperationMode As OPERATION_MODE
        Dim m_bStop As Boolean = False
        Dim m_bExit As Boolean = False
        Dim m_nErrorCode As Integer = 0
        Dim m_nTemplateFormat As Integer = 0
        Dim m_csFolderDb As String = Nothing
        Dim m_byFingerPosition As Byte = 0
        Dim m_fMatchScore As Single = 0
        Dim m_WorkerThread As Thread = Nothing

        Dim _nOutTemplateSize As Integer

        Dim m_TipoDispositivo As Utilidad.enmDispositivoCompatibilidad = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_UNKNOWN_TYPE
        Dim n_indice_huella As Type.Enumeracion.TipoDedo = Type.Enumeracion.TipoDedo.Ninguno

        Dim c_dirPathWSQ As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\wsq\"
        Dim c_dirPathBMP As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\BMP\"
        Dim c_dirPathANSI As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\ansi\"
        Dim c_dirPathISO As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\iso\"

        Dim colorLedOn As Color = Color.FromArgb(0, 192, 0)
        Dim colorLedOff As Color = Color.Gray

        Dim nCountTime As Integer = 0
        Dim bCountTimeON As Boolean = False

        Private threadParams As ThreadParameters
        Dim bCancel As Boolean = False

        Dim lstIconoDedos As New List(Of uscIconFinger)

        Private pPen As Pen = New Pen(Color.Green)
        Private penred As Pen = New Pen(Color.Red)

        Private miFont As Font = New Font("Arial", 30, FontStyle.Italic)
        Private font2 As Font = New Font("Arial", 32, FontStyle.Italic)

        Delegate Sub SetProcesoLedCallback(ledON As Boolean)
        Delegate Sub SetImageCallback()

        Delegate Sub SetUpdateTextCallback(sText As String, xCoord As Integer, yCoord As Integer)
        Delegate Sub SetUpdateTextCallback2(sText As String, xCoord As Integer, yCoord As Integer, miPen As Pen, fuente As Font)
        Delegate Sub SetUpdateTextCalidadHuellaCallback(calidadHuella As Integer)

        Delegate Sub SetDosageCallback(ByVal value As Integer)
        Delegate Sub SetTextCallback(ByVal text As String)

        Class ThreadParameters
            Public hDevice As Device
            Public height As Integer
            Public width As Integer
            Public imageData As Byte()
            Public continueProcess As Boolean
            Public cancelarProceso As Boolean

            Public imageDataSeg As Byte()
            Public imageDataSubf As Byte()
            Public paramSeg As SegmParameters
            Public dataSubf As SubfPointCoord()
            Public bSegmentation As Boolean
            Public dosage As Integer
            Public mode As Integer
            Public autoTh As Integer
            Public indiceCalidad As Integer
        End Class

#Region "Propiedades_Publicas"
        Public Property _RegId As Integer = -1
        Public Property _PenId As Integer = -1
        Public Property _UsuarioId As Integer = -1
        Public Property _CnBdHuella As String = "" 'cadena de conexion a la bd de huellas
        Public Property _Observacion As String = ""
        Public Property _TipDocIdentId As Integer = -1
        Public Property _NumDocIdent As String = ""
        Public Property _CodRP As String = ""
        Public Property _ApePat As String = ""
        Public Property _ApeMat As String = ""
        Public Property _Nombres As String = ""
        Public Property _TemplateId As Integer = -1
        'Public Property _UsarBDHuella As Boolean = True
#End Region
#Region "Propiedades_Retorno"
        Public Property _uscDedoActual As uscThumbFinger = Nothing

#End Region
#Region "CAPTURA"
        Private Sub DoScan(ByVal param As Object)
            Dim threadParam As ThreadParameters = DirectCast(param, ThreadParameters)
            Dim criticalError As Boolean = False
            Dim imageSize As Size
            Dim bOk As Boolean = False

            Select Case Me.m_TipoDispositivo
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10
                    threadParam.hDevice.EliminateBackground = True
                    Me.bCancel = False
                    Dim nNfiq As Integer = 0
                    Dim rs As Boolean = False
                    While (threadParam.continueProcess And criticalError = False)
                        If Me.bCancel = True Then Exit While

                        Try
                            threadParam.imageData = threadParam.hDevice.GetFrame()
                            rs = threadParam.hDevice.MathImageNfIQ(threadParam.imageData, threadParam.width, threadParam.height, nNfiq, bOk)

                            UpdateScreenImage2()

                            If rs = True Then
                                UpdateTextCalidadHuella(nNfiq)
                            End If
                        Catch ex As FutronicException
                            If ex.ErrorCode = 4306 Then
                                threadParam.imageData = Nothing
                                UpdateScreenImage2()
                                Continue While
                            End If
                            SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, criticalError))
                            'Continue While
                        Catch ex2 As Exception
                            criticalError = True
                        End Try
                    End While

                    If criticalError Or bCancel Then
                        threadParam.imageData = Nothing
                        UpdateScreenImage2()

                        threadParam.indiceCalidad = 0
                        threadParam.hDevice.Dispose()
                        threadParam.hDevice = Nothing
                        ProcesoLed(False)
                        Exit Sub
                    End If
                    threadParam.indiceCalidad = nNfiq

                    Try
                        savebmp(threadParam)
                        ConvertWSQ(threadParam)
                        ConvertAnsiSDK(threadParam)

                        threadParams.hDevice.Close()
                        threadParam.hDevice.Dispose()
                        threadParam.hDevice = Nothing
                        ProcesoLed(False)
                    Catch ex As Exception

                    End Try

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60, Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS64
                    Try
                        UpdateBuffer(threadParam.imageData, True)
                        UpdateScreenImage2()

                        threadParam.hDevice.EliminateBackground = True
                        If threadParam.hDevice.Information.DeviceCompatibility = 8 Or threadParam.hDevice.Information.DeviceCompatibility = 15 Then
                            threadParam.hDevice.PreviewMode = False
                            threadParam.hDevice.EliminateBackground = True
                            threadParam.hDevice.PreviewMode = True
                        End If
                    Catch ex As FutronicException
                        SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, criticalError))
                        If criticalError Then
                            threadParam.hDevice.Dispose()
                            threadParam.hDevice = Nothing
                            ProcesoLed(False)
                            Exit Sub
                        End If
                    End Try

                    While (threadParam.continueProcess And criticalError = False)
                        bOk = False

                        Try
                            threadParam.imageDataSeg = threadParam.hDevice.GetFrame(threadParams.dosage)
                            bOk = threadParam.hDevice.MathImageSegmentAuto(threadParam.imageDataSeg, threadParam.width, threadParam.height, threadParam.imageData,
                                          Nothing, threadParam.paramSeg, threadParam.dataSubf, threadParam.bSegmentation, threadParam.autoTh)

                            SetDosageValue(threadParams.dosage)
                            UpdateScreenImage2()

                            If threadParam.dataSubf(0).err = 0 Then
                                'UpdateTextCalidadHuella(Convert.ToString(threadParam.dataSubf(0).qfutr), threadParam.dataSubf(0).xs - threadParam.dataSubf(0).ws / 2, threadParam.dataSubf(0).ys - threadParam.dataSubf(0).hs / 2)
                                UpdateTextCalidadHuella(Convert.ToString(threadParam.dataSubf(0).qfutr))
                            End If
                        Catch ex As FutronicException
                            SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, criticalError))
                        Catch ex2 As Exception
                            criticalError = True
                        End Try
                    End While

                    If criticalError Then
                        threadParam.hDevice.Dispose()
                        threadParam.hDevice = Nothing
                        ProcesoLed(False)
                        Exit Sub
                    End If

                    '''''''''''''''''''''Proceso final para obtener las huellas
                    UpdateScreenImage2()
                    UpdateText2("Por favor, no quite el dedo!", 20, 40, pPen, miFont)

                    If threadParam.hDevice.Information.DeviceCompatibility = 8 OrElse threadParam.hDevice.Information.DeviceCompatibility = 15 Then
                        threadParam.hDevice.PreviewMode = False
                        imageSize = threadParam.hDevice.ImageSize
                        threadParam.height = imageSize.Height
                        threadParam.width = imageSize.Width
                        Array.Resize(threadParam.imageData, threadParam.height * threadParam.width)
                        Array.Resize(threadParam.imageDataSeg, threadParam.height * threadParam.width)
                    End If

                    threadParam.imageDataSeg = threadParam.hDevice.GetFrame(threadParams.dosage)

                    bOk = threadParam.hDevice.MathImageSegment(threadParam.imageDataSeg, threadParam.width, threadParam.height, threadParam.imageData,
                                                           threadParam.imageDataSubf, threadParam.paramSeg, threadParam.dataSubf, threadParam.bSegmentation)
                    UpdateScreenImage2()

                    If threadParam.dataSubf(0).err = 0 Then
                        UpdateTextCalidadHuella(Convert.ToString(threadParam.dataSubf(0).qfutr))
                        'UpdateTextCalidadHuella(Convert.ToString(threadParam.dataSubf(0).qfutr), threadParam.dataSubf(0).xs - threadParam.dataSubf(0).ws / 2, threadParam.dataSubf(0).ys - threadParam.dataSubf(0).hs / 2)
                    End If

                    Try
                        savebmp(threadParam)
                        ConvertWSQ(threadParam)
                        ConvertAnsiSDK(threadParam)

                        threadParams.hDevice.Close()
                        threadParam.hDevice.Dispose()
                        threadParam.hDevice = Nothing
                        ProcesoLed(False)
                    Catch ex As Exception

                    End Try

            End Select


        End Sub

        Private Sub SetErrorMessage(message As String)
            If Me.lblMessage.InvokeRequired Then
                Dim d As New SetTextCallback(AddressOf Me.SetErrorMessage)
                Me.Invoke(d, message)
            Else
                lblMessage.Text = message
            End If
        End Sub

        Private Sub ProcesoLed(ledON As Boolean)
            If Me.InvokeRequired Then
                Dim d As New SetProcesoLedCallback(AddressOf Me.ProcesoLed)
                Me.Invoke(d, ledON)
            Else
                Led(ledON)
            End If
        End Sub

        Private Sub SetDosageValue(ByVal value As Integer)
            If Me.InvokeRequired Then
                Dim d As New SetDosageCallback(AddressOf SetDosageValue)
                Me.Invoke(d, New Object() {value})
            End If
        End Sub

        Private Shared Sub UpdateBuffer(ByVal data As Byte(), ByVal bparam As Boolean)
            If bparam = True Then
                For i As Integer = 0 To data.Length - 1
                    data(i) = 255
                Next
            Else
                For i As Integer = 0 To data.Length - 1
                    data(i) = 0
                Next
            End If
        End Sub

        Private Sub UpdateScreenImage2()
            If Me.InvokeRequired Then
                Dim d As New SetImageCallback(AddressOf Me.UpdateScreenImage2)
                Me.Invoke(d)
            Else
                Dim picture As Bitmap
                If threadParams.imageData Is Nothing Then
                    picture = Nothing
                Else
                    picture = Device.GetBitmapFromBuffer2(threadParams.imageData, threadParams.height, threadParams.width)
                End If
                DrawImage(picture)
            End If
        End Sub

        Private Sub UpdateText(sText As String, xCoord As Integer, yCoord As Integer)
            If Me.InvokeRequired Then
                Dim d As New SetUpdateTextCallback(AddressOf Me.UpdateText)
                Me.Invoke(d, New Object() {sText, xCoord, yCoord})
            Else
                Me.UpdateString(sText, xCoord, yCoord)
            End If
        End Sub

        Private Sub UpdateText2(sText As String, xCoord As Integer, yCoord As Integer, miPen As Pen, fFuente As Font)
            If Me.InvokeRequired Then
                Dim d As New SetUpdateTextCallback2(AddressOf Me.UpdateText2)
                Me.Invoke(d, New Object() {sText, xCoord, yCoord, miPen, fFuente})
            Else
                Me.UpdateString2(sText, xCoord, yCoord, miPen, fFuente)
            End If
        End Sub

        Private Sub UpdateTextCalidadHuella(calidadHuella As Integer)
            If Me.InvokeRequired Then
                Dim d As New SetUpdateTextCalidadHuellaCallback(AddressOf Me.UpdateTextCalidadHuella)
                Me.Invoke(d, New Object() {calidadHuella})
            Else
                Me.UpdateStringCalidadHuella(calidadHuella)
            End If
        End Sub

        Sub ConvertWSQ(ByVal threadParam As ThreadParameters)
            Dim NomArc As String = ""
            Dim m_hDevice As New ScanAPIHelperFS60.Device
            Dim fBitRate As Double = 0.75
            Dim WSQ_Image As Byte()
            Dim imagetempSubfBin As Byte()
            Dim SizeSubf As Integer = 0

            If Me.m_TipoDispositivo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10 And (Me.threadParams.indiceCalidad > 3 Or Me.threadParams.indiceCalidad <= 0) Then
                Exit Sub
            End If

            Try
                m_hDevice.Open()
                NomArc = c_dirPathWSQ
                imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}

                If Me.m_TipoDispositivo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10 Then
                    WSQ_Image = m_hDevice.WSQ_FromRawImage(threadParam.imageData, threadParam.width, threadParam.height, fBitRate)
                    Array.Copy(threadParam.imageData, SizeSubf, imagetempSubfBin, 0, threadParam.width * threadParam.height)
                    WSQ_Image = m_hDevice.WSQ_FromRawImage(imagetempSubfBin, threadParam.width, threadParam.height, fBitRate)

                    uscHuellaThumb._AnchoImgPixel = threadParam.width
                    uscHuellaThumb._LargoImgPixel = threadParam.height
                Else 'decadactilar
                    WSQ_Image = m_hDevice.WSQ_FromRawImage(threadParam.imageDataSeg, threadParam.width, threadParam.height, fBitRate)

                    If threadParam.dataSubf(0).err = 0 Then
                        Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(0).ws * threadParam.dataSubf(0).hs)
                        WSQ_Image = m_hDevice.WSQ_FromRawImage(imagetempSubfBin, threadParam.dataSubf(0).ws, threadParam.dataSubf(0).hs, fBitRate)

                        uscHuellaThumb._AnchoImgPixel = threadParam.dataSubf(0).ws
                        uscHuellaThumb._LargoImgPixel = threadParam.dataSubf(0).hs
                    End If
                End If

                uscHuellaThumb._Wsq = WSQ_Image
                SaveWSQ(NomArc & 0 + 1 & ".wsq", WSQ_Image)
                m_hDevice.Close()
            Catch ex As Exception
                uscHuellaThumb.LimpiarHuella()
                MsgBox(ex.Message)
            End Try

        End Sub

        Sub SaveWSQ(ByVal NomArc As String, ByVal WSQ_Image As Byte())
            Try
                Dim file As New FileStream(NomArc, FileMode.Create)
                file.Write(WSQ_Image, 0, WSQ_Image.Length)
                file.Close()
            Catch ex As Exception

            End Try
        End Sub


        Public Sub UpdateStringCalidadHuella(ByVal calidadHuella As Integer)
            If PBox_PreviewHuellas.Image IsNot Nothing Then
                Try
                    lblCalidad.ForeColor = Color.White
                    Select Case calidadHuella
                        Case 1
                            lblCalidad.BackColor = Color.Green
                        Case 2
                            lblCalidad.BackColor = Color.Blue
                        Case 3
                            lblCalidad.BackColor = Color.Yellow
                            lblCalidad.ForeColor = Color.Black
                        Case Else
                            lblCalidad.BackColor = Color.Red

                    End Select
                    lblCalidad.Text = calidadHuella
                Catch ex As Exception

                End Try
            End If
        End Sub

        Public Sub UpdateString(ByVal sText As String, ByVal xCoord As Integer, ByVal yCoord As Integer)
            If PBox_PreviewHuellas.Image IsNot Nothing Then
                Try
                    Dim g As Graphics = Graphics.FromImage(PBox_PreviewHuellas.Image)
                    Dim P As New Point(xCoord, yCoord)

                    Using b As New SolidBrush(Color.Red) 'pen.Color)
                        g.DrawString(sText, Font, b, P)
                    End Using
                    g.Dispose()
                    PBox_PreviewHuellas.Invalidate()
                Catch ex As Exception

                End Try
            End If
        End Sub

        Public Sub UpdateString2(ByVal sText As String, ByVal xCoord As Integer, ByVal yCoord As Integer, ByVal pen_ As Pen, ByVal font_ As Font)
            If PBox_PreviewHuellas.Image IsNot Nothing Then
                Try
                    Dim g As Graphics = Graphics.FromImage(PBox_PreviewHuellas.Image)
                    Dim P As New Point(xCoord, yCoord)

                    Using b As New SolidBrush(Color.Green) 'pen_.Color)
                        g.DrawString(sText, font_, b, P)
                    End Using
                    g.Dispose()
                    PBox_PreviewHuellas.Invalidate()
                Catch ex As Exception

                End Try
            End If
        End Sub

        Private Shared Function CreateImage(ByVal width As Integer, ByVal heigth As Integer, ByVal buffer As Byte(), ByRef RawImage() As Byte) As Image
            Dim _image As Image
            Dim bmp As New Bitmap(width, heigth, PixelFormat.Format24bppRgb)
            Dim rect As New Rectangle(Point.Empty, bmp.Size)
            Dim bmpData As BitmapData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat)
            Try
                Dim ptr As IntPtr = bmpData.Scan0
                Dim bytes As Integer = bmpData.Stride * bmpData.Height
                Marshal.Copy(buffer, 0, ptr, bytes)

                Dim iRawImgSize As Integer
                iRawImgSize = width * heigth
                ReDim RawImage(iRawImgSize - 1)
                System.Runtime.InteropServices.Marshal.Copy(ptr, RawImage, 0, iRawImgSize)
            Finally
                bmp.UnlockBits(bmpData)
                _image = DirectCast(bmp, Image)
            End Try
            Return _image
        End Function

        Private Sub savebmp(ByVal threadParam As ThreadParameters)
            For Each fichero As String In Directory.GetFiles(c_dirPathBMP, "*.bmp")
                File.Delete(fichero)
            Next

            Select Case Me.m_TipoDispositivo
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H
                    Try
                        If threadParam.indiceCalidad < 4 And threadParam.indiceCalidad > 0 Then
                            Dim myFile As New Wsq2Bmp.UtilidadFutronic.MyBitmapFile(threadParam.width, threadParam.height, threadParam.imageData)

                            uscHuellaThumb._ImagenHuellaByte = myFile.BitmatFileData
                            uscHuellaThumb._IndiceCalidad = threadParam.indiceCalidad
                        End If
                    Catch ex As Exception
                        uscHuellaThumb.LimpiarHuella()
                    End Try

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10
                    Try
                        If threadParam.indiceCalidad < 4 And threadParam.indiceCalidad > 0 Then
                            Dim myFile As New Wsq2Bmp.UtilidadFutronic.MyBitmapFile(threadParam.width, threadParam.height, threadParam.imageData)

                            uscHuellaThumb._ImagenHuellaByte = myFile.BitmatFileData
                            uscHuellaThumb._IndiceCalidad = threadParam.indiceCalidad
                        End If
                    Catch ex As Exception
                        uscHuellaThumb.LimpiarHuella()
                    End Try

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60, Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS64
                    Try
                        If True Then
                            Dim Img As Image
                            Dim imagetemp As Byte()
                            Dim imagetempSubf As Byte()
                            Dim imagetempSubfBin As Byte()
                            Dim wmod As Integer
                            Dim SizeSubf As Integer = 0

                            imagetemp = New Byte(threadParam.width * threadParam.height * 3 - 1) {}

                            For j As Integer = 0 To threadParam.width * threadParam.height - 1
                                imagetemp(j * 3) = threadParam.imageDataSeg(j)
                                imagetemp(j * 3 + 1) = threadParam.imageDataSeg(j)

                                imagetemp(j * 3 + 2) = threadParam.imageDataSeg(j)
                            Next

                            imagetempSubf = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) * 3 - 1) {}
                            imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}

                            If threadParam.dataSubf(0).err = 0 Then
                                wmod = threadParam.dataSubf(0).ws Mod 4
                                Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(0).ws * threadParam.dataSubf(0).hs)

                                For k As Integer = 0 To threadParam.dataSubf(0).hs - 1
                                    For j As Integer = 0 To threadParam.dataSubf(0).ws - 1
                                        imagetempSubf(j * 3 + wmod * k + 3 * threadParam.dataSubf(0).ws * k) = imagetempSubfBin(j + k * threadParam.dataSubf(0).ws)
                                        imagetempSubf(j * 3 + 1 + wmod * k + 3 * threadParam.dataSubf(0).ws * k) = imagetempSubfBin(j + k * threadParam.dataSubf(0).ws)
                                        imagetempSubf(j * 3 + 2 + wmod * k + 3 * threadParam.dataSubf(0).ws * k) = imagetempSubfBin(j + k * threadParam.dataSubf(0).ws)
                                    Next
                                Next

                                Dim ar As Byte()
                                Dim indCalidad As Integer = 0

                                Img = CreateImage(threadParam.dataSubf(0).ws, threadParam.dataSubf(0).hs, imagetempSubf, Nothing)

                                ar = CType((New ImageConverter()).ConvertTo(Img, GetType(Byte())), Byte())

                                indCalidad = threadParam.dataSubf(0).qfutr

                                uscHuellaThumb._ImagenHuellaByte = ar
                                uscHuellaThumb._IndiceCalidad = indCalidad
                                Dim x As Integer = 0

                            End If

                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

            End Select

        End Sub

        Public Sub DrawImage(ByVal pictire As Bitmap)
            If PBox_PreviewHuellas.Image IsNot Nothing Then PBox_PreviewHuellas.Image.Dispose()

            PBox_PreviewHuellas.Image = pictire
        End Sub

        Sub ConvertAnsiSDK(ByVal threadParam As ThreadParameters)
            Dim h_device As IntPtr
            Dim pnOutTemplateSize As Integer
            Dim imagetempSubfBin As Byte()
            Dim SizeSubf As Integer = 0
            Dim val_Ansi As Boolean

            Select Case Me.m_TipoDispositivo
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H
                    Try
                        h_device = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanOpenDevice()

                        imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}

                        Array.Copy(threadParam.imageData, SizeSubf, imagetempSubfBin, 0, threadParam.width * threadParam.height)
                        Dim m_pImage_ANSI As Byte()
                        m_pImage_ANSI = New Byte(threadParam.width * threadParam.height) {}

                        'OBTENER ANSI DESDE BUFFER
                        val_Ansi = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrAnsiSdkCreateTemplateFromBuffer(h_device, 0, imagetempSubfBin, threadParam.width, threadParam.height, m_pImage_ANSI, pnOutTemplateSize)

                        Dim path As String = ""
                        path = c_dirPathANSI & 0 + 1 & ".ansi"
                        Dim file As New FileStream(path, FileMode.Create)
                        file.Write(m_pImage_ANSI, 0, pnOutTemplateSize)
                        file.Close()

                        uscHuellaThumb._TemplateANSI = IO.File.ReadAllBytes(path)

                        Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanCloseDevice(h_device)
                    Catch ex As Exception

                    End Try

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10
                    Try
                        h_device = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanOpenDevice()

                        imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}

                        Array.Copy(threadParam.imageData, SizeSubf, imagetempSubfBin, 0, threadParam.width * threadParam.height)
                        Dim m_pImage_ANSI As Byte()
                        m_pImage_ANSI = New Byte(threadParam.width * threadParam.height) {}

                        'OBTENER ANSI DESDE BUFFER
                        val_Ansi = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrAnsiSdkCreateTemplateFromBuffer(h_device, 0, imagetempSubfBin, threadParam.width, threadParam.height, m_pImage_ANSI, pnOutTemplateSize)

                        Dim path As String = ""
                        path = c_dirPathANSI & 0 + 1 & ".ansi"
                        Dim file As New FileStream(path, FileMode.Create)
                        file.Write(m_pImage_ANSI, 0, pnOutTemplateSize)
                        file.Close()

                        uscHuellaThumb._TemplateANSI = IO.File.ReadAllBytes(path)

                        Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanCloseDevice(h_device)
                    Catch ex As Exception

                    End Try

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60, Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS64
                    Try
                        h_device = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanOpenDevice()

                        imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}

                        If threadParam.dataSubf(0).err = 0 Then
                            Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(0).ws * threadParam.dataSubf(0).hs)
                            Dim m_pImage_ANSI As Byte()
                            m_pImage_ANSI = New Byte(threadParam.dataSubf(0).ws * threadParam.dataSubf(0).hs) {}

                            'OBTENER ANSI DESDE BUFFER
                            val_Ansi = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrAnsiSdkCreateTemplateFromBuffer(h_device, 0, imagetempSubfBin, threadParam.dataSubf(0).ws, threadParam.dataSubf(0).hs, m_pImage_ANSI, pnOutTemplateSize)

                            Dim path As String = ""
                            path = c_dirPathANSI & 0 + 1 & ".ansi"
                            Dim file As New FileStream(path, FileMode.Create)
                            file.Write(m_pImage_ANSI, 0, pnOutTemplateSize)
                            file.Close()
                            SizeSubf = SizeSubf + threadParam.dataSubf(0).hs * threadParam.dataSubf(0).ws

                            uscHuellaThumb._TemplateANSI = IO.File.ReadAllBytes(path)
                        End If

                        Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanCloseDevice(h_device)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

            End Select


        End Sub

#End Region

#Region "OTROS"


        Private Sub GrabarTemporal()

            If uscHuellaThumb._EstadoDedo = EstadoDedo.Disponible And uscHuellaThumb._Wsq Is Nothing Then
                MsgBox("La huella de " & uscHuellaThumb._NombreLargoDedo & "   Estado: " & uscHuellaThumb._EstadoDedo & " pendiente de captura.", vbExclamation)
                Exit Sub
            End If

            If uscHuellaThumb._EstadoDedo <> EstadoDedo.Disponible Then
                uscHuellaThumb._Wsq = Nothing
                uscHuellaThumb._TemplateANSI = Nothing
                uscHuellaThumb._TemplateISO = Nothing
                Exit Sub
            End If

            'validar si hay huella en el huellero
            If Me.uscHuellaThumb._IndiceCalidad < 1 Then
                MessageBox.Show("No se ha capturado una huella valida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Me.uscHuellaThumb._IndiceCalidad < 1 Or Me.uscHuellaThumb._IndiceCalidad > 3 Then
                MessageBox.Show("Calidad de huella no permitida.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim outSms As String = ""
            Dim id As Integer = -1

            Dim tipo As Type.Enumeracion.enumTipoDispositivo
            Select Case Me.m_TipoDispositivo
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10
                    tipo = Type.Enumeracion.enumTipoDispositivo.FutronicFS10

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60
                    tipo = Type.Enumeracion.enumTipoDispositivo.Futronic_Deca_FS60

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS64
                    tipo = Type.Enumeracion.enumTipoDispositivo.Futronic_Deca_FS64

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H
                    tipo = Type.Enumeracion.enumTipoDispositivo.FutronicFS88H
            End Select

            uscHuellaThumb._TipoDispostivo = tipo


            Me._uscDedoActual = Me.uscHuellaThumb

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub Led(Encender As Boolean)

            If Me.m_TipoDispositivo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H Then Exit Sub

            Dim hDevice As New Device()

            Try
                hDevice.Open()
                Dim param1 As UInteger = &H0
                Dim param2 As UInteger = &H0

                If Me.m_TipoDispositivo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60 Or Me.m_TipoDispositivo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS64 Then
                    hDevice.ControlPin3(&H100000, 0, 250) 'beep del dispositivo
                    Thread.Sleep(100) 'medio segundo
                    hDevice.ControlPin3(0, param2, 250)
                End If

                uscHuellaThumb.chkHuellaNoDisponible.Checked = False

                Select Case Me.n_indice_huella
                    Case TipoDedo.MeniqueIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H1 : usc_izq_men.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H2 : usc_izq_men.BackColor = Me.colorLedOn
                    Case TipoDedo.AnularIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H4 : ucs_izq_anu.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H8 : ucs_izq_anu.BackColor = Me.colorLedOn
                    Case TipoDedo.MedioIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H10 : usc_izq_med.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H20 : usc_izq_med.BackColor = Me.colorLedOn
                    Case TipoDedo.IndiceIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H40 : usc_izq_ind.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H80 : usc_izq_ind.BackColor = Me.colorLedOn

                    Case TipoDedo.IndiceDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H1000 : usc_der_ind.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H2000 : usc_der_ind.BackColor = Me.colorLedOn
                    Case TipoDedo.MedioDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H4000 : usc_der_med.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H8000 : usc_der_med.BackColor = Me.colorLedOn
                    Case TipoDedo.AnularDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H10000 : usc_der_anu.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H20000 : usc_der_anu.BackColor = Me.colorLedOn
                    Case TipoDedo.MeniqueDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H40000 : usc_der_men.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H80000 : usc_der_men.BackColor = Me.colorLedOn
                    Case TipoDedo.PulgarIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H100 : usc_izq_pul.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H200 : usc_izq_pul.BackColor = Me.colorLedOn
                    Case TipoDedo.PulgarDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H400 : usc_der_pul.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H800 : usc_der_pul.BackColor = Me.colorLedOn
                End Select

                If Encender = False Then
                    param1 = 0

                    For Each obj As uscIconFinger In lstIconoDedos
                        obj.BackColor = Me.colorLedOff
                    Next

                    btnCapturar.Text = "Iniciar captura"
                    btnAbortarCap.Enabled = False
                    Try
                        threadParams.continueProcess = False
                    Catch ex2 As Exception
                    End Try
                End If
                If Me.m_TipoDispositivo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60 Or Me.m_TipoDispositivo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS64 Then
                    hDevice.ControlPin3(param1, param2, 250)
                End If

                hDevice.Close()
            Catch ex As Exception
                Try
                    hDevice.Close()
                    hDevice = Nothing
                Catch ex2 As Exception
                    hDevice = Nothing
                End Try
            End Try
        End Sub

        Private Sub StartThread(ByVal om As OPERATION_MODE)
            m_OperationMode = om
            m_WorkerThread = New Thread(New ThreadStart(AddressOf ReadThreadProc))
            m_WorkerThread.SetApartmentState(ApartmentState.STA)
            m_WorkerThread.Start()
        End Sub

        Private Function DoScanFS88H(ByVal hDevice As IntPtr) As Boolean
            Dim nStart As Integer = 0

            Dim bRC As Boolean = False

            Select Case m_OperationMode
                Case OPERATION_MODE.OM_CAPTURE

                    nStart = Environment.TickCount
                    bRC = ftrNativeLib.ftrAnsiSdkCreateTemplate(hDevice, m_byFingerPosition, m_pImage, m_pTemplate, _nOutTemplateSize)

                    If Not bRC Then m_nErrorCode = Marshal.GetLastWin32Error()

                    Exit Select

                Case OPERATION_MODE.OM_CREATE
                    Dim nOutTemplateSize As Integer = 0
                    nStart = Environment.TickCount
                    bRC = ftrNativeLib.ftrAnsiSdkCreateTemplate(hDevice, m_byFingerPosition, m_pImage, m_pTemplate, nOutTemplateSize)

                    If Not bRC Then
                        m_nErrorCode = Marshal.GetLastWin32Error()
                    Else
                        uscHuellaThumb._TemplateANSI = m_pTemplate
                        m_bStop = True
                    End If

                    Exit Select
                Case OPERATION_MODE.OM_VERIFY
                    Dim fScore As Single = 0
                    nStart = Environment.TickCount
                    bRC = ftrNativeLib.ftrAnsiSdkVerifyTemplate(hDevice, m_byFingerPosition, m_pTemplate, m_pImage, fScore)

                    If Not bRC Then
                        m_nErrorCode = Marshal.GetLastWin32Error()
                    Else
                        m_bStop = True
                    End If

                    Exit Select
                Case Else
            End Select


            If m_pImage IsNot Nothing Then
                Dim myFile As MyBitmapFile = New MyBitmapFile(m_ImageSize.nWidth, m_ImageSize.nHeight, m_pImage)
                Dim BmpStream As MemoryStream = New MemoryStream(myFile.BitmatFileData)
                Dim Bmp As Bitmap = New Bitmap(BmpStream)

                PBox_PreviewHuellas.Image = Bmp

                Dim nNfiq As Integer = 3
                Dim bOk As Boolean = False
                Dim m As Futronic.MathAPIHelper.Device = New Futronic.MathAPIHelper.Device
                m.Open()
                Dim xx As Boolean = m.MathImageNfIQ(m_pImage, m_ImageSize.nWidth, m_ImageSize.nHeight, nNfiq, bOk)
                m.Close()

                UpdateTextCalidadHuella(nNfiq)

            Else
                PBox_PreviewHuellas.Image = Nothing
            End If

            Return bRC
        End Function

        Private Sub ReadThreadProc()
            m_bStop = False
            Dim hDevice As IntPtr = OpenDevice()

            While Not m_bStop
                ftrNativeLib.ftrScanSetOptions(hDevice, 64, 64)
                ftrNativeLib.ftrScanSetDiodesStatus(hDevice, Byte.MaxValue, 0)
                If DoScanFS88H(hDevice) Then

                End If
            End While

            If bCancel = False Then

                Dim Bmp As Bitmap = New Bitmap(New MemoryStream((New MyBitmapFile(m_ImageSize.nWidth, m_ImageSize.nHeight, m_pImage)).BitmatFileData))
                Dim ms As MemoryStream = New MemoryStream()
                Bmp.Save(ms, ImageFormat.Bmp)
                uscHuellaThumb._ImagenHuellaByte = ms.ToArray()
                uscHuellaThumb._TemplateANSI = m_pTemplate
                uscHuellaThumb._LargoImgPixel = m_ImageSize.nWidth
                uscHuellaThumb._AnchoImgPixel = m_ImageSize.nHeight

                ftrNativeLib.ftrScanSetDiodesStatus(hDevice, 0, 0)
                ftrNativeLib.ftrScanCloseDevice(hDevice)
                hDevice = IntPtr.Zero


                Dim m_hDevice As ScanAPIHelperFS60.Device = New ScanAPIHelperFS60.Device()
                m_hDevice.Open()
                uscHuellaThumb._Wsq = m_hDevice.WSQ_FromRawImage(m_pImage, m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height, 0.75)
                m_hDevice.Close()


                Dim nNfiq As Integer = 0
                Dim bOk As Boolean = False
                Dim m As Futronic.MathAPIHelper.Device = New Futronic.MathAPIHelper.Device
                m.Open()
                Dim xx As Boolean = m.MathImageNfIQ(m_pImage, m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height, nNfiq, bOk)
                m.Close()
                uscHuellaThumb._IndiceCalidad = nNfiq

            End If


        End Sub

        Private Function OpenDevice() As IntPtr
            Dim hDevice As IntPtr = ftrNativeLib.ftrScanOpenDevice()

            If hDevice = IntPtr.Zero Then Return IntPtr.Zero

            m_ImageSize = New FTRSCAN_IMAGE_SIZE()

            If Not ftrNativeLib.ftrScanGetImageSize(hDevice, m_ImageSize) Then
                ftrNativeLib.ftrScanCloseDevice(hDevice)
                Return IntPtr.Zero
            End If

            m_pImage = New Byte(m_ImageSize.nImageSize - 1) {}
            Return hDevice
        End Function

        Private Function ConectarDispositivo() As Boolean

            Dim b As Boolean = False
            While b = False
                Try
                    Dim hDevice As New Device()
                    hDevice.Open()
                    Me.m_TipoDispositivo = hDevice.Information.DeviceCompatibility
                    hDevice.Close()
                    b = True
                Catch ex As Exception
                End Try
                If b = False AndAlso MsgBox("Dispositivo biométrico no conectado, por favor conecte en el puerto USB y click en Aceptar", MsgBoxStyle.OkCancel + MsgBoxStyle.Question) = MsgBoxResult.Cancel Then
                    Return False
                End If
            End While


            ProcesoLed(True)
            Dim imageSize As Size
            Dim workingThread As Thread
            Dim modeNumber As Integer = 1  '' Tamaño de la imagen

            Select Case Me.m_TipoDispositivo
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H
                    m_pTemplate = New Byte(ftrNativeLib.ftrAnsiSdkGetMaxTemplateSize() - 1) {}
                    bCancel = False
                    Try
                        StartThread(OPERATION_MODE.OM_CAPTURE)

                        btnCapturar.Text = "Capturar"
                    Catch ex As FutronicException

                    End Try
                    Return True

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10
                    Try
                        threadParams = New ThreadParameters
                        threadParams.hDevice = New Device()
                        threadParams.hDevice.Open()           ' Abrimos la conexion
                        If threadParams.hDevice.IsFingerPresent Then
                            Dim c As Integer = 0
                            While threadParams.hDevice.IsFingerPresent
                                MsgBox("Por favor, retire el dedo del cristal o limpie el equipo biométrico.", MsgBoxStyle.Information)
                                c = c + 1
                                If c > 5 Then 'si no se soluciona en el 6to intento se sale
                                    Try
                                        threadParams.hDevice.Close()
                                        threadParams.hDevice.Dispose()
                                        ProcesoLed(False)
                                        Return False
                                    Catch ex As Exception
                                        Return False
                                    End Try
                                End If
                            End While
                        End If

                        threadParams.continueProcess = True

                        workingThread = New Thread(New ParameterizedThreadStart(AddressOf DoScan))

                        threadParams.hDevice.InvertImage = True

                        imageSize = threadParams.hDevice.ImageSize
                        threadParams.height = imageSize.Height
                        threadParams.width = imageSize.Width

                        threadParams.imageData = New Byte(threadParams.height * threadParams.width - 1) {}

                        workingThread.Start(threadParams)
                        btnCapturar.Text = "Capturar"
                    Catch ex As FutronicException
                        Dim vv As Boolean
                        SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, vv))
                        If vv = True Then
                            threadParams.hDevice = Nothing
                            threadParams = Nothing
                        End If
                        Return False
                    End Try
                    Return True

                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60, Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS64
                    Try
                        threadParams = New ThreadParameters
                        threadParams.hDevice = New Device()
                        threadParams.hDevice.Open()          ' Abrimos la conexion
                        If threadParams.hDevice.IsFingerPresent Then
                            Dim c As Integer = 0
                            While threadParams.hDevice.IsFingerPresent
                                MsgBox("Por favor, retire el dedo del cristal o limpie el equipo biométrico.", MsgBoxStyle.Information)
                                c = c + 1
                                If c > 5 Then 'si no se soluciona en el 6to intento se sale
                                    Try
                                        threadParams.hDevice.Close()
                                        threadParams.hDevice.Dispose()
                                        ProcesoLed(False)
                                        Return False
                                    Catch ex As Exception
                                        Return False
                                    End Try
                                End If
                            End While
                        End If

                        threadParams.continueProcess = True

                        workingThread = New Thread(New ParameterizedThreadStart(AddressOf DoScan))

                        threadParams.hDevice.InvertImage = True
                        threadParams.hDevice.PreviewMode = True

                        imageSize = threadParams.hDevice.ImageSize
                        threadParams.height = imageSize.Height
                        threadParams.width = imageSize.Width

                        threadParams.hDevice.ImageFormat = 1
                        threadParams.mode = 1

                        threadParams.imageDataSeg = New Byte(threadParams.height * threadParams.width - 1) {}

                        threadParams.paramSeg.nParamAngle = SegmAdjustment.noangle
                        threadParams.paramSeg.nWidthSubf = MathNums.xsize
                        threadParams.paramSeg.nHeightSubf = MathNums.ysize

                        threadParams.paramSeg.nParamFing = SegmAdjustment.nfing1

                        threadParams.paramSeg.nParamNfiq = SegmAdjustment.qfutr

                        threadParams.paramSeg.nParamFixedSize = SegmAdjustment.fixedsize


                        threadParams.imageDataSubf = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) * threadParams.paramSeg.nParamFing - 1) {}
                        threadParams.dataSubf = New SubfPointCoord(threadParams.paramSeg.nParamFing - 1) {}

                        threadParams.imageData = New Byte(threadParams.height * threadParams.width) {}

                        workingThread.Start(threadParams)
                        btnCapturar.Text = "Capturar"
                    Catch ex As FutronicException
                        Dim vv As Boolean
                        SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, vv))
                        If vv = True Then
                            threadParams.hDevice = Nothing
                            threadParams = Nothing
                        End If
                        Return False
                    End Try

                    Return True

            End Select

        End Function

        Private Sub Inicializar()

            Dim strMensaje As String = ""

            Me.btnAceptar.Text = "&Aceptar"
            Me.btnAceptar.Image = My.Resources.accept_32

            Dim b As Boolean = False
            If dispositivoAbierto = False Then
                While b = False
                    Try
                        Dim hDevice As New Device()
                        hDevice.Open()
                        Me.m_TipoDispositivo = hDevice.Information.DeviceCompatibility
                        lblScanner.Text = "Scanner: " & Lector.Futronic.LoadDll.getScannerName(Me.m_TipoDispositivo)
                        lblFilmware.Text = "Filmware: " & hDevice.VersionInformation.FirmwareVersion.ToString()
                        lblHardware.Text = "Hardware: " & hDevice.VersionInformation.HardwareVersion.ToString()
                        hDevice.Close()
                        b = True
                        dispositivoAbierto = True
                    Catch ex As Exception
                    End Try
                    If b = False AndAlso MsgBox("Dispositivo biométrico no conectado, por favor conecte en el puerto USB y click en Aceptar", MsgBoxStyle.OkCancel + MsgBoxStyle.Question) = MsgBoxResult.Cancel Then
                        Me.Close()
                        Exit Sub
                    End If
                End While
            End If

            uscHuellaThumb._TipoDedo = Me.n_indice_huella
            Select Case Me.n_indice_huella
                Case TipoDedo.MeniqueIzquierdo
                    usc_izq_men.Visible = True
                Case TipoDedo.AnularIzquierdo
                    ucs_izq_anu.Visible = True
                Case TipoDedo.MedioIzquierdo
                    usc_izq_med.Visible = True
                Case TipoDedo.IndiceIzquierdo
                    usc_izq_ind.Visible = True
                Case TipoDedo.PulgarIzquierdo
                    usc_izq_pul.Visible = True
                Case TipoDedo.PulgarDerecho
                    usc_der_pul.Visible = True
                Case TipoDedo.IndiceDerecho
                    usc_der_ind.Visible = True
                Case TipoDedo.MedioDerecho
                    usc_der_med.Visible = True
                Case TipoDedo.AnularDerecho
                    usc_der_anu.Visible = True
                Case TipoDedo.MeniqueDerecho
                    usc_der_men.Visible = True
            End Select


            If Not System.IO.Directory.Exists(c_dirPathWSQ) Then System.IO.Directory.CreateDirectory(c_dirPathWSQ)
            If Not System.IO.Directory.Exists(c_dirPathBMP) Then System.IO.Directory.CreateDirectory(c_dirPathBMP)
            If Not System.IO.Directory.Exists(c_dirPathANSI) Then System.IO.Directory.CreateDirectory(c_dirPathANSI)
            If Not System.IO.Directory.Exists(c_dirPathISO) Then System.IO.Directory.CreateDirectory(c_dirPathISO)

            With lstIconoDedos
                .Add(usc_izq_men)
                .Add(ucs_izq_anu)
                .Add(usc_izq_med)
                .Add(usc_izq_ind)
                .Add(usc_izq_pul)
                .Add(usc_der_pul)
                .Add(usc_der_ind)
                .Add(usc_der_med)
                .Add(usc_der_anu)
                .Add(usc_der_men)
            End With
            uscHuellaThumb.btnObs.Visible = True
            uscHuellaThumb._Observacion = Me._Observacion
        End Sub
#End Region

        Private Sub btnCapturar_Click(sender As System.Object, e As System.EventArgs) Handles btnCapturar.Click
            lblMessage.Text = ""

            If btnCapturar.Text = "Iniciar captura" Then
                If uscHuellaThumb._EstadoDedo = EstadoDedo.NoDisponible Then
                    MsgBox("Operación no válida, el dedo se encuentra marcado como observado.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                btnCapturar.Text = "Capturar"
                btnAbortarCap.Enabled = True
                'btnCancelar.Enabled = False
                btnAceptar.Enabled = False
                If ConectarDispositivo() Then

                End If
            Else
                btnCapturar.Text = "Iniciar captura"
                btnAbortarCap.Enabled = False
                If Me.m_TipoDispositivo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H Then

                    m_bStop = True

                Else
                    Try
                        threadParams.continueProcess = False
                    Catch ex As Exception

                    End Try
                End If
                btnAceptar.Enabled = True
            End If

        End Sub


        Private Sub cancelarCaptura()
            If Me.m_TipoDispositivo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H Then
                m_bStop = True
                Me.bCancel = True
            Else
                Try
                    If Not threadParams Is Nothing AndAlso Not threadParams.hDevice Is Nothing Then
                        Try
                            Me.bCancel = True
                            threadParams.hDevice.AbortRoll(False)
                        Catch ex As FutronicException

                        Catch ex2 As Exception

                        End Try
                        threadParams.continueProcess = False
                    End If

                Catch ex As Exception

                End Try
            End If

            btnCapturar.Enabled = True
            btnAceptar.Enabled = True

            btnAbortarCap.Enabled = False
            btnCapturar.Text = "Iniciar captura"
        End Sub

        Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
            cancelarCaptura()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub

        Private Sub btnAbortarCap_Click(sender As System.Object, e As System.EventArgs) Handles btnAbortarCap.Click
            cancelarCaptura()
        End Sub

        Private Sub uscHuella__DobleClick(sender As uscThumbFinger) Handles uscHuellaThumb._DobleClick
            Dim f As New frmVisorHuella()
            f.PictureBox1.Image = sender._Imagen
            f.ShowDialog()
        End Sub

        Public Sub New(indiceHuella As Integer)
            InitializeComponent()
            Me.n_indice_huella = indiceHuella
        End Sub

        Private Sub frmCapturaUniDac_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
            Inicializar()
        End Sub


        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            GrabarTemporal()

        End Sub

        Private Sub frmCapturaMonoDac_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            If System.IO.Directory.Exists(c_dirPathANSI) = False Then System.IO.Directory.CreateDirectory(c_dirPathANSI)
            If System.IO.Directory.Exists(c_dirPathBMP) = False Then System.IO.Directory.CreateDirectory(c_dirPathBMP)
            If System.IO.Directory.Exists(c_dirPathWSQ) = False Then System.IO.Directory.CreateDirectory(c_dirPathWSQ)
            If System.IO.Directory.Exists(c_dirPathISO) = False Then System.IO.Directory.CreateDirectory(c_dirPathISO)
        End Sub

        Private Sub frmCapturaMonoDac_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = Windows.Forms.Keys.ControlKey Then 'simular doble pulsacion de tecla(analogo al doble click)
                If bCountTimeON = False Then
                    nCountTime = 0
                    bCountTimeON = True
                    tmrControlPulsacion.Start()
                Else
                    bCountTimeON = False
                    tmrControlPulsacion.Stop()
                    'MsgBox(nCountTime)
                    btnCapturar.PerformClick()
                End If
            End If
        End Sub
        Private Sub tmrControlPulsacion_Tick(sender As System.Object, e As System.EventArgs) Handles tmrControlPulsacion.Tick
            nCountTime = nCountTime + 1
            If nCountTime > 14 Then
                bCountTimeON = False
                nCountTime = 0
            End If
        End Sub
    End Class
End Namespace