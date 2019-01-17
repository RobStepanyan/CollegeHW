'108
n = Val(InputBox("N: "))
x = 1
y = 1
For i = n To 2 * n
s = s * (x + y ^ 2)
x = 5 * Abs(x + 3)
y = 5 * y + 2
Next
lst.AddItem s
