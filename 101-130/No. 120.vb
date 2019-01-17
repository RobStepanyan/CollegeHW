'120
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 0 To n
s = s + ((4 ^ (i + 1) * (x + 1) ^ i) / (i ^ 2 + 2 * i + 3))
Next
lst.AddItem Round(s, 3)
