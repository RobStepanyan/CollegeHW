'No. 703

x = Text1.Text
y = Text2.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(Text1.Text, " ")
For i = 1 To UBound(z) - 1
Text2.Text = Text2.Text & z(i) & " "
Next
