'No. 662

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
n = InputBox("N: ")
l = Len(k)
Text2.Text = ""
For i = 1 To l
c = Mid(k, i, 1)
If c > n Then
Text2.Text = Text2.Text & c
End If
Next
For i = 1 To l
c = Mid(k, i, 1)
If c = n Then
Text2.Text = Text2.Text & c
End If
Next
For i = 1 To l
c = Mid(k, i, 1)
If c < n Then
Text2.Text = Text2.Text & c
End If
Next
