'239
s = 1
For i = 1 To n
If x(i) Mod 5 = 0 Then
s = s * x(i) ^ 2
p = p + 1
End If
Next
lst.AddItem Sqr(s / p)
