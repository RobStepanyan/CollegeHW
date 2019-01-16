'92
lst.Clear
n = Val(InputBox("N: "))
x = 0.5
For i = 1 To n
s = s + x
x = Tan(x + 2)
Next
lst.AddItem "S = " & s
