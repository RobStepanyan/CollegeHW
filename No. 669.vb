'No. 669

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
q = 0
If k = StrReverse(k) Then
For i = 1 To l
If Mid(k, i, 1) = "a" Then
q = q + 1
End If
Next
Else
For i = 1 To l
If Mid(k, i, 1) = "b" Then
q = q + 1
End If
Next
End If
MsgBox "Qanaky: " & q
