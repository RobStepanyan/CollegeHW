'No. 699

x = Text1.Text
y = Text2.Text
If x = "" Or y = "" Then
MsgBox "Datark e"
Exit Sub
End If
Text1.Text = Replace(Text1.Text, "X", Text2.Text)
