'151
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 1 To n
f = 1
For j = 1 To i
f = f * j
Next
s = s + (Log(3) ^ i / f) * x ^ i
Next
lst.AddItem s
