'213
x = Array(1, 2, 3, 4, 5)
For i = 0 To UBound(x)
If x(i) < 0 Then
s = s + x(i) ^ 2
q = q + 1
End If
Next
If q <> 0 Then
lst.AddItem "Mean: " & Sqr(s / q)
Else
lst.AddItem 0
End If
