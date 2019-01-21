'162
For i = 9999 To 1000 Step -1
If Sqr(i * 14) = Int(Sqr(i * 14)) Then
lst.AddItem i
Exit For
End If
Next
