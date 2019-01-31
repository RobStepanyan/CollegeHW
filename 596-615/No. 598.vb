Public Function max(a, b) As Integer
If 5 > a And 5 > b Then
max = 5
Else
If a > 5 And a > b Then
max = a
Else
max = b
End If
End If
If 7 > b And 7 > a + b Then
max = max + 7
Else
If b > 7 And b > a + b Then
max = max + b
Else
max = max + a + b
End If
End If
End Function

Private Sub Command1_Click()
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
Text1.Text = max(a, b)
End Sub
