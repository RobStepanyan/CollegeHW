'91
lst.Clear
n = Val(InputBox("N: "))
x = 1
For i = 1 To n
s = s + x ^ 2
x = 0.5 * Abs(x - 4)
Next
lst.AddItem "S = " & s
