Public Function phi(x, y) As Variant
phi = Log(x ^ 2 + 4 * y) / Log(4)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = 2.6
y = 5 ^ x
z = Exp(phi(x, y)) + Sqr(a ^ 4 + 4 * x ^ 2)
Text1.Text = z
End Sub
