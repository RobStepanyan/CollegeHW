'No. 668

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
p = 1
l = Len(k)
For i = 1 To l
j = j + 1
If j = 3 Then
j = 0
Else
Text2.Text = Text2.Text & Mid(k, i, 1)
End If
Next
