a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
d = Val(InputBox("D: "))
x = Array(a, b, c, d)
Min = x(0)
For i = 0 To UBound(x)
If x(i) < Min Then
Min = x(i)
End If
Next
lst.AddItem Min
