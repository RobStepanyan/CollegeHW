a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
d = Val(InputBox("D: "))
x = Array(a, b, c, d)
t = False
For i = 0 To UBound(x)
If x(i) = 1 Then
t = True
Exit For
End If
Next
lst.AddItem t
