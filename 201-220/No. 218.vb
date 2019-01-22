'218
x = Array(1, 2, 3, 4, 5)
For i = 1 To UBound(x)
If i Mod 2 = 1 Then
s = s + Abs(x(i))
End If
Next
lst.AddItem s
