'102
n = Val(InputBox("N: "))
x = 2
y = 0.5
s = 1
For i = 1 To n
s = s + x - y
x = (x + 2) ^ 2
y = y + 6
Next
lst.AddItem s
