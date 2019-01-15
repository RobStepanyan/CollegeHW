t = Val(InputBox("A:  "))
a = t \ 1000
b = t \ 100 Mod 10
c = t \ 10 Mod 10
d = t Mod 10

If c + d = a + b Then
t = True
Else
t = False
End If
lst.AddItem "T = " & t
