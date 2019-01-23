'224
k = Val(InputBox("K: "))
For i = 1 To n
If Abs(x(i)) < k Then
s = s + x(i) ^ 3
End If
Next
lst.AddItem s
