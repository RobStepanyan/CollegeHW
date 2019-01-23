'244
p = 1
For i = 1 To n
If x(i) Mod 5 = 2 Then
p = p * x(i)
End If
Next
lst.AddItem p
