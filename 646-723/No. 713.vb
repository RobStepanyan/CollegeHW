'No. 713

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(x, " ")
For i = 0 To UBound(z)
If z(i) <> "" Then
Text2.Text = Text2.Text & StrReverse(z(i)) & ", "
End If
Next
Text2.Text = Left(Text2.Text, Len(Text2.Text) - 2)
