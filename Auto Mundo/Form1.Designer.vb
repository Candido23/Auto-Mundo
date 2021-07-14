<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GB_DatosG = New System.Windows.Forms.GroupBox()
        Me.Lb_Nombre = New System.Windows.Forms.Label()
        Me.TB_NCliente = New System.Windows.Forms.TextBox()
        Me.TB_NF = New System.Windows.Forms.TextBox()
        Me.Lb_Factura = New System.Windows.Forms.Label()
        Me.GB_TipoRines = New System.Windows.Forms.GroupBox()
        Me.TB_PrecioRines = New System.Windows.Forms.TextBox()
        Me.CbB_TipoRi = New System.Windows.Forms.ComboBox()
        Me.GB_TamañoRines = New System.Windows.Forms.GroupBox()
        Me.TB_PrecioR17 = New System.Windows.Forms.TextBox()
        Me.TB_PrecioR16 = New System.Windows.Forms.TextBox()
        Me.RBton_R17 = New System.Windows.Forms.RadioButton()
        Me.RBton_R16 = New System.Windows.Forms.RadioButton()
        Me.RBton_R15 = New System.Windows.Forms.RadioButton()
        Me.TB_PrecioR15 = New System.Windows.Forms.TextBox()
        Me.GB_Extra = New System.Windows.Forms.GroupBox()
        Me.TB_PrecioMante = New System.Windows.Forms.TextBox()
        Me.TB_PrecioSeguro = New System.Windows.Forms.TextBox()
        Me.TB_PrecioServicio = New System.Windows.Forms.TextBox()
        Me.ChBx_Servicio = New System.Windows.Forms.CheckBox()
        Me.ChBx_Seguro = New System.Windows.Forms.CheckBox()
        Me.ChBx_Mantenimiento = New System.Windows.Forms.CheckBox()
        Me.TB_PrecioInsta = New System.Windows.Forms.TextBox()
        Me.ChBx_Insta = New System.Windows.Forms.CheckBox()
        Me.TB_DescuenEfectivo = New System.Windows.Forms.TextBox()
        Me.GB_Formapago = New System.Windows.Forms.GroupBox()
        Me.TB_RecargarTarjeta = New System.Windows.Forms.TextBox()
        Me.RBton_Tarjeta = New System.Windows.Forms.RadioButton()
        Me.RBton_Efectivo = New System.Windows.Forms.RadioButton()
        Me.GB_Contadores = New System.Windows.Forms.GroupBox()
        Me.TB_ContadorMagnesio = New System.Windows.Forms.TextBox()
        Me.TB_ContadorAluminio = New System.Windows.Forms.TextBox()
        Me.Lb_Magnesio = New System.Windows.Forms.Label()
        Me.Lb_Aluminio = New System.Windows.Forms.Label()
        Me.TB_ContadorAcero = New System.Windows.Forms.TextBox()
        Me.Lb_Acero = New System.Windows.Forms.Label()
        Me.GB_Factura = New System.Windows.Forms.GroupBox()
        Me.TB_Recargo = New System.Windows.Forms.TextBox()
        Me.Lb_Recarga = New System.Windows.Forms.Label()
        Me.TB_Total = New System.Windows.Forms.TextBox()
        Me.TB_ISV = New System.Windows.Forms.TextBox()
        Me.Lb_Totalp = New System.Windows.Forms.Label()
        Me.Lb_ISV = New System.Windows.Forms.Label()
        Me.TB_Extras = New System.Windows.Forms.TextBox()
        Me.TB_Subtotal = New System.Windows.Forms.TextBox()
        Me.Lb_Ex = New System.Windows.Forms.Label()
        Me.Lb_Sub = New System.Windows.Forms.Label()
        Me.Lb_Des = New System.Windows.Forms.Label()
        Me.TB_Descuento = New System.Windows.Forms.TextBox()
        Me.GB_Salida = New System.Windows.Forms.GroupBox()
        Me.Bton_Borrar = New System.Windows.Forms.Button()
        Me.Bton_Salir = New System.Windows.Forms.Button()
        Me.Bton_Limpio = New System.Windows.Forms.Button()
        Me.Bton_Nuevo = New System.Windows.Forms.Button()
        Me.Bton_Agregar = New System.Windows.Forms.Button()
        Me.Bton_Cal = New System.Windows.Forms.Button()
        Me.LV_Datos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.GB_DatosG.SuspendLayout()
        Me.GB_TipoRines.SuspendLayout()
        Me.GB_TamañoRines.SuspendLayout()
        Me.GB_Extra.SuspendLayout()
        Me.GB_Formapago.SuspendLayout()
        Me.GB_Contadores.SuspendLayout()
        Me.GB_Factura.SuspendLayout()
        Me.GB_Salida.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_DatosG
        '
        Me.GB_DatosG.Controls.Add(Me.Lb_Nombre)
        Me.GB_DatosG.Controls.Add(Me.TB_NCliente)
        Me.GB_DatosG.Controls.Add(Me.TB_NF)
        Me.GB_DatosG.Controls.Add(Me.Lb_Factura)
        Me.GB_DatosG.Location = New System.Drawing.Point(12, 123)
        Me.GB_DatosG.Name = "GB_DatosG"
        Me.GB_DatosG.Size = New System.Drawing.Size(349, 116)
        Me.GB_DatosG.TabIndex = 0
        Me.GB_DatosG.TabStop = False
        Me.GB_DatosG.Text = "Datos Generales"
        '
        'Lb_Nombre
        '
        Me.Lb_Nombre.AutoSize = True
        Me.Lb_Nombre.Location = New System.Drawing.Point(6, 74)
        Me.Lb_Nombre.Name = "Lb_Nombre"
        Me.Lb_Nombre.Size = New System.Drawing.Size(112, 20)
        Me.Lb_Nombre.TabIndex = 3
        Me.Lb_Nombre.Text = "Nombre cliente"
        '
        'TB_NCliente
        '
        Me.TB_NCliente.Location = New System.Drawing.Point(155, 71)
        Me.TB_NCliente.Name = "TB_NCliente"
        Me.TB_NCliente.Size = New System.Drawing.Size(185, 27)
        Me.TB_NCliente.TabIndex = 2
        '
        'TB_NF
        '
        Me.TB_NF.Location = New System.Drawing.Point(155, 26)
        Me.TB_NF.Name = "TB_NF"
        Me.TB_NF.Size = New System.Drawing.Size(185, 27)
        Me.TB_NF.TabIndex = 1
        '
        'Lb_Factura
        '
        Me.Lb_Factura.AutoSize = True
        Me.Lb_Factura.Location = New System.Drawing.Point(3, 23)
        Me.Lb_Factura.Name = "Lb_Factura"
        Me.Lb_Factura.Size = New System.Drawing.Size(114, 20)
        Me.Lb_Factura.TabIndex = 0
        Me.Lb_Factura.Text = "Numero Factura"
        '
        'GB_TipoRines
        '
        Me.GB_TipoRines.Controls.Add(Me.TB_PrecioRines)
        Me.GB_TipoRines.Controls.Add(Me.CbB_TipoRi)
        Me.GB_TipoRines.Location = New System.Drawing.Point(18, 283)
        Me.GB_TipoRines.Name = "GB_TipoRines"
        Me.GB_TipoRines.Size = New System.Drawing.Size(352, 77)
        Me.GB_TipoRines.TabIndex = 4
        Me.GB_TipoRines.TabStop = False
        Me.GB_TipoRines.Text = "Tipo de rines                                    Precio"
        '
        'TB_PrecioRines
        '
        Me.TB_PrecioRines.Location = New System.Drawing.Point(209, 26)
        Me.TB_PrecioRines.Name = "TB_PrecioRines"
        Me.TB_PrecioRines.Size = New System.Drawing.Size(125, 27)
        Me.TB_PrecioRines.TabIndex = 1
        '
        'CbB_TipoRi
        '
        Me.CbB_TipoRi.FormattingEnabled = True
        Me.CbB_TipoRi.Items.AddRange(New Object() {"1-Rines de acero", "2-Rines de aluminio", "3-Rines de magnesio"})
        Me.CbB_TipoRi.Location = New System.Drawing.Point(3, 23)
        Me.CbB_TipoRi.Name = "CbB_TipoRi"
        Me.CbB_TipoRi.Size = New System.Drawing.Size(151, 28)
        Me.CbB_TipoRi.TabIndex = 0
        Me.CbB_TipoRi.Text = "Seleccione"
        '
        'GB_TamañoRines
        '
        Me.GB_TamañoRines.Controls.Add(Me.TB_PrecioR17)
        Me.GB_TamañoRines.Controls.Add(Me.TB_PrecioR16)
        Me.GB_TamañoRines.Controls.Add(Me.RBton_R17)
        Me.GB_TamañoRines.Controls.Add(Me.RBton_R16)
        Me.GB_TamañoRines.Controls.Add(Me.RBton_R15)
        Me.GB_TamañoRines.Controls.Add(Me.TB_PrecioR15)
        Me.GB_TamañoRines.Location = New System.Drawing.Point(21, 383)
        Me.GB_TamañoRines.Name = "GB_TamañoRines"
        Me.GB_TamañoRines.Size = New System.Drawing.Size(359, 137)
        Me.GB_TamañoRines.TabIndex = 1
        Me.GB_TamañoRines.TabStop = False
        Me.GB_TamañoRines.Text = "Tamaño                                                Adicional"
        '
        'TB_PrecioR17
        '
        Me.TB_PrecioR17.Location = New System.Drawing.Point(215, 97)
        Me.TB_PrecioR17.Name = "TB_PrecioR17"
        Me.TB_PrecioR17.Size = New System.Drawing.Size(125, 27)
        Me.TB_PrecioR17.TabIndex = 5
        '
        'TB_PrecioR16
        '
        Me.TB_PrecioR16.Location = New System.Drawing.Point(215, 64)
        Me.TB_PrecioR16.Name = "TB_PrecioR16"
        Me.TB_PrecioR16.Size = New System.Drawing.Size(125, 27)
        Me.TB_PrecioR16.TabIndex = 4
        '
        'RBton_R17
        '
        Me.RBton_R17.AutoSize = True
        Me.RBton_R17.Location = New System.Drawing.Point(6, 100)
        Me.RBton_R17.Name = "RBton_R17"
        Me.RBton_R17.Size = New System.Drawing.Size(55, 24)
        Me.RBton_R17.TabIndex = 3
        Me.RBton_R17.TabStop = True
        Me.RBton_R17.Text = "R17"
        Me.RBton_R17.UseVisualStyleBackColor = True
        '
        'RBton_R16
        '
        Me.RBton_R16.AutoSize = True
        Me.RBton_R16.Location = New System.Drawing.Point(6, 67)
        Me.RBton_R16.Name = "RBton_R16"
        Me.RBton_R16.Size = New System.Drawing.Size(55, 24)
        Me.RBton_R16.TabIndex = 2
        Me.RBton_R16.TabStop = True
        Me.RBton_R16.Text = "R16"
        Me.RBton_R16.UseVisualStyleBackColor = True
        '
        'RBton_R15
        '
        Me.RBton_R15.AutoSize = True
        Me.RBton_R15.Location = New System.Drawing.Point(6, 29)
        Me.RBton_R15.Name = "RBton_R15"
        Me.RBton_R15.Size = New System.Drawing.Size(55, 24)
        Me.RBton_R15.TabIndex = 1
        Me.RBton_R15.TabStop = True
        Me.RBton_R15.Text = "R15"
        Me.RBton_R15.UseVisualStyleBackColor = True
        '
        'TB_PrecioR15
        '
        Me.TB_PrecioR15.Location = New System.Drawing.Point(215, 26)
        Me.TB_PrecioR15.Name = "TB_PrecioR15"
        Me.TB_PrecioR15.Size = New System.Drawing.Size(125, 27)
        Me.TB_PrecioR15.TabIndex = 0
        '
        'GB_Extra
        '
        Me.GB_Extra.Controls.Add(Me.TB_PrecioMante)
        Me.GB_Extra.Controls.Add(Me.TB_PrecioSeguro)
        Me.GB_Extra.Controls.Add(Me.TB_PrecioServicio)
        Me.GB_Extra.Controls.Add(Me.ChBx_Servicio)
        Me.GB_Extra.Controls.Add(Me.ChBx_Seguro)
        Me.GB_Extra.Controls.Add(Me.ChBx_Mantenimiento)
        Me.GB_Extra.Controls.Add(Me.TB_PrecioInsta)
        Me.GB_Extra.Controls.Add(Me.ChBx_Insta)
        Me.GB_Extra.Location = New System.Drawing.Point(21, 541)
        Me.GB_Extra.Name = "GB_Extra"
        Me.GB_Extra.Size = New System.Drawing.Size(359, 158)
        Me.GB_Extra.TabIndex = 5
        Me.GB_Extra.TabStop = False
        Me.GB_Extra.Text = "Extra                                                     Precio"
        '
        'TB_PrecioMante
        '
        Me.TB_PrecioMante.Location = New System.Drawing.Point(215, 128)
        Me.TB_PrecioMante.Name = "TB_PrecioMante"
        Me.TB_PrecioMante.Size = New System.Drawing.Size(125, 27)
        Me.TB_PrecioMante.TabIndex = 7
        '
        'TB_PrecioSeguro
        '
        Me.TB_PrecioSeguro.Location = New System.Drawing.Point(215, 95)
        Me.TB_PrecioSeguro.Name = "TB_PrecioSeguro"
        Me.TB_PrecioSeguro.Size = New System.Drawing.Size(125, 27)
        Me.TB_PrecioSeguro.TabIndex = 6
        '
        'TB_PrecioServicio
        '
        Me.TB_PrecioServicio.Location = New System.Drawing.Point(215, 58)
        Me.TB_PrecioServicio.Name = "TB_PrecioServicio"
        Me.TB_PrecioServicio.Size = New System.Drawing.Size(125, 27)
        Me.TB_PrecioServicio.TabIndex = 5
        '
        'ChBx_Servicio
        '
        Me.ChBx_Servicio.AutoSize = True
        Me.ChBx_Servicio.Location = New System.Drawing.Point(6, 58)
        Me.ChBx_Servicio.Name = "ChBx_Servicio"
        Me.ChBx_Servicio.Size = New System.Drawing.Size(150, 24)
        Me.ChBx_Servicio.TabIndex = 4
        Me.ChBx_Servicio.Text = "Servicio domicilio"
        Me.ChBx_Servicio.UseVisualStyleBackColor = True
        '
        'ChBx_Seguro
        '
        Me.ChBx_Seguro.AutoSize = True
        Me.ChBx_Seguro.Location = New System.Drawing.Point(6, 98)
        Me.ChBx_Seguro.Name = "ChBx_Seguro"
        Me.ChBx_Seguro.Size = New System.Drawing.Size(78, 24)
        Me.ChBx_Seguro.TabIndex = 3
        Me.ChBx_Seguro.Text = "Seguro"
        Me.ChBx_Seguro.UseVisualStyleBackColor = True
        '
        'ChBx_Mantenimiento
        '
        Me.ChBx_Mantenimiento.AutoSize = True
        Me.ChBx_Mantenimiento.Location = New System.Drawing.Point(6, 128)
        Me.ChBx_Mantenimiento.Name = "ChBx_Mantenimiento"
        Me.ChBx_Mantenimiento.Size = New System.Drawing.Size(132, 24)
        Me.ChBx_Mantenimiento.TabIndex = 2
        Me.ChBx_Mantenimiento.Text = "Mantenimiento"
        Me.ChBx_Mantenimiento.UseVisualStyleBackColor = True
        '
        'TB_PrecioInsta
        '
        Me.TB_PrecioInsta.Location = New System.Drawing.Point(215, 23)
        Me.TB_PrecioInsta.Name = "TB_PrecioInsta"
        Me.TB_PrecioInsta.Size = New System.Drawing.Size(125, 27)
        Me.TB_PrecioInsta.TabIndex = 1
        '
        'ChBx_Insta
        '
        Me.ChBx_Insta.AutoSize = True
        Me.ChBx_Insta.Location = New System.Drawing.Point(3, 23)
        Me.ChBx_Insta.Name = "ChBx_Insta"
        Me.ChBx_Insta.Size = New System.Drawing.Size(102, 24)
        Me.ChBx_Insta.TabIndex = 0
        Me.ChBx_Insta.Text = "Instalacion"
        Me.ChBx_Insta.UseVisualStyleBackColor = True
        '
        'TB_DescuenEfectivo
        '
        Me.TB_DescuenEfectivo.Location = New System.Drawing.Point(209, 26)
        Me.TB_DescuenEfectivo.Name = "TB_DescuenEfectivo"
        Me.TB_DescuenEfectivo.Size = New System.Drawing.Size(125, 27)
        Me.TB_DescuenEfectivo.TabIndex = 8
        '
        'GB_Formapago
        '
        Me.GB_Formapago.Controls.Add(Me.TB_RecargarTarjeta)
        Me.GB_Formapago.Controls.Add(Me.RBton_Tarjeta)
        Me.GB_Formapago.Controls.Add(Me.TB_DescuenEfectivo)
        Me.GB_Formapago.Controls.Add(Me.RBton_Efectivo)
        Me.GB_Formapago.Location = New System.Drawing.Point(18, 721)
        Me.GB_Formapago.Name = "GB_Formapago"
        Me.GB_Formapago.Size = New System.Drawing.Size(343, 125)
        Me.GB_Formapago.TabIndex = 9
        Me.GB_Formapago.TabStop = False
        Me.GB_Formapago.Text = "Forma de pago"
        '
        'TB_RecargarTarjeta
        '
        Me.TB_RecargarTarjeta.Location = New System.Drawing.Point(209, 82)
        Me.TB_RecargarTarjeta.Name = "TB_RecargarTarjeta"
        Me.TB_RecargarTarjeta.Size = New System.Drawing.Size(125, 27)
        Me.TB_RecargarTarjeta.TabIndex = 10
        '
        'RBton_Tarjeta
        '
        Me.RBton_Tarjeta.AutoSize = True
        Me.RBton_Tarjeta.Location = New System.Drawing.Point(20, 82)
        Me.RBton_Tarjeta.Name = "RBton_Tarjeta"
        Me.RBton_Tarjeta.Size = New System.Drawing.Size(74, 24)
        Me.RBton_Tarjeta.TabIndex = 9
        Me.RBton_Tarjeta.TabStop = True
        Me.RBton_Tarjeta.Text = "Tarjeta"
        Me.RBton_Tarjeta.UseVisualStyleBackColor = True
        '
        'RBton_Efectivo
        '
        Me.RBton_Efectivo.AutoSize = True
        Me.RBton_Efectivo.Location = New System.Drawing.Point(20, 39)
        Me.RBton_Efectivo.Name = "RBton_Efectivo"
        Me.RBton_Efectivo.Size = New System.Drawing.Size(83, 24)
        Me.RBton_Efectivo.TabIndex = 0
        Me.RBton_Efectivo.TabStop = True
        Me.RBton_Efectivo.Text = "Efectivo"
        Me.RBton_Efectivo.UseVisualStyleBackColor = True
        '
        'GB_Contadores
        '
        Me.GB_Contadores.Controls.Add(Me.TB_ContadorMagnesio)
        Me.GB_Contadores.Controls.Add(Me.TB_ContadorAluminio)
        Me.GB_Contadores.Controls.Add(Me.Lb_Magnesio)
        Me.GB_Contadores.Controls.Add(Me.Lb_Aluminio)
        Me.GB_Contadores.Controls.Add(Me.TB_ContadorAcero)
        Me.GB_Contadores.Controls.Add(Me.Lb_Acero)
        Me.GB_Contadores.Location = New System.Drawing.Point(421, 123)
        Me.GB_Contadores.Name = "GB_Contadores"
        Me.GB_Contadores.Size = New System.Drawing.Size(595, 125)
        Me.GB_Contadores.TabIndex = 10
        Me.GB_Contadores.TabStop = False
        Me.GB_Contadores.Text = "Contador"
        '
        'TB_ContadorMagnesio
        '
        Me.TB_ContadorMagnesio.Location = New System.Drawing.Point(433, 71)
        Me.TB_ContadorMagnesio.Name = "TB_ContadorMagnesio"
        Me.TB_ContadorMagnesio.Size = New System.Drawing.Size(125, 27)
        Me.TB_ContadorMagnesio.TabIndex = 5
        '
        'TB_ContadorAluminio
        '
        Me.TB_ContadorAluminio.Location = New System.Drawing.Point(234, 71)
        Me.TB_ContadorAluminio.Name = "TB_ContadorAluminio"
        Me.TB_ContadorAluminio.Size = New System.Drawing.Size(125, 27)
        Me.TB_ContadorAluminio.TabIndex = 4
        '
        'Lb_Magnesio
        '
        Me.Lb_Magnesio.AutoSize = True
        Me.Lb_Magnesio.Location = New System.Drawing.Point(445, 33)
        Me.Lb_Magnesio.Name = "Lb_Magnesio"
        Me.Lb_Magnesio.Size = New System.Drawing.Size(113, 20)
        Me.Lb_Magnesio.TabIndex = 3
        Me.Lb_Magnesio.Text = "Rines Magnesio"
        '
        'Lb_Aluminio
        '
        Me.Lb_Aluminio.AutoSize = True
        Me.Lb_Aluminio.Location = New System.Drawing.Point(253, 33)
        Me.Lb_Aluminio.Name = "Lb_Aluminio"
        Me.Lb_Aluminio.Size = New System.Drawing.Size(106, 20)
        Me.Lb_Aluminio.TabIndex = 2
        Me.Lb_Aluminio.Text = "Rines aluminio"
        '
        'TB_ContadorAcero
        '
        Me.TB_ContadorAcero.Location = New System.Drawing.Point(53, 71)
        Me.TB_ContadorAcero.Name = "TB_ContadorAcero"
        Me.TB_ContadorAcero.Size = New System.Drawing.Size(125, 27)
        Me.TB_ContadorAcero.TabIndex = 1
        '
        'Lb_Acero
        '
        Me.Lb_Acero.AutoSize = True
        Me.Lb_Acero.Location = New System.Drawing.Point(72, 33)
        Me.Lb_Acero.Name = "Lb_Acero"
        Me.Lb_Acero.Size = New System.Drawing.Size(87, 20)
        Me.Lb_Acero.TabIndex = 0
        Me.Lb_Acero.Text = "Rines Acero"
        '
        'GB_Factura
        '
        Me.GB_Factura.Controls.Add(Me.TB_Recargo)
        Me.GB_Factura.Controls.Add(Me.Lb_Recarga)
        Me.GB_Factura.Controls.Add(Me.TB_Total)
        Me.GB_Factura.Controls.Add(Me.TB_ISV)
        Me.GB_Factura.Controls.Add(Me.Lb_Totalp)
        Me.GB_Factura.Controls.Add(Me.Lb_ISV)
        Me.GB_Factura.Controls.Add(Me.TB_Extras)
        Me.GB_Factura.Controls.Add(Me.TB_Subtotal)
        Me.GB_Factura.Controls.Add(Me.Lb_Ex)
        Me.GB_Factura.Controls.Add(Me.Lb_Sub)
        Me.GB_Factura.Controls.Add(Me.Lb_Des)
        Me.GB_Factura.Controls.Add(Me.TB_Descuento)
        Me.GB_Factura.Location = New System.Drawing.Point(1083, 123)
        Me.GB_Factura.Name = "GB_Factura"
        Me.GB_Factura.Size = New System.Drawing.Size(460, 214)
        Me.GB_Factura.TabIndex = 11
        Me.GB_Factura.TabStop = False
        Me.GB_Factura.Text = "Factura"
        '
        'TB_Recargo
        '
        Me.TB_Recargo.Location = New System.Drawing.Point(329, 163)
        Me.TB_Recargo.Name = "TB_Recargo"
        Me.TB_Recargo.Size = New System.Drawing.Size(125, 27)
        Me.TB_Recargo.TabIndex = 11
        '
        'Lb_Recarga
        '
        Me.Lb_Recarga.AutoSize = True
        Me.Lb_Recarga.Location = New System.Drawing.Point(379, 137)
        Me.Lb_Recarga.Name = "Lb_Recarga"
        Me.Lb_Recarga.Size = New System.Drawing.Size(63, 20)
        Me.Lb_Recarga.TabIndex = 10
        Me.Lb_Recarga.Text = "Recarga"
        '
        'TB_Total
        '
        Me.TB_Total.Location = New System.Drawing.Point(176, 163)
        Me.TB_Total.Name = "TB_Total"
        Me.TB_Total.Size = New System.Drawing.Size(125, 27)
        Me.TB_Total.TabIndex = 9
        '
        'TB_ISV
        '
        Me.TB_ISV.Location = New System.Drawing.Point(6, 163)
        Me.TB_ISV.Name = "TB_ISV"
        Me.TB_ISV.Size = New System.Drawing.Size(125, 27)
        Me.TB_ISV.TabIndex = 8
        '
        'Lb_Totalp
        '
        Me.Lb_Totalp.AutoSize = True
        Me.Lb_Totalp.Location = New System.Drawing.Point(204, 137)
        Me.Lb_Totalp.Name = "Lb_Totalp"
        Me.Lb_Totalp.Size = New System.Drawing.Size(46, 20)
        Me.Lb_Totalp.TabIndex = 7
        Me.Lb_Totalp.Text = "Total "
        '
        'Lb_ISV
        '
        Me.Lb_ISV.AutoSize = True
        Me.Lb_ISV.Location = New System.Drawing.Point(31, 124)
        Me.Lb_ISV.Name = "Lb_ISV"
        Me.Lb_ISV.Size = New System.Drawing.Size(30, 20)
        Me.Lb_ISV.TabIndex = 6
        Me.Lb_ISV.Text = "ISV"
        Me.Lb_ISV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TB_Extras
        '
        Me.TB_Extras.Location = New System.Drawing.Point(329, 75)
        Me.TB_Extras.Name = "TB_Extras"
        Me.TB_Extras.Size = New System.Drawing.Size(125, 27)
        Me.TB_Extras.TabIndex = 5
        '
        'TB_Subtotal
        '
        Me.TB_Subtotal.Location = New System.Drawing.Point(176, 75)
        Me.TB_Subtotal.Name = "TB_Subtotal"
        Me.TB_Subtotal.Size = New System.Drawing.Size(125, 27)
        Me.TB_Subtotal.TabIndex = 4
        '
        'Lb_Ex
        '
        Me.Lb_Ex.AutoSize = True
        Me.Lb_Ex.Location = New System.Drawing.Point(379, 48)
        Me.Lb_Ex.Name = "Lb_Ex"
        Me.Lb_Ex.Size = New System.Drawing.Size(48, 20)
        Me.Lb_Ex.TabIndex = 3
        Me.Lb_Ex.Text = "Extras"
        '
        'Lb_Sub
        '
        Me.Lb_Sub.AutoSize = True
        Me.Lb_Sub.Location = New System.Drawing.Point(204, 48)
        Me.Lb_Sub.Name = "Lb_Sub"
        Me.Lb_Sub.Size = New System.Drawing.Size(65, 20)
        Me.Lb_Sub.TabIndex = 2
        Me.Lb_Sub.Text = "Subtotal"
        '
        'Lb_Des
        '
        Me.Lb_Des.AutoSize = True
        Me.Lb_Des.Location = New System.Drawing.Point(31, 43)
        Me.Lb_Des.Name = "Lb_Des"
        Me.Lb_Des.Size = New System.Drawing.Size(79, 20)
        Me.Lb_Des.TabIndex = 1
        Me.Lb_Des.Text = "Descuento"
        '
        'TB_Descuento
        '
        Me.TB_Descuento.Location = New System.Drawing.Point(6, 75)
        Me.TB_Descuento.Name = "TB_Descuento"
        Me.TB_Descuento.Size = New System.Drawing.Size(125, 27)
        Me.TB_Descuento.TabIndex = 0
        '
        'GB_Salida
        '
        Me.GB_Salida.Controls.Add(Me.Bton_Borrar)
        Me.GB_Salida.Controls.Add(Me.Bton_Salir)
        Me.GB_Salida.Controls.Add(Me.Bton_Limpio)
        Me.GB_Salida.Controls.Add(Me.Bton_Nuevo)
        Me.GB_Salida.Controls.Add(Me.Bton_Agregar)
        Me.GB_Salida.Controls.Add(Me.Bton_Cal)
        Me.GB_Salida.Controls.Add(Me.LV_Datos)
        Me.GB_Salida.Location = New System.Drawing.Point(421, 283)
        Me.GB_Salida.Name = "GB_Salida"
        Me.GB_Salida.Size = New System.Drawing.Size(637, 416)
        Me.GB_Salida.TabIndex = 10
        Me.GB_Salida.TabStop = False
        Me.GB_Salida.Text = "Salida"
        '
        'Bton_Borrar
        '
        Me.Bton_Borrar.Location = New System.Drawing.Point(539, 195)
        Me.Bton_Borrar.Name = "Bton_Borrar"
        Me.Bton_Borrar.Size = New System.Drawing.Size(94, 29)
        Me.Bton_Borrar.TabIndex = 6
        Me.Bton_Borrar.Text = "Borrar"
        Me.Bton_Borrar.UseVisualStyleBackColor = True
        '
        'Bton_Salir
        '
        Me.Bton_Salir.Location = New System.Drawing.Point(543, 281)
        Me.Bton_Salir.Name = "Bton_Salir"
        Me.Bton_Salir.Size = New System.Drawing.Size(94, 29)
        Me.Bton_Salir.TabIndex = 5
        Me.Bton_Salir.Text = "Salir"
        Me.Bton_Salir.UseVisualStyleBackColor = True
        '
        'Bton_Limpio
        '
        Me.Bton_Limpio.Location = New System.Drawing.Point(415, 372)
        Me.Bton_Limpio.Name = "Bton_Limpio"
        Me.Bton_Limpio.Size = New System.Drawing.Size(94, 29)
        Me.Bton_Limpio.TabIndex = 4
        Me.Bton_Limpio.Text = "Limpio"
        Me.Bton_Limpio.UseVisualStyleBackColor = True
        '
        'Bton_Nuevo
        '
        Me.Bton_Nuevo.Location = New System.Drawing.Point(265, 372)
        Me.Bton_Nuevo.Name = "Bton_Nuevo"
        Me.Bton_Nuevo.Size = New System.Drawing.Size(94, 29)
        Me.Bton_Nuevo.TabIndex = 3
        Me.Bton_Nuevo.Text = "Nuevo"
        Me.Bton_Nuevo.UseVisualStyleBackColor = True
        '
        'Bton_Agregar
        '
        Me.Bton_Agregar.Location = New System.Drawing.Point(145, 372)
        Me.Bton_Agregar.Name = "Bton_Agregar"
        Me.Bton_Agregar.Size = New System.Drawing.Size(94, 29)
        Me.Bton_Agregar.TabIndex = 2
        Me.Bton_Agregar.Text = "Agregar"
        Me.Bton_Agregar.UseVisualStyleBackColor = True
        '
        'Bton_Cal
        '
        Me.Bton_Cal.Location = New System.Drawing.Point(6, 372)
        Me.Bton_Cal.Name = "Bton_Cal"
        Me.Bton_Cal.Size = New System.Drawing.Size(94, 29)
        Me.Bton_Cal.TabIndex = 1
        Me.Bton_Cal.Text = "Calculo"
        Me.Bton_Cal.UseVisualStyleBackColor = True
        '
        'LV_Datos
        '
        Me.LV_Datos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LV_Datos.FullRowSelect = True
        Me.LV_Datos.GridLines = True
        Me.LV_Datos.HideSelection = False
        Me.LV_Datos.Location = New System.Drawing.Point(85, 26)
        Me.LV_Datos.Name = "LV_Datos"
        Me.LV_Datos.Size = New System.Drawing.Size(448, 317)
        Me.LV_Datos.TabIndex = 0
        Me.LV_Datos.UseCompatibleStateImageBehavior = False
        Me.LV_Datos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Numero Factura"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre Cliente"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Pagar"
        Me.ColumnHeader3.Width = 95
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1655, 858)
        Me.Controls.Add(Me.GB_Salida)
        Me.Controls.Add(Me.GB_Factura)
        Me.Controls.Add(Me.GB_Contadores)
        Me.Controls.Add(Me.GB_Formapago)
        Me.Controls.Add(Me.GB_Extra)
        Me.Controls.Add(Me.GB_TipoRines)
        Me.Controls.Add(Me.GB_TamañoRines)
        Me.Controls.Add(Me.GB_DatosG)
        Me.Name = "Form1"
        Me.Text = "AUTO MUNDO"
        Me.GB_DatosG.ResumeLayout(False)
        Me.GB_DatosG.PerformLayout()
        Me.GB_TipoRines.ResumeLayout(False)
        Me.GB_TipoRines.PerformLayout()
        Me.GB_TamañoRines.ResumeLayout(False)
        Me.GB_TamañoRines.PerformLayout()
        Me.GB_Extra.ResumeLayout(False)
        Me.GB_Extra.PerformLayout()
        Me.GB_Formapago.ResumeLayout(False)
        Me.GB_Formapago.PerformLayout()
        Me.GB_Contadores.ResumeLayout(False)
        Me.GB_Contadores.PerformLayout()
        Me.GB_Factura.ResumeLayout(False)
        Me.GB_Factura.PerformLayout()
        Me.GB_Salida.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_DatosG As GroupBox
    Friend WithEvents Lb_Nombre As Label
    Friend WithEvents TB_NCliente As TextBox
    Friend WithEvents TB_NF As TextBox
    Friend WithEvents Lb_Factura As Label
    Friend WithEvents GB_TipoRines As GroupBox
    Friend WithEvents TB_PrecioRines As TextBox
    Friend WithEvents CbB_TipoRi As ComboBox
    Friend WithEvents GB_TamañoRines As GroupBox
    Friend WithEvents TB_PrecioR17 As TextBox
    Friend WithEvents TB_PrecioR16 As TextBox
    Friend WithEvents RBton_R17 As RadioButton
    Friend WithEvents RBton_R16 As RadioButton
    Friend WithEvents RBton_R15 As RadioButton
    Friend WithEvents TB_PrecioR15 As TextBox
    Friend WithEvents GB_Extra As GroupBox
    Friend WithEvents TB_PrecioMante As TextBox
    Friend WithEvents TB_PrecioSeguro As TextBox
    Friend WithEvents TB_PrecioServicio As TextBox
    Friend WithEvents ChBx_Servicio As CheckBox
    Friend WithEvents ChBx_Seguro As CheckBox
    Friend WithEvents ChBx_Mantenimiento As CheckBox
    Friend WithEvents TB_PrecioInsta As TextBox
    Friend WithEvents ChBx_Insta As CheckBox
    Friend WithEvents TB_DescuenEfectivo As TextBox
    Friend WithEvents GB_Formapago As GroupBox
    Friend WithEvents TB_RecargarTarjeta As TextBox
    Friend WithEvents RBton_Tarjeta As RadioButton
    Friend WithEvents RBton_Efectivo As RadioButton
    Friend WithEvents GB_Contadores As GroupBox
    Friend WithEvents TB_ContadorMagnesio As TextBox
    Friend WithEvents TB_ContadorAluminio As TextBox
    Friend WithEvents Lb_Magnesio As Label
    Friend WithEvents Lb_Aluminio As Label
    Friend WithEvents TB_ContadorAcero As TextBox
    Friend WithEvents Lb_Acero As Label
    Friend WithEvents GB_Factura As GroupBox
    Friend WithEvents TB_Total As TextBox
    Friend WithEvents TB_ISV As TextBox
    Friend WithEvents Lb_Totalp As Label
    Friend WithEvents Lb_ISV As Label
    Friend WithEvents TB_Extras As TextBox
    Friend WithEvents TB_Subtotal As TextBox
    Friend WithEvents Lb_Ex As Label
    Friend WithEvents Lb_Sub As Label
    Friend WithEvents Lb_Des As Label
    Friend WithEvents TB_Descuento As TextBox
    Friend WithEvents GB_Salida As GroupBox
    Friend WithEvents Bton_Borrar As Button
    Friend WithEvents Bton_Salir As Button
    Friend WithEvents Bton_Limpio As Button
    Friend WithEvents Bton_Nuevo As Button
    Friend WithEvents Bton_Agregar As Button
    Friend WithEvents Bton_Cal As Button
    Friend WithEvents LV_Datos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TB_Recargo As TextBox
    Friend WithEvents Lb_Recarga As Label
End Class
