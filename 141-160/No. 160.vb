'160
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
p = 1
For i = 1 To n
f = 1
For j = 1 To i
f = f * j
Next
p = p * ((x + Cos(i * x)) / (2 ^ i * f))
Next
lst.AddItem p
