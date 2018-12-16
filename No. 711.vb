'No. 711

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(x, " ")
For i = 0 To UBound(z)
If z(i) <> "" Then
Text2.Text = Text2.Text & Mid(z(i), 1, 1)
For j = 2 To Len(z(i))
If Mid(z(i), 1, 1) = Mid(z(i), j, 1) Then
Text2.Text = Text2.Text & "."
Else
Text2.Text = Text2.Text & Mid(z(i), j, 1)
End If
Next
End If
Text2.Text = Text2.Text & " "
Next
