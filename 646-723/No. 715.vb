'No. 715

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(x, " ")
For i = 0 To UBound(z)
If z(i) <> "" Then
p = p & StrConv(z(i), vbProperCase) & " "
End If
Next
Text1.Text = p
