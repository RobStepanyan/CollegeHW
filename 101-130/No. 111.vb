'111
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 0 To n
s = s + (x ^ (4 * i + 1)) / (4 * i + 1)
Next
lst.AddItem Round(s, 3)
