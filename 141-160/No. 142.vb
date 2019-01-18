'142 
a = Val(InputBox("A: "))
For k = 1 To 9
For m = 1 To 5
s = s + (a * m ^ 2 + k ^ 2)
Next
Next
lst.AddItem s
