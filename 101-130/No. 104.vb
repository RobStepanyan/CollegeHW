'104
n = Val(InputBox("N: "))
x = -7
y = 8
For i = 0 To n
s = s + x ^ 2 - 2 * y
x = Sin(x) ^ 2
y = y + 2
Next
lst.AddItem s
