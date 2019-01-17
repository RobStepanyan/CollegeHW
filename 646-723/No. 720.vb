'No. 720

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
d = Split(x, "\")
If UBound(d) < 2 Then
MsgBox d(0) & "\" & d(1)
Else
MsgBox d(UBound(d))
End If
