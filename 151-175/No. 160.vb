'160
For i = 100 To 999
If Sqr(i * 16) = Int(Sqr(i * 16)) Then
lst.AddItem i
Exit For
End If
Next
