'No. 649

Dim x() As Variant
k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
ReDim x(1 To l)
For i = 1 To l
x(i) = Mid(k, i, 1)
If UCase(x(i)) = "Z" Then
If pos1 <> 0 Then
pos2 = i
Else
pos1 = i
End If
End If
Next
MsgBox "Qanaky: " & pos2 - pos1 - 1
