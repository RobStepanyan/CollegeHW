'159
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
p = 1
For i = 1 To n
f = 1
For j = 1 To i
f = f * j
Next
p = p * (f / (i + 1) - Cos(Abs(x)) ^ i)
Next
lst.AddItem p
