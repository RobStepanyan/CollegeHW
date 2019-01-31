Public Function phi(x, y) As Variant
phi = Log(a ^ 2 + y) / Log(3)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = 2.1
y = 2 * x
z = phi(x, y) * (a ^ 2 + y) ^ (1 / 3)
Text1.Text = z
End Sub
