'No. 723

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
m = ""
For i = 1 To Len(x)
If Asc(Mid(x, i, 1)) >= 65 Then
Min = Mid(x, i, 1)
For j = i + 1 To Len(x)
If Asc(Mid(x, j, 1)) >= 65 Then
If Min > Mid(x, j, 1) Then
m = Min
Exit For
Exit For
End If
End If
Next
End If
Next
If m <> "" Then
MsgBox m
Else
MsgBox 1
End If
