'235
For i = 1 To n
If x(i) Mod 2 = 1 Then
s = s + x(i) ^ 2
p = p + 1
End If
Next
lst.AddItem sqr(s / q)
