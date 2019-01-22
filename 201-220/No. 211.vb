'211
n = Val(InputBox("N: "))
x = Val(InputBox("X: "))
For i = 0 To n
s = s + x ^ n
Next
lst.AddItem "Sum: " & s
