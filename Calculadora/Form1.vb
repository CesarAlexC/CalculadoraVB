
Public Class Calculadora
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NuevaSuma.Click
        NumeroUno.Clear()
        NumeroDos.Clear()
        Resultado.Clear()
        Cuadrado.Clear()
        ReultadoCuadrado.Clear()
    End Sub
    Public Sub Sumar_Click(sender As Object, e As EventArgs) Handles Sumar.Click
        Dim numero1, numero2, res As Integer
        numero1 = Val(NumeroUno.Text)
        numero2 = Val(NumeroDos.Text)
        res = Val(Resultado.Text)

        res = Val(numero1) + Val(numero2)
        Resultado.Text = res

    End Sub
    Private Sub Restar_Click(sender As Object, e As EventArgs) Handles Restar.Click
        Dim numero1, numero2, res As Integer
        numero1 = Val(NumeroUno.Text)
        numero2 = Val(NumeroDos.Text)
        res = Val(Resultado.Text)

        res = Val(numero1) - Val(numero2)
        Resultado.Text = res
    End Sub

    Private Sub Multiplicar_Click(sender As Object, e As EventArgs) Handles Multiplicar.Click
        Dim numero1, numero2, res As Integer
        numero1 = Val(NumeroUno.Text)
        numero2 = Val(NumeroDos.Text)
        res = Val(Resultado.Text)

        res = Val(numero1) * Val(numero2)
        Resultado.Text = res
    End Sub

    Private Sub Dividir_Click(sender As Object, e As EventArgs) Handles Dividir.Click
        Dim numero1, numero2, res As Double
        numero1 = Val(NumeroUno.Text)
        numero2 = Val(NumeroDos.Text)
        res = Val(Resultado.Text)

        res = Val(numero1) / Val(numero2)
        Resultado.Text = res
    End Sub
    Private Sub ElevarCuadrado_Click(sender As Object, e As EventArgs) Handles ElevarCuadrado.Click
        Dim elevacuadrado, res As Integer

        elevacuadrado = Val(Cuadrado.Text)

        res = Val(elevacuadrado) ^ 2

        ReultadoCuadrado.Text = res


    End Sub


End Class
