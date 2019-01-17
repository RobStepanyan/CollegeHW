'129
s = 1
For i = 1 To 16
If Sqr(i) = Round(Sqr(i)) Then
x = Tan(i)
Else
x = 1 / Tan(i)
End If
y = Exp(i - 4)
s = s * (x * y - i)
Next
lst.AddItem s
