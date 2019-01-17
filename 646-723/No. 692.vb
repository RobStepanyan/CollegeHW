'No. 692

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
For i = 1 To Len(k)
v = Mid(k, i, 1)
If Asc(v) >= 48 And Asc(v) <= 57 Then
Text2.Text = v & Text2.Text
End If
Next
