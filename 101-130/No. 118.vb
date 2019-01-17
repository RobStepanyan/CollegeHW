'118
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 0 To n
s = s + (Abs(2 * x + i) ^ i / ((i + 1) * (i + 2)))
Next
lst.AddItem Round(s, 3)
