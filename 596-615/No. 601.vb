Public Function max(a, b, c) As Variant
If 3 > a + b And 3 > c Then
max = 3
Else
If a + b > 3 And a + b > c Then
max = a + b
Else
max = c
End If
End If
If a + b > b + c And a + b > a + c Then
max = max - (a + b)
Else
If b + c > a + b And b + c > a + c Then
max = max - (b + c)
Else
max = max - (a + c)
End If
End If
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
Text1.Text = max(a, b, c)
End Sub
