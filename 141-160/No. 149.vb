'149
a = Val(InputBox("A: "))
For i = 1 To 8
p = 1
For j = 1 To 8
p = p * Cos(a * i + j)
Next
s = s + Sin(i ^ 2 + 1) + p
Next
lst.AddItem s
