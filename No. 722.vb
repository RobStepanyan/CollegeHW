'No. 722

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
j = Len(x) \ 2 + 1
For i = 1 To Len(x) \ 2
Text2.Text = Mid(x, j, 1) & Mid(x, i, 1) & Text2.Text
j = j + 1
Next
If j <> Len(x) + 1 Then
Text2.Text = Text2.Text & Mid(x, Len(x), 1)
End If 
