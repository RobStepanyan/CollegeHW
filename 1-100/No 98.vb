'98
lst.Clear
n = Val(InputBox("N: "))
x = 1
For i = n To 2 * n
s = s + x
x = x + 3.4 * Abs(x - 7)
Next
lst.AddItem "S = " & s
