t = Val(InputBox("A:  "))
a = t \ 100
b = t \ 10 Mod 10
c = t Mod 10

If a > b Then
k = a
a = b
b = k
End If
If c > a And c < b Then
k = c
c = b
b = k
End If
If c < a Then
k = a
a = c
c = k
k = b
b = c
c = k
End If
t = c * 100 + b * 10 + a
lst.AddItem t
