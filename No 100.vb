'100
lst.Clear
n = Val(InputBox("N: "))
x = 1
For i = 0 To n
s = s + x
x = x + 1 / Tan(x + 1)
Next
lst.AddItem "S = " & s
