'225
t = Val(InputBox("T: "))
s = 1
For i = 1 To n
If Abs(x(i)) < k Then
s = s * x(i)
End If
Next
lst.AddItem s
