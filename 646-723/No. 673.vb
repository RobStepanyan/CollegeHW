'No. 673

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
If UCase(Right(k, 3)) = "YAN" Then
t = True
Else
t = False
End If
MsgBox "T: " & t
