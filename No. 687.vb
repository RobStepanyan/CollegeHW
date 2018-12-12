'No. 687

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
q = 0
For i = 1 To Len(k)
If Asc(Mid(k, i, 1)) >= 48 And Asc(Mid(k, i, 1)) <= 57 Then
q = q + 1
End If
Next
MsgBox "Qanaky: " & q
