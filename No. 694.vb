'No. 694

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
f = Val(Mid(k, 1, 1))
For i = 2 To Len(k) - 1 Step 2
s = Mid(k, i, 1)
t = Val(Mid(k, i + 1, 1))
If s = "+" Then
g = f + t
Else
If s = "-" Then
g = f - t
End If
End If
f = g
Next
Text2.Text = g
