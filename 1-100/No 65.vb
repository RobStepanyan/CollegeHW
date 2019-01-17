t = Val(InputBox("A:  "))
a = t \ 1000
b = t \ 100 Mod 10
c = t \ 10 Mod 10
d = t Mod 10

If d * c = 12 Then
lst.AddItem "y = 12"
Else
lst.AddItem "y = 0"
End If
