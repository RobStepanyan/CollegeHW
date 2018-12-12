'No. 690

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
Text2.Text = ""
For i = 1 To Len(k)
s = Mid(k, i, 1)
If Asc(s) >= 65 And Asc(s) <= 89 Then
Text2.Text = Text2.Text & StrConv(s, vbLowerCase)
Else
If Asc(s) >= 97 And Asc(s) <= 122 Then
Text2.Text = Text2.Text & StrConv(s, vbUpperCase)
End If
End If
Next
