'146
c = Val(InputBox("C: "))
For i = 1 To 5
For k = 1 To 8
s1 = s1 + (c * i + k) / k
Next
s = s + i ^ 2 + s1
Next
lst.AddItem s
