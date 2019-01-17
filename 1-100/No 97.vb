'97
lst.Clear
n = Val(InputBox("N: "))
x = 1
For i = 1 To 3 * n
s = s + x
x = x + 7
Next
lst.AddItem "S = " & s
