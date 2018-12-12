'No. 648

Dim x() As Variant
k = Text1.Text
q = 0
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
ReDim x(1 To l)
For i = 1 To l
x(i) = Mid(k, i, 1)
If UCase(x(i)) = "X" Then
pos = i
End If
Next
For i = pos To l
If x(i) = "0" Then
q = q + 1
End If
Next
MsgBox "Qanaky: " & q
