'206
n = Val(InputBox("N: "))
e = Len(n) - 1
Do While n <> 0
t = t + (n Mod 10) * 10 ^ e
e = e - 1
n = n \ 10
Loop
lst.AddItem t
