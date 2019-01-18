'143
a = Val(InputBox("A: "))
n = Val(InputBox("N: "))
p = 1
For i = 0 To 15
p1 = 1
For m = 1 To 6
p1 = p1 * (i / (i + n * m))
Next
p = p * p1
Next
lst.AddItem p
