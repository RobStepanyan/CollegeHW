'93
lst.Clear
n = Val(InputBox("N: "))
x = 0.5
For i = 5 To n
s = s + x ^ 2 + x
x = Tan(x + 2)
Next
lst.AddItem "S = " & s
