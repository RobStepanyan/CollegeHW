Public Function phi(x, y) As Variant
phi = Log(x ^ 3 + y)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = 4.6
y = 2 * x
z = (phi(x, y) + 1) ^ (1 / 3) * Sqr(x ^ 2 + y)
Text1.Text = z
End Sub
