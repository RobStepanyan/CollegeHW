'142
a = Val(InputBox("A: "))
For k = 1 To 9
s = 0
For m = 1 To 5
s = s + (a * m ^ 2 + k ^ 2)
Next
s1 = s1 + s
Next
lst.AddItem s1
