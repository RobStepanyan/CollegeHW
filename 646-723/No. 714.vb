'No. 714

Dim k() As String
x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
z = Split(x, " ")
ReDim k(1 To UBound(z) + 1)
For i = 0 To UBound(z)
If z(i) <> "" Then
j = j + 1
k(j) = z(i)
q = q + 1
End If
Next

For i = 1 To q
For j = i To q
If k(i) > k(j) Then
h = k(j)
k(j) = k(i)
k(i) = h
End If
Next
Next
For i = 1 To q
Text2.Text = Text2.Text & k(i) & ", "
Next
Text2.Text = Left(Text2.Text, Len(Text2.Text) - 2)
