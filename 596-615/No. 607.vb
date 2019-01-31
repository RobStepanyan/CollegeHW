Public Function phi(x, y) As Variant
phi = Tan(x ^ 2 + y)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = 0.28
y = 7
z = a * Sin(x) ^ 2 * Sqr(phi(x, y) + 1)
Text1.Text = z
End Sub
