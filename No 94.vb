'94
lst.Clear
n = Val(InputBox("N: "))
x = -4.2
For i = 0 To n
s = s + x ^ 2 - 2 * x
x = 1 / Tan(x)
Next
lst.AddItem "S = " & s
