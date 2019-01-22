'204
n = Val(InputBox("N: "))
g = 1
Do While n <> 0
lst.AddItem n Mod 10
n = n \ 10
Loop
