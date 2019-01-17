'128
s = 1
For i = 1 To 14
If i Mod 2 = 0 Then
x = Exp(3 * i - 4)
Else
x = i ^ 2 - i
End If
y = (i - 1) ^ 2
s = s * x * y ^ 2
Next
lst.AddItem s
