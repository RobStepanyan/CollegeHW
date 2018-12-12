'No. 682

k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
MsgBox Asc(Left(k, 1)) & " " & Asc(Right(k, 1))
