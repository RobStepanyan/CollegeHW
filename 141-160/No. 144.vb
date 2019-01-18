'144
x = Val(InputBox("X: "))
y = Val(InputBox("Y: "))
For i = 1 To 7
For j = 1 To 8
s = s + (y * x ^ (i - j))
Next
Next
lst.AddItem s
