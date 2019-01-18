'156
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 1 To n
f = 1
For j = 1 To i
f = f * j
Next
s = s + (-1 ^ i * (x ^ i / f))
Next
lst.AddItem 1 / n * s
