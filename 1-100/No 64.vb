t = Val(InputBox("A:  "))
a = t \ 1000
b = t \ 100 Mod 10
c = t \ 10 Mod 10
d = t Mod 10

If d + c = 5 Then
y = "s"
Else
y = "d"
End If
lst.AddItem "Y = " & y
