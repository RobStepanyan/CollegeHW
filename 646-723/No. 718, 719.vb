'No. 718

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
k = Split(x, ".")
ext = k(UBound(k))
d = Split(x, "\")
nm = Left(d(UBound(d)), Len(d(UBound(d))) - Len(ext) - 1)
MsgBox "Name: " & nm & " | Extension: " & ext
