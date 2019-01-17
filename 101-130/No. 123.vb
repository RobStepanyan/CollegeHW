'123
s = 1
For i = 1 To 14
If i Mod 2 = 1 Then
x = Exp(i - 4)
Else
x = i ^ 2 - i
End If
y = i ^ 4
s = s * x ^ 2 * y ^ 2
Next
lst.AddItem s
