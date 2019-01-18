'155
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 1 To n
f = 1
For j = 1 To i
f = f * j
Next
s = s + (i ^ i * x ^ (2 * i) / f)
Next
lst.AddItem s
