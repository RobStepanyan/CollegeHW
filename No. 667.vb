'No. 667

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
p = 1
l = Len(k)
For i = 1 To l
If Mid(k, i, 1) = "z" Then
s = s + i
p = p * i
End If
Next
If s <> 0 Then
MsgBox "Quanity: " & q & " Product: " & p
Else
MsgBox 0
end if
