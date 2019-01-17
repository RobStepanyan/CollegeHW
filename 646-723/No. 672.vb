'No. 672

k = Text1.Text
k2 = Text2.Text
If k = "" Or k2 = "" Then
MsgBox "Datark e"
Exit Sub
End If
For i = 1 To Len(k)
If Mid(k, i, 1) = "x" Then
pos = i
End If
Next
Text3.Text = Left(k, pos - 1) & k2 & Right(k, Len(k) - pos)
