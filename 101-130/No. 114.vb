'114
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 1 To n
s = s + (i / (i + 1) - Cos(Abs(x)) ^ n)
Next
lst.AddItem Round(s, 3)
