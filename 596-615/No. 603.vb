Public Function max(x, y, z) As Variant
If x > x + 1 And x > x + y + z Then
max = x
Else
If x + 1 > x And x + 1 > x + y + z Then
max = x + 1
Else
max = x + y + z
End If
End If
If x > z And x > y - 1 Then
max = max - x
Else
If z > x And z > y - 1 Then
max = max - z
Else
max = max - y - 1
End If
End If
max = max ^ 2
End Function

Private Sub Command1_Click()
x = Val(InputBox("X: "))
y = Val(InputBox("Y: "))
z = Val(InputBox("Z: "))
Text1.Text = max(x, y, z)
End Sub
