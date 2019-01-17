'109
n = Val(InputBox("N: "))
a = 1
b = 2
For i = 1 To n
s = s + a + b ^ 2
a = 6 * a - 4
b = 5 * Tan(b) + 3
Next
lst.AddItem s
