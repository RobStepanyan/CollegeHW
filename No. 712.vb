'No. 712

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(x, " ")
For i = 0 To UBound(z)
If z(i) <> "" Then
For j = 1 To Len(z(i)) - 1
If Mid(z(i), Len(z(i)), 1) = Mid(z(i), j, 1) Then
p = p & "."
Else
p = p & Mid(z(i), j, 1)
End If
Next
p = p & Mid(z(i), Len(z(i)), 1)
End If
p = p & " "
Next
Text1.Text = p
