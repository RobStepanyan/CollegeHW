'No. 707

Dim k() As String
x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(Text1.Text, " ")
ReDim k(1 To UBound(z) + 1)
For i = 0 To UBound(z)
If z(i) <> "" Then
j = j + 1
k(j) = z(i)
q = q + 1
List2.AddItem k(j)
End If
Next
For i = 1 To q
f = Split(k(i), "B")
If UBound(f) = 3 Then
s = s + 1
End If
Next
MsgBox "Qanaky: " & s
