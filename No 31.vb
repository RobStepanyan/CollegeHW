a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
d = Val(InputBox("D: "))
x = Array(a, b, c, d)
Max = x(0)
For i = 0 To UBound(x)
If x(i) > Max Then
Max = x(i)
End If
Next
lst.AddItem Max
