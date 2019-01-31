Public Function max(a, b) As Integer
If a > a + b And a > a - b Then
max = max + a
Else
If a + b > a And a + b > a - b Then
max = max + a
Else
max = max + (a - b)
End If
End If
If b > 2 * b - a And b > b + 2 * a Then
max = max + b
Else
If 2 * b - a > b And 2 * b - a > b + 2 * a Then
max = max + 2 * b - a
Else
max = max + b + 2 * a
End If
End If
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
Text1.Text = max(a, b)
End Sub
