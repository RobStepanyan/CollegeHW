'202
n = Val(InputBox("N: "))
Do While n <> 0
g = g + n Mod 10
n = n \ 10
Loop
lst.AddItem g
