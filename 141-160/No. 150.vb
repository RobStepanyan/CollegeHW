'150
b = Val(InputBox("B: "))
p = 1
For k = 1 To 10
s = 0
For j = 1 To 8
s = s + Tan(b * k + j ^ 2)
Next
p = p * (k + 1) * s
Next
lst.AddItem s
