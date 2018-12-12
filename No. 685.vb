'No. 685

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
For i = 1 To Len(k)
Text2.Text = Text2.Text & Mid(k, i, 1) & " "
Next
