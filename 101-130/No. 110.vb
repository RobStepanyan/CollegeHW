'110
n = Val(InputBox("N: "))
a = 1
b = 1
s = 1
For i = 1 To 3 * n
s = s * (a + b)
a = Sin(a)
b = Cos(b + 3)
Next
lst.AddItem s
