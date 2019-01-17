'117
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 1 To n
s = s + ((Log(x ^ 2 + 3) ^ i) / ((2 * i + 1) * i))
Next
lst.AddItem Round(s, 3)
