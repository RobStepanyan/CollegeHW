'112
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 1 To n
s = s + (Cos(2 * n - 1) * x) / (2 ^ (2 * n - 1))
Next
lst.AddItem Round(s, 3)
