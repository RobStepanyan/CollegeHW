'No. 710

Dim k() As String
x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(Text1.Text, " ")
ReDim k(1 To UBound(z) + 1)
For i = 0 To UBound(z)
If z(i) <> "" Then
Text2.Text = Text2.Text & z(i) & "."
End If
Next
