'236
s = 1
For i = 1 To n
If x(i) Mod 2 = 1 Then
s = s * x(i)
p = p + 1
End If
Next
lst.AddItem s
lst.AddItem p
