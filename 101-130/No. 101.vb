'101
n = Val(InputBox("N: "))
x = 1
y = 2
For i = 1 To n
s = s + (x + y) ^ 2
x = 2 * Abs(x + 3)
y = y ^ 2 - 4
Next
lst.AddItem s
