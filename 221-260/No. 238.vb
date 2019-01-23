'238
s = 1
For i = 1 To n
If x(i) Mod 3 = 0 Then
s = s * x(i)
p = p + 1
End If
Next
lst.AddItem s / p
