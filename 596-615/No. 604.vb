Public Function min(x, y, z) As Variant
If x < x + 1 And x < x + y + z Then
min = x
Else
If x + 1 < x And x + 1 < x + y + z Then
min = x + 1
Else
min = x + y + z
End If
End If
min = Sin(min)
If 5 < b + c And 5 < a Then
min = min + Cos(5)
Else
If b + c < 5 And b + c < a Then
min = min - Cos(b + c)
Else
min = min - Cos(a)
End If
End If
End Function

Private Sub Command1_Click()
x = Val(InputBox("X: "))
y = Val(InputBox("Y: "))
z = Val(InputBox("Z: "))
Text1.Text = min(x, y, z)
End Sub
