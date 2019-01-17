'119
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 0 To n
s = s + (Sin(3 * x + 2 * i + 2) / (3 ^ (2 * i + 2)))
Next
lst.AddItem Round(s, 3)
