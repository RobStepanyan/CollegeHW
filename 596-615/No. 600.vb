Public Function min(a, b, c) As Variant
If 3.4 + 5 * a > b And 3.4 + 5 * a > c Then
min = 3.4 + 5 * a
Else
If b > 3.4 + 5 * a And b > c Then
min = b
Else
min = c
End If
End If
If 0.5 > a And 0.5 > c Then
min = min + 0.5
Else
If a > 0.5 And a > c Then
min = min + a
Else
min = min + c
End If
End If
min = min ^ 2
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
Text1.Text = min(a, b, c)
End Sub
