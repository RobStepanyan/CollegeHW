t = Val(InputBox("A:  "))
a = t \ 1000
b = t \ 100 Mod 10
c = t \ 10 Mod 10
d = t Mod 10

If a = 1 Or b = 1 Or c = 1 Or d = 1 Then
lst.AddItem 1
Else
lst.AddItem 0
End If
