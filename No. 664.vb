'No. 664

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
n = InputBox("N: ")
Text2.Text = ""
q = 0
x = False
For i = 1 To l
If UCase(Mid(k, i, 1)) > n Then
x = True
Exit For
End If
Next
If x = True Then
For i = 1 To l
If UCase(Mid(k, i, 1)) = "C" Then
q = q + 1
End If
Next
Else
For i = 1 To l
If UCase(Mid(k, i, 1)) = "D" Then
q = q + 1
End If
Next
End If
MsgBox "Qanaky: " & q
