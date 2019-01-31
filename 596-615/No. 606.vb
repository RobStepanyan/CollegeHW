Public Function phi(x, y) As Variant
phi = Log(x + y) / Log(2)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = 2
y = Sqr(5)
z = a * Sqr(x ^ 2 + y ^ 2) * phi(x, y) ^ 2
Text1.Text = z
End Sub
