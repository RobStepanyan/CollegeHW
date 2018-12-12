'No. 650

Dim x() As Variant
k1 = Text1.Text
k2 = Text2.Text
If k1 = "" Or k2 = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k1)
ReDim x(1 To l)
q = 0
For i = 1 To l
x(i) = Mid(k1, i, 1)
For j = 1 To Len(k2)
If x(i) = Mid(k2, j, 1) Then
q = q + 1
Exit For
End If
Next
Next
MsgBox "Qanaky: " & q
