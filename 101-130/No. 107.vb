'107
n = Val(InputBox("N: "))
x = 1
y = 1
s = 1
For i = 0 To 3 * n
s = s * Cos(x + y)
x = x / 2
y = y / 3
Next
lst.AddItem s
