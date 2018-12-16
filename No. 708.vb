'No. 708

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
Min = Len(k(1))
Minb = k(1)
For i = 2 To q
If Len(k(i)) < Min Then
Min = Len(k(i))
Minb = k(i)
End If
Next
MsgBox "Shortest: " & Minb
