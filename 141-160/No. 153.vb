'153
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 0 To n
f = 1
For j = 1 To 2 * i + 1
f = f * j
Next
s = s + (x ^ (2 * n + 1) / f)
Next
lst.AddItem s
