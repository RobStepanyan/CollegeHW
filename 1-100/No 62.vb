t = Val(InputBox("A:  "))
a = t \ 1000
b = t \ 100 Mod 10
c = t \ 10 Mod 10
d = t Mod 10

If t < 5000 Then
lst.AddItem t / (b + d)
Else
lst.AddItem t / (a + c)
End If
