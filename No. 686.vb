'No. 686

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
n = Val(InputBox("N: "))
For i = 1 To n
s = s & ","
Next
For i = 1 To Len(k)
Text2.Text = Text2.Text & Mid(k, i, 1) & s
Next
