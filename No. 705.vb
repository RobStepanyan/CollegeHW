'No. 705

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
s = 0
For i = 1 To q
For j = i To q
If i <> j Then
If UCase(Left(k(i), 1)) = UCase(Left(k(j), 1)) Then
List1.AddItem k(i) & " - " & k(j)
s = s + 1
End If
End If
Next
Next
MsgBox "Qanaky: " & s
