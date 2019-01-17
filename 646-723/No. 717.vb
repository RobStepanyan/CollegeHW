'No. 717

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(x, " ")
Text1.Text = ""
For i = 0 To UBound(z)
If z(i) <> "" Then
Text1.Text = Text1.Text & z(i) & " "
End If
Next
