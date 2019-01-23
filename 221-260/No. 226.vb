'226
k = Val(InputBox("K: "))
For i = 1 To n
If Abs(x(i)) < k Then
s = s + 1
End If
Next
lst.AddItem s
