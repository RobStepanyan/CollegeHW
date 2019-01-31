Public Function phi(x, y) As Variant
phi = Sin(x * y)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = 1
y = 3 * x
z = Exp(phi(x, y)) + Sqr(x ^ 4 + 4 * a ^ 2)
Text1.Text = z
End Sub
