'161
For i = 1000 To 9999
If Sqr(i * 26) = Int(Sqr(i * 26)) Then
lst.AddItem i
Exit For
End If
Next
