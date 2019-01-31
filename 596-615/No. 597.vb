Public Function min(a, b, c) As Integer
If 3 * a < 2 * b And 3 * a < c Then
min = 3 * a
Else
If 2 * b < 3 * a And 2 * b < c Then
min = 2 * b
Else
min = c
End If
End If
If a < b And a < 3 * c Then
min = min * a
Else
If b < a And b < 3 * c Then
min = min * b
Else
min = min * 3 * c
End If
End If
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
Text1.Text = min(a, b, c)
End Sub
