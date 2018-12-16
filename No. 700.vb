'No. 700

x = Text1.Text
y = Text2.Text
If x = "" Or y = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(Text1.Text, Text2.Text)
MsgBox UBound(z)
