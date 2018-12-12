'No. 657

Dim y() As Variant
k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
ReDim y(1 To l \ 2 + 1)
Text2.Text = ""
For i = 1 To l Step 2
j = j + 1
If Mid(k, i, 1) > Mid(k, i + 1, 1) Then
y(j) = Mid(k, i, 1)
Else
y(j) = Mid(k, i + 1, 1)
End If
Text2.Text = Text2.Text & y(j)
Next
