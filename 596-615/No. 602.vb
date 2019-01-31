Public Function min(a, b, c) As Variant
If 2 < a + b And 2 < b + c Then
min = 2
Else
If a + b < 2 And a + b < b + c Then
min = a + b
Else
min = b + c
End If
End If
If a < b And a < c Then
min = min + a
Else
If b < a And b < c Then
min = min + b
Else
min = min + c
End If
End If
min = Exp(min)
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
Text1.Text = min(a, b, c)
End Sub
