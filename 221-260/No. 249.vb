'249
k = Val(InputBox("K: "))
For i = 1 To n
If Abs(x(i) - i) > k Then
p = p + 1
End If
Next
lst.AddItem p
