Public Function min(x, y) As Variant
If x < y And x < x + y Then
min = x
Else
If y < x And y < x + y Then
min = y
Else
min = x + y
End If
End If
min = Tan(min)
If 2 < x And 2 < x - y Then
min = min - 2
Else
If x < 2 And x < x - y Then
min = min - x
Else
min = min - x - y
End If
End If
End Function

Private Sub Command1_Click()
x = Val(InputBox("X: "))
y = Val(InputBox("Y: "))
Text1.Text = min(x, y)
End Sub
