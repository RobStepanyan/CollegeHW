'No. 663

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
For i = 1 To l
c = Mid(k, i, 1)
If c = "c" Then
q = q + 1
s = s + i
End If
Next
If q <> 0 Then
MsgBox "Mean: " & s / q
Else
MsgBox "Mean: 0"
End If
