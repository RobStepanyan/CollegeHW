Public Function phi(x, y) As Variant
phi = Log(x ^ 2 + y) / Log(2)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = -3.18
y = 5 + 4 * x
z = phi(x, y) * a ^ 2
Text1.Text = z
End Sub
