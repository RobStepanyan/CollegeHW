'127
s = 1
For i = 1 To 17
If i Mod 2 = 1 Then
x = Sin(i) ^ 2
y = Tan(i)
Else
x = 0
y = 1 / Tan(i)
End If
s = s * x ^ 2 * y
Next
lst.AddItem s
