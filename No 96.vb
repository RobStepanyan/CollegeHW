'96
lst.Clear
n = Val(InputBox("N: "))
x = 22
For i = 1 To n
s = s + x ^ 2
x = x - 3.4
Next
lst.AddItem "S = " & s
