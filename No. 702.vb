'No. 702

x = Text1.Text
y = Text2.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(Text1.Text, " ")
Text2.Text = z(1)
