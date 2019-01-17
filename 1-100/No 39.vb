a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
d = Val(InputBox("D: "))

x = Array(a, b, c, d)
For i = 0 To UBound(x)
For j = i To UBound(x)
If x(i) > x(j) Then
k = x(i)
x(i) = x(j)
x(j) = k
End If
Next
Next
For i = 0 To UBound(x)
lst.AddItem x(i)
Next
