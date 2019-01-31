Public Function max(a, b, c) As Integer
If 5 + a > b And 5 + a > 3 Then
max = 5 + a
Else
If b > 5 + a And b > 3 Then
max = b
Else
max = 3
End If
End If
max = max ^ 2
If 3 + a > b And 3 + a > c Then
max = max * (3 + a)
Else
If b > 3 + a And b > c Then
max = max * b
Else
max = max * c
End If
End If
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
Text1.Text = max(a, b, c)
End Sub
