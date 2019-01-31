Public Function phi(x, y) As Variant
phi = 1 / Tan(x ^ 2 * y)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = 2.24
y = 2
z = (a + y) ^ 2 * phi(x, y) ^ 2
Text1.Text = z
End Sub
