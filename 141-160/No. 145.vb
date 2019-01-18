'145
c = Val(InputBox("C: "))
For i = 1 To 7
p = 1
For k = 1 To 8
p = p * (i ^ 2 + c * k)
Next
s = s + p
Next
lst.AddItem s
