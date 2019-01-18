'147
v = Val(InputBox("V: "))
n = Val(InputBox("N: "))
For k = 1 To n
For i = 1 To k
s1 = s1 + (v * i + k)
Next
s = s + k + 5 + s1
Next
lst.AddItem s
