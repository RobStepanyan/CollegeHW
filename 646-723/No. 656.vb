'No. 656

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
y(i + a) = x(i)
If x(i) = "x" Then
y(i + a + 1) = "y"
y(i + a) = "y"
a = a + 1
End If
Next
For i = 1 To l + a
Text2.Text = Text2.Text & y(i)
Next
