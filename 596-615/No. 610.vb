Dim a As Integer

Public Function phi(x, y) As Variant
phi = Sin(x + a * y)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = -2.3
y = x ^ 3
z = a ^ (1 / 3) * Cos(x) ^ 2 * (phi(x, y) ^ 2 + 1)
Text1.Text = z
End Sub
