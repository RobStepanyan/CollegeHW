'175
lst.clear
n = Val(InputBox("N: "))
x = 1
For k = 1 To n
lst.AddItem x
x = (x + 1) / k
Next
