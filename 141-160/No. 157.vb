'157
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
p = 1
For k = 1 To n
f = 1
For i = 1 To k
f = f * i
Next
p = p * (-1 ^ k / ((2 * x + 1) ^ k * f))
Next
lst.AddItem p
