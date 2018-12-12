'No. 681

x = InputBox("X:")
If Asc(x) >= 48 And Asc(x) <= 57 Then
p = 1
Else
If Asc(x) >= 65 And Asc(x) <= 90 Then
p = 2
Else
If Asc(x) >= 97 And Asc(x) <= 122 Then
p = 3
Else
p = 4
End If
End If
End If
MsgBox p
