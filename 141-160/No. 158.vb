'158
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 1 To n
f = 1
For j = 1 To i
f = f * j
Next
s = s + (1 / f + Sin(i + x) / x ^ i)
Next
lst.AddItem s
