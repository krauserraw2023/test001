

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoto
    Inherits Legolas.APPUIComponents.FormPopup

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFoto))
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PicResultado = New System.Windows.Forms.PictureBox()
        Me.WebCam1 = New WebCAM.WebCam()
        Me.gbxFormChildContainer.SuspendLayout()
        CType(Me.PicResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxFormChildContainer
        '
        Me.gbxFormChildContainer.Controls.Add(Me.WebCam1)
        Me.gbxFormChildContainer.Controls.Add(Me.btnCapturar)
        Me.gbxFormChildContainer.Controls.Add(Me.btnSalir)
        Me.gbxFormChildContainer.Size = New System.Drawing.Size(630, 459)
        '
        'btnCapturar
        '
        Me.btnCapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapturar.ForeColor = System.Drawing.Color.Black
        Me.btnCapturar.Image = Global.APPCamaraWeb.My.Resources.Resources._1337706653_webcam
        Me.btnCapturar.Location = New System.Drawing.Point(538, 320)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(88, 63)
        Me.btnCapturar.TabIndex = 42
        Me.btnCapturar.Text = "&Capurar"
        Me.btnCapturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCapturar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(538, 389)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 63)
        Me.btnSalir.TabIndex = 67
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(97, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 5)
        Me.Label4.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(94, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(4, 452)
        Me.Label2.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(432, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(4, 452)
        Me.Label1.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(96, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(339, 5)
        Me.Label3.TabIndex = 72
        '
        'PicResultado
        '
        Me.PicResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicResultado.Location = New System.Drawing.Point(649, 3)
        Me.PicResultado.Name = "PicResultado"
        Me.PicResultado.Size = New System.Drawing.Size(532, 452)
        Me.PicResultado.TabIndex = 73
        Me.PicResultado.TabStop = False
        Me.PicResultado.Visible = False
        '
        'WebCam1
        '
        Me.WebCam1.BackColor = System.Drawing.Color.Transparent
        Me.WebCam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WebCam1.Imagen = Nothing
        Me.WebCam1.Location = New System.Drawing.Point(0, 6)
        Me.WebCam1.MilisegundosCaptura = 100
        Me.WebCam1.Name = "WebCam1"
        Me.WebCam1.Size = New System.Drawing.Size(532, 452)
        Me.WebCam1.TabIndex = 69
        '
        'frmFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(630, 459)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicResultado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFoto"
        Me.Text = "Capturar Fotografia..."
        Me.Controls.SetChildIndex(Me.gbxFormChildContainer, 0)
        Me.Controls.SetChildIndex(Me.PicResultado, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.gbxFormChildContainer.ResumeLayout(False)
        CType(Me.PicResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCapturar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label    
    Friend WithEvents PicResultado As System.Windows.Forms.PictureBox
    Friend WithEvents WebCam1 As WebCAM.WebCam


End Class
