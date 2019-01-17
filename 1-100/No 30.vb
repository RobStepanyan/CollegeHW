a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
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
lst.AddItem c & " " & b & " " & a
