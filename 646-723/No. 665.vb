'No. 665

k = Text1.Text
k2 = Text2.Text
If k = "" Or k2 = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
Text3.Text = ""
kes = l \ 2
For i = 1 To l + Len(k2)
If i <= kes Then
Text3.Text = Text3.Text & Mid(k, i, 1)
Else
If i <= kes + Len(k2) Then
Text3.Text = Text3.Text & Mid(k2, i - kes, 1)
Else
Text3.Text = Text3.Text & Mid(k, i - Len(k2), 1)
End If
End If
Next
