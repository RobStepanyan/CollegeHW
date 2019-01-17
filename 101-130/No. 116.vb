'116
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 1 To n
s = s + (2 * x + 1) ^ i / ((i + 5) * Log(x ^ 2 + 1))
Next
lst.AddItem Round(s, 3)
