'217
x = Array(1, 2, 3, 4, 5)
s = 1
For i = 1 To UBound(x)
If i Mod 2 = 1 Then
s = s * x(i) ^ 2
End If
Next
lst.AddItem s
