<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Suma = New Label()
        Sumar = New Button()
        Restar = New Button()
        Multiplicar = New Button()
        Dividir = New Button()
        ElevarCuadrado = New Button()
        NumeroUno = New TextBox()
        NumeroDos = New TextBox()
        Resultado = New TextBox()
        NuevaSuma = New Button()
        Cuadrado = New TextBox()
        Label1 = New Label()
        ReultadoCuadrado = New TextBox()
        SuspendLayout()
        ' 
        ' Suma
        ' 
        Suma.AutoSize = True
        Suma.Location = New Point(119, 18)
        Suma.Name = "Suma"
        Suma.Size = New Size(238, 20)
        Suma.TabIndex = 0
        Suma.Text = "Operaciones Basicas de 2 numeros"
        ' 
        ' Sumar
        ' 
        Sumar.Location = New Point(43, 62)
        Sumar.Name = "Sumar"
        Sumar.Size = New Size(95, 44)
        Sumar.TabIndex = 1
        Sumar.Text = "Sumar"
        Sumar.UseVisualStyleBackColor = True
        ' 
        ' Restar
        ' 
        Restar.Location = New Point(43, 121)
        Restar.Name = "Restar"
        Restar.Size = New Size(95, 44)
        Restar.TabIndex = 2
        Restar.Text = "Restar"
        Restar.UseVisualStyleBackColor = True
        ' 
        ' Multiplicar
        ' 
        Multiplicar.Location = New Point(43, 171)
        Multiplicar.Name = "Multiplicar"
        Multiplicar.Size = New Size(95, 44)
        Multiplicar.TabIndex = 3
        Multiplicar.Text = "Multiplicar"
        Multiplicar.UseVisualStyleBackColor = True
        ' 
        ' Dividir
        ' 
        Dividir.Location = New Point(43, 221)
        Dividir.Name = "Dividir"
        Dividir.Size = New Size(95, 44)
        Dividir.TabIndex = 4
        Dividir.Text = "Dividir"
        Dividir.UseVisualStyleBackColor = True
        ' 
        ' ElevarCuadrado
        ' 
        ElevarCuadrado.Location = New Point(562, 129)
        ElevarCuadrado.Name = "ElevarCuadrado"
        ElevarCuadrado.Size = New Size(151, 44)
        ElevarCuadrado.TabIndex = 5
        ElevarCuadrado.Text = "Elevar al cuadrado"
        ElevarCuadrado.UseVisualStyleBackColor = True
        ' 
        ' NumeroUno
        ' 
        NumeroUno.Location = New Point(168, 79)
        NumeroUno.Name = "NumeroUno"
        NumeroUno.Size = New Size(152, 27)
        NumeroUno.TabIndex = 7
        ' 
        ' NumeroDos
        ' 
        NumeroDos.Location = New Point(168, 138)
        NumeroDos.Name = "NumeroDos"
        NumeroDos.Size = New Size(152, 27)
        NumeroDos.TabIndex = 8
        ' 
        ' Resultado
        ' 
        Resultado.Location = New Point(174, 221)
        Resultado.Name = "Resultado"
        Resultado.Size = New Size(110, 27)
        Resultado.TabIndex = 9
        ' 
        ' NuevaSuma
        ' 
        NuevaSuma.Location = New Point(363, 138)
        NuevaSuma.Name = "NuevaSuma"
        NuevaSuma.Size = New Size(151, 44)
        NuevaSuma.TabIndex = 10
        NuevaSuma.Text = "Nueva Operacion"
        NuevaSuma.UseVisualStyleBackColor = True
        ' 
        ' Cuadrado
        ' 
        Cuadrado.Location = New Point(561, 79)
        Cuadrado.Name = "Cuadrado"
        Cuadrado.Size = New Size(152, 27)
        Cuadrado.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(513, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 20)
        Label1.TabIndex = 12
        Label1.Text = "Elevador un Numero al Cuadrado"
        ' 
        ' ReultadoCuadrado
        ' 
        ReultadoCuadrado.Location = New Point(587, 221)
        ReultadoCuadrado.Name = "ReultadoCuadrado"
        ReultadoCuadrado.Size = New Size(110, 27)
        ReultadoCuadrado.TabIndex = 13
        ' 
        ' Calculadora
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ReultadoCuadrado)
        Controls.Add(Label1)
        Controls.Add(Cuadrado)
        Controls.Add(NuevaSuma)
        Controls.Add(Resultado)
        Controls.Add(NumeroDos)
        Controls.Add(NumeroUno)
        Controls.Add(ElevarCuadrado)
        Controls.Add(Dividir)
        Controls.Add(Multiplicar)
        Controls.Add(Restar)
        Controls.Add(Sumar)
        Controls.Add(Suma)
        Name = "Calculadora"
        Text = "Calculadora"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Suma As Label
    Friend WithEvents Sumar As Button
    Friend WithEvents Restar As Button
    Friend WithEvents Multiplicar As Button
    Friend WithEvents Dividir As Button
    Friend WithEvents ElevarCuadrado As Button
    Friend WithEvents NumeroUno As TextBox
    Friend WithEvents NumeroDos As TextBox
    Friend WithEvents Resultado As TextBox
    Friend WithEvents NuevaSuma As Button
    Friend WithEvents Cuadrado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReultadoCuadrado As TextBox
End Class
