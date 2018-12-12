'No. 661

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
Text2.Text = ""
pos = l
For i = 1 To l
If Mid(k, i, 1) = "v" Then
pos = i
Exit For
End If
Next
For i = 1 To pos
Text2.Text = Text2.Text & Mid(k, i, 1)
Next
