'95
lst.Clear
n = Val(InputBox("N: "))
x = 1
For i = 0 To n
s = s + x ^ 2 - x
x = Sin(x) ^ 2
Next
lst.AddItem "S = " & s
