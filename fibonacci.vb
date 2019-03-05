n = Val(InputBox("N: "))
X1 = 1
X2 = 0
x3 = X1 + X2
lst1.Clear
lst1.AddItem X2
lst1.AddItem X1
Do While X2 + x3 <= n
X1 = X2
X2 = x3
x3 = X1 + X2
lst1.AddItem x3
Loop
