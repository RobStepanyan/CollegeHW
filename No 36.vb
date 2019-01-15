a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
d = Val(InputBox("D: "))
x = Array(a, b, c, d)
For i = 0 To UBound(x)
If x(i) Mod 2 = 1 Then
q = q + 1
End If
Next
If q >= 2 Then
lst.AddItem True
Else
lst.AddItem False
End If
