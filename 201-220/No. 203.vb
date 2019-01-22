'203
n = Val(InputBox("N: "))
g = 1
Do While n <> 0
g = g * n Mod 10
n = n \ 10
Loop
lst.AddItem g
