'141
a = Val(InputBox("A: "))
p = 1
For m = 0 To 5
s = 0
For n = 0 To 6
s = s + (a ^ (m + n))
Next
p = p * s
Next
lst.AddItem s
