'163
For i = 9999 To 1000 Step -1
If Sqr(i * 18) = Int(Sqr(i * 18)) Then
lst.AddItem i
Exit For
End If
Next
