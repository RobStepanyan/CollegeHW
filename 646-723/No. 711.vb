'No. 711

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(x, " ")
For i = 0 To UBound(z)
If z(i) <> "" Then
p = p & Mid(z(i), 1, 1)
For j = 2 To Len(z(i))
If Mid(z(i), 1, 1) = Mid(z(i), j, 1) Then
p = p & "."
Else
p = p & Mid(z(i), j, 1)
End If
Next
End If
p = p & " "
Next
Text1.Text = p
