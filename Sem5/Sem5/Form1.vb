Public Class Form1
    'esta función invierte un string
    Function invierte(palabra As String) As String
        Dim inv As String = StrReverse(palabra)
        Return inv
    End Function
    'este boton llama a invertir
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        txtResultado.Text = invierte(TxtPalabra.Text)
    End Sub
    'este boton llama a la pos de un char
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vec() As String = Split(TxtPalabra.Text, ",")
        txtResultado.Text = posicion(vec(0), (vec(1)))
    End Sub
    ' Funcion que  reciba un String y un char, y que devuelva la primera posición en la que se encuentra el Char. Si no está en la hilera retorna -1.
    Function posicion(palabra As String, letra As String) As Integer
        Dim pos As Integer = -1
        Dim index As Integer = 1
        Dim bandera As Boolean = False
        While index <= palabra.Length And bandera = False
            If letra = Mid(palabra, index, 1) Then
                pos = index
                bandera = True
            End If
            index += 1
        End While

        Return pos
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnIguala.Click
        Dim vec() As String = Split(TxtPalabra.Text, ",")
        txtResultado.Text = Iguala(vec(0), (vec(1)))
    End Sub

    Function Iguala(pal1 As String, pal2 As String) As Integer
        Dim res = 0
        If pal1.Length = pal2.Length Then
            Dim index As Integer = 0
            While pal1.Chars(index) = pal2.Chars(index) And index < pal1.Length - 1
                index = index + 1
            End While
            If index = pal1.Length - 1 Then
                res = 1
            End If
        End If
        Return res
    End Function
End Class
