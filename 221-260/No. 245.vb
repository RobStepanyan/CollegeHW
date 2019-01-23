'245
For i = 1 To n
If (x(i) + i) Mod 3 = 0 Then
p = p + x(i) ^ 2
End If
Next
lst.AddItem p
