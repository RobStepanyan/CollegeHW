Public Function phi(x, y) As Variant
phi = Tan(x * y)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
x = 0.7
y = x ^ 2
z = Atn(a + phi(x, y) ^ 2)
Text1.Text = z
End Sub
