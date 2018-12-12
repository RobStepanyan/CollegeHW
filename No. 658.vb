'No. 658

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
Text2.Text = ""
For i = 1 To l Step 2
Text2.Text = Text2.Text & Mid(k, i + 1, 1) & Mid(k, i, 1)
Next
