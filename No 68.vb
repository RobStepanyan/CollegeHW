t = Val(InputBox("A:  "))
a = t \ 1000
b = t \ 100 Mod 10
c = t \ 10 Mod 10
d = t Mod 10

If d > c Then
lst.AddItem d * b
Else
lst.AddItem 1
End If
