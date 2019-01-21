'164
n = Val(InputBox("N: "))
For i = 100 To 999
If Sqr(i) > n Then
lst.AddItem i
Exit For
End If
Next
