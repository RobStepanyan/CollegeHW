'122
For i = 1 To 10
If i Mod 2 = 1 Then
x = Exp(i - 4)
Else
x = i ^ 2 - i
End If
If i ^ 2 Mod 2 = 1 Then
y = Tan(i) ^ 2
Else
y = 0
End If
s = s + x ^ 2 - y ^ 2
Next
lst.AddItem s
