'No. 654

Dim x() As Variant
Dim y() As Variant
k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
ReDim x(1 To l)
ReDim y(1 To l * 2)
q = 0
Text2.Text = ""
For i = 1 To l
x(i) = Mid(k, i, 1)
If x(i) = "a" Then
a = a + 1
End If
If x(i) <> "a" Then
y(i) = x(i)
End If
Next
For i = 1 To l + a
Text2.Text = Text2.Text & y(i)
Next
