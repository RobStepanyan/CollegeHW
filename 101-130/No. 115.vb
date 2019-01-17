'115
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 1 To n
s = s + (i / (4 ^ i + Abs(x) ^ (n + 2)))
Next
lst.AddItem Round(s, 3)
