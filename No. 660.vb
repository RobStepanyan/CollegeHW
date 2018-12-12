'No. 660

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
Text2.Text = ""
For i = 1 To l
j = j + 1
If j = 3 Then
Text2.Text = Text2.Text & "a"
j = 0
Else
Text2.Text = Text2.Text & Mid(k, i, 1)
End If
Next
