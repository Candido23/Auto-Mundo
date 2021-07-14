Public Class Form1
    Dim A, B, C, E1, CA, CAL, CM As String
    Dim F, G, H, I, J As Single

    Private Sub RBton_R17_CheckedChanged(sender As Object, e As EventArgs) Handles RBton_R17.CheckedChanged
        If RBton_R17.Checked = True Then
            TB_PrecioR17.Text = "1200"
            GB_Extra.Enabled = True
        Else
            RBton_R17.Enabled = False
            GB_Extra.Enabled = False
            TB_PrecioR17.Text = "0"
        End If
    End Sub

    Private Sub ChBx_Insta_CheckedChanged(sender As Object, e As EventArgs) Handles ChBx_Insta.CheckedChanged
        If ChBx_Insta.Checked = True Then
            TB_PrecioInsta.Text = "500"
            GB_Formapago.Enabled = True
        Else
            TB_PrecioInsta.Text = "0"
            GB_Formapago.Enabled = False
            GB_Formapago.Enabled = False
        End If
    End Sub

    Private Sub ChBx_Servicio_CheckedChanged(sender As Object, e As EventArgs) Handles ChBx_Servicio.CheckedChanged
        If ChBx_Servicio.Checked = True Then
            TB_PrecioServicio.Text = "700"
            GB_Formapago.Enabled = True
        Else
            TB_PrecioServicio.Text = "0"
            GB_Formapago.Enabled = False

        End If
    End Sub

    Private Sub ChBx_Seguro_CheckedChanged(sender As Object, e As EventArgs) Handles ChBx_Seguro.CheckedChanged
        If ChBx_Seguro.Checked = True Then
            TB_PrecioSeguro.Text = "600"
            GB_Formapago.Enabled = True
        Else
            TB_PrecioInsta.Text = "0"
            GB_Formapago.Enabled = False
        End If
    End Sub

    Private Sub ChBx_Mantenimiento_CheckedChanged(sender As Object, e As EventArgs) Handles ChBx_Mantenimiento.CheckedChanged
        If ChBx_Mantenimiento.Checked = True Then
            TB_PrecioMante.Text = "400"
            GB_Formapago.Enabled = True
        Else
            TB_PrecioMante.Text = "0"
            GB_Formapago.Enabled = False
        End If
    End Sub

    Private Sub RBton_Efectivo_CheckedChanged(sender As Object, e As EventArgs) Handles RBton_Efectivo.CheckedChanged
        If RBton_Efectivo.Checked = True Then
            TB_DescuenEfectivo.Text = "Descuento 3%"
            Bton_Cal.Enabled = True
        Else
            TB_DescuenEfectivo.Text = ""
            Bton_Cal.Enabled = False
        End If
    End Sub

    Private Sub RBton_Tarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles RBton_Tarjeta.CheckedChanged
        If RBton_Tarjeta.Checked = True Then
            TB_RecargarTarjeta.Text = "Recargo 2%"
            Bton_Cal.Enabled = True
        Else
            TB_Recargo.Text = ""

        End If
    End Sub

    Private Sub CbB_TipoRi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbB_TipoRi.SelectedIndexChanged
        B = CbB_TipoRi.SelectedIndex
        Select Case B
            Case 0
                C = 4500
                CA += 1
                TB_PrecioRines.Enabled = True
                GB_TamañoRines.Enabled = True
            Case 1
                C = 4000
                CAL += 1
                TB_PrecioRines.Enabled = True
                GB_TamañoRines.Enabled = True
            Case 2
                C = 3000
                CM += 1
                TB_PrecioRines.Enabled = True
                GB_TamañoRines.Enabled = True
        End Select
        TB_PrecioRines.Text = C
        TB_ContadorAcero.Text = CA
        TB_ContadorAluminio.Text = CAL
        TB_ContadorMagnesio.Text = CM
    End Sub

    Private Sub TB_NCliente_TextChanged(sender As Object, e As EventArgs) Handles TB_NCliente.TextChanged
        GB_TipoRines.Enabled = True
    End Sub

    Private Sub Bton_Cal_Click(sender As Object, e As EventArgs) Handles Bton_Cal.Click
        'validaciones
        If TB_NCliente.Text = "" Then
            MsgBox("Ingrese el nombre ", vbInformation)
            Me.TB_NCliente.Focus()
        ElseIf CbB_TipoRi.Text = "" Then
            MsgBox("Ingrese el tipo de rines", vbInformation)
            Exit Sub
        ElseIf RBton_Efectivo.Checked = False And RBton_Tarjeta.Checked = False Then
            MsgBox("Seleccione la forma de pago", vbInformation)
            Exit Sub
        ElseIf RBton_R15.Checked = False And RBton_R16.Checked = False And RBton_R17.Checked = False Then
            MsgBox("Seleccione el tamaño", vbInformation)
            Exit Sub
        End If

        'calculo del extra 
        N = Val(TB_PrecioInsta.Text) + Val(TB_PrecioServicio.Text) + Val(TB_PrecioSeguro.Text) + Val(TB_PrecioMante.Text)
        TB_Extras.Text = N

        'calculo forma de pago efectivo
        If RBton_Efectivo.Checked = True Then
            I = Val(TB_Subtotal.Text) * 0.03
        Else
            I = 0
        End If
        TB_Descuento.Text = I

        'Calculo forma de pago Tarjeta 
        If RBton_Tarjeta.Checked = True Then
            F = Val(TB_Subtotal.Text) * 0.02
        Else
            F = 0
        End If
        TB_Recargo.Text = F

        'calculo del subtotal
        G = Val(TB_PrecioRines.Text) + Val(TB_PrecioR15.Text) + Val(TB_PrecioR16.Text) + Val(TB_PrecioR17.Text) + Val(TB_Extras.Text)
        TB_Subtotal.Text = G

        'calculo del isv
        J = (Val(TB_Subtotal.Text) + Val(TB_Recargo.Text)) * 0.15
        TB_ISV.Text = J

        'Calculo del total
        H = Val(TB_Subtotal.Text) + Val(TB_ISV.Text) + Val(TB_Recargo.Text)
        TB_Total.Text = H

        'avilitar botones
        Bton_Agregar.Enabled = True
        Bton_Borrar.Enabled = True
        Bton_Limpio.Enabled = True
        Bton_Nuevo.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        A = 1


        GB_TipoRines.Enabled = False
        GB_TamañoRines.Enabled = False
        GB_Formapago.Enabled = False
        GB_Extra.Enabled = False
        TB_PrecioRines.Enabled = False
        Bton_Agregar.Enabled = False
        Bton_Cal.Enabled = False
        Bton_Borrar.Enabled = False
        Bton_Limpio.Enabled = False
        Bton_Nuevo.Enabled = False
    End Sub

    Private Sub TB_NCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NCliente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo se permite texto", vbInformation)
            e.Handled = True
            TB_NCliente.Focus()

        End If
    End Sub

    Private Sub RBton_R16_CheckedChanged(sender As Object, e As EventArgs) Handles RBton_R16.CheckedChanged
        If RBton_R16.Checked = True Then
            TB_PrecioR16.Text = "1100"
            GB_Extra.Enabled = True

        Else
            RBton_R16.Enabled = False
            TB_PrecioR16.Text = "0"
            GB_Extra.Enabled = False
        End If
    End Sub

    Private Sub RBton_R15_CheckedChanged(sender As Object, e As EventArgs) Handles RBton_R15.CheckedChanged
        If RBton_R15.Checked = True Then
            TB_PrecioR15.Text = "1000"
            GB_Extra.Enabled = True
        Else
            RBton_R15.Enabled = False
            TB_PrecioR15.Text = "0"
            GB_Extra.Enabled = False
        End If
    End Sub

    Private Sub Bton_Limpio_Click(sender As Object, e As EventArgs) Handles Bton_Limpio.Click
        'Limpiar TextBox
        TB_NCliente.Clear()
        TB_PrecioRines.Clear()
        TB_PrecioR15.Clear()
        TB_PrecioR16.Clear()
        TB_PrecioR17.Clear()
        TB_NCliente.Clear()
        TB_DescuenEfectivo.Clear()
        TB_RecargarTarjeta.Clear()
        TB_PrecioInsta.Clear()
        TB_PrecioServicio.Clear()
        TB_PrecioSeguro.Clear()
        TB_PrecioMante.Clear()
        TB_Descuento.Clear()
        TB_Extras.Clear()
        TB_ISV.Clear()
        TB_Subtotal.Text = ""
        TB_Total.Text = ""

        'Limpiar radioButton
        RBton_Efectivo.Checked = False
        RBton_Tarjeta.Checked = False
        RBton_R15.Checked = False
        RBton_R16.Checked = False
        RBton_R17.Checked = False

        'Limpiar Check
        ChBx_Insta.Checked = False
        ChBx_Mantenimiento.Checked = False
        ChBx_Seguro.Checked = False
        ChBx_Servicio.Checked = False

        'Limpiar comboxbom
        CbB_TipoRi.Text = ""

        'que se enfoque en el nombre
        TB_NCliente.Focus()
    End Sub

    Private Sub Bton_Nuevo_Click(sender As Object, e As EventArgs) Handles Bton_Nuevo.Click
        'Nuevo TextBox
        TB_NCliente.Clear()
        TB_PrecioRines.Clear()
        TB_PrecioR15.Clear()
        TB_PrecioR16.Clear()
        TB_PrecioR17.Clear()
        TB_NCliente.Clear()
        TB_DescuenEfectivo.Clear()
        TB_RecargarTarjeta.Clear()
        TB_PrecioInsta.Clear()
        TB_PrecioServicio.Clear()
        TB_PrecioSeguro.Clear()
        TB_PrecioMante.Clear()
        TB_Descuento.Clear()
        TB_Extras.Clear()
        TB_ISV.Clear()
        TB_Subtotal.Text = ""
        TB_Total.Text = ""

        'Nuevo radioButton
        RBton_Efectivo.Checked = False
        RBton_Tarjeta.Checked = False
        RBton_R15.Checked = False
        RBton_R16.Checked = False
        RBton_R17.Checked = False

        'Nuevo Check
        ChBx_Insta.Checked = False
        ChBx_Mantenimiento.Checked = False
        ChBx_Seguro.Checked = False
        ChBx_Servicio.Checked = False

        'Nuevo comboxbom
        CbB_TipoRi.Text = ""

        'que se enfoque en el nombre
        TB_NCliente.Focus()

    End Sub

    Dim K, L, N As String
    Private Sub Bton_Borrar_Click(sender As Object, e As EventArgs) Handles Bton_Borrar.Click
        Dim lista As ListViewItem = New ListViewItem()
        For Each lista In LV_Datos.SelectedItems
            lista.Remove()
        Next


    End Sub

    Private Sub Bton_Salir_Click(sender As Object, e As EventArgs) Handles Bton_Salir.Click
        'Inicio del if 
        If MsgBox("Esta seguro que desea salir ?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Bton_Agregar_Click(sender As Object, e As EventArgs) Handles Bton_Agregar.Click
        Dim lista As ListViewItem = New ListViewItem(TB_NF.Text)
        lista.SubItems.Add(TB_NCliente.Text)
        lista.SubItems.Add(TB_Total.Text)
        LV_Datos.Items.Add(lista)

        A += 1

        TB_NF.Text = A


    End Sub
End Class
