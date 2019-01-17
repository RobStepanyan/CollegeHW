'105
n = Val(InputBox("N: "))
x = 1
y = 1
For i = 0 To n - 1
s = s + x ^ 2 + y
x = Sin(x) + 3
y = Cos(y)
Next
lst.AddItem s
