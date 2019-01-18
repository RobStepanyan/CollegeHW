'152
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 0 To n
f = 1
For j = 1 To 2 * i
f = f * j
Next
s = s + (x ^ (2 * n) / f)
Next
lst.AddItem s
