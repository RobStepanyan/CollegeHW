'233
p = 1
For i = 1 To n
If x(i) Mod 2 = 0 Then
s = s + x(i)
p = p * x(i)
End If
Next
lst.AddItem s
lst.AddItem p
