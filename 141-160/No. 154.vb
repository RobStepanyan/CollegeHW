'154
n = Val(InputBox("N: "))
For i = 1 To n
f = 1
f1 = 1
For j = 1 To 2 * i
f = f * j
Next
For j = 1 To i ^ 2
f1 = f1 * j
Next
s = s + ((f + Abs(x)) / f1)
Next
lst.AddItem s
