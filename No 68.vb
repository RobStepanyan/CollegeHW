t = Val(InputBox("A:  "))
a = t \ 1000
b = t \ 100 Mod 10
c = t \ 10 Mod 10
d = t Mod 10

If b = 4 Or c = 4 Then
lst.AddItem "YES"
Else
lst.AddItem "NO"
End If
