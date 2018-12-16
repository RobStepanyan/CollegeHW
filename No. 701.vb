'No. 701

x = Text1.Text
y = Text2.Text
If x = "" Or y = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(Text1.Text, Text2.Text)
For i = 0 To UBound(z) - 1
s = s + Len(z(i))
Next
MsgBox "Position: " & s
