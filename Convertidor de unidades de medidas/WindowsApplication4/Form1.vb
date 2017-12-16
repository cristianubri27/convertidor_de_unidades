Public Class Form1
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    // cristian ubri mañon  15-EISM-1-024 //
    Private Sub cmdConvertir_Click(sender As Object, e As EventArgs) Handles cmdConvertir.Click
        Dim N1 As Double
        Dim U As String

        U = ""
        If ComboBox1.Text = "Milimetros" And ComboBox2.Text = "Milimetros" Then
            N1 = Val(txtBox1.Text)
            U = "mm"
        ElseIf ComboBox1.Text = "Milimetros" And ComboBox2.Text = "Centimetros" Then
            N1 = Val(txtBox1.Text) / 10
            U = "cm"
        ElseIf ComboBox1.Text = "Milimetros" And ComboBox2.Text = "Metros" Then
            N1 = Val(txtBox1.Text) / 1000
            U = "m"
        ElseIf ComboBox1.Text = "Milimetros" And ComboBox2.Text = "Kilometros" Then
            N1 = Val(txtBox1.Text) / 1000000
            U = "km"
        ElseIf ComboBox1.Text = "Centimetros" And ComboBox2.Text = "Milimetros" Then
            N1 = Val(txtBox1.Text) * 10
            U = "mm"
        ElseIf ComboBox1.Text = "Centimetros" And ComboBox2.Text = "Centimetros" Then
            N1 = Val(txtBox1.Text)
            U = "cm"
        ElseIf ComboBox1.Text = "Centimetros" And ComboBox2.Text = "Metros" Then
            N1 = Val(txtBox1.Text) / 100
            U = "m"
        ElseIf ComboBox1.Text = "Centimetros" And ComboBox2.Text = "Kilometros" Then
            N1 = Val(txtBox1.Text) / 100000
            U = "km"
        ElseIf ComboBox1.Text = "Metros" And ComboBox2.Text = "Milimetros" Then
            N1 = Val(txtBox1.Text) * 1000
            U = "mm"
        ElseIf ComboBox1.Text = "Metros" And ComboBox2.Text = "Centimetros" Then
            N1 = Val(txtBox1.Text) * 100
            U = "cm"
        ElseIf ComboBox1.Text = "Metros" And ComboBox2.Text = "Metros" Then
            N1 = Val(txtBox1.Text)
            U = "m"
        ElseIf ComboBox1.Text = "Metros" And ComboBox2.Text = "Kilometros" Then
            N1 = Val(txtBox1.Text) / 1000
            U = "km"
        ElseIf ComboBox1.Text = "Kilometros" And ComboBox2.Text = "Milimetros" Then
            N1 = Val(txtBox1.Text) * 1000000
            U = "mm"
        ElseIf ComboBox1.Text = "Kilometros" And ComboBox2.Text = "Centimetros" Then
            N1 = Val(txtBox1.Text) * 100000
            U = "cm"
        ElseIf ComboBox1.Text = "Kilometros" And ComboBox2.Text = "Metros" Then
            N1 = Val(txtBox1.Text) * 1000
            U = "m"
        ElseIf ComboBox1.Text = "Pies" And ComboBox2.Text = "Pulgadas" Then
            N1 = Val(txtBox1.Text) * 12
            U = "Pul"
        ElseIf ComboBox1.Text = "Pulgadas" And ComboBox2.Text = "Pies" Then
            N1 = Val(txtBox1.Text) / 12
            U = "Pies"

        End If
        txtResultado.Text = N1 & U
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Dim M As String

        M = MsgBox("Seguro que desea salir?", vbYesNo, "Salir")

        If M = vbYes Then
            End
        Else

        End If


    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        txtBox1.Text = ""
        txtResultado.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

   

    Private Sub txtBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox1.TextChanged

    End Sub

    Private Sub Cambiodeunidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
