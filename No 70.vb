t = Val(InputBox("A:  "))
a = t \ 1000
b = t \ 100 Mod 10
c = t \ 10 Mod 10
d = t Mod 10

If a * b * c * d > 200 Then
y = 0
Else
y = 1
End If
lst.AddItem "Y = " & y
