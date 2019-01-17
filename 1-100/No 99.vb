'99
lst.Clear
n = Val(InputBox("N: "))
x = 5
For i = 1 To n
s = s + x ^ 2
x = x + x ^ 2 + 7
Next
lst.AddItem "S = " & s
