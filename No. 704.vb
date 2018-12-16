'No. 704

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(Text1.Text, " ")
For i = 0 To UBound(z)
If z(i) <> "" Then
q = q + 1
End If
Next
MsgBox "Qanaky: " & q
