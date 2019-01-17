'113
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 0 To n
s = s + ((1 / (2 * n + 1)) * ((x - 1) / (x ^ 2 + 1)) ^ (2 * n + 1))
Next
lst.AddItem Round(s, 3)
