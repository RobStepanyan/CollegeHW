'No. 670

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
q = 0
For i = 2 To l - 1
f = Mid(k, i - 1, 1)
s = Mid(k, i, 1)
t = Mid(k, i + 1, 1)
If s > f And s > t Then
q = q + 1
End If
Next
msgbox "Qanaky: " & q
