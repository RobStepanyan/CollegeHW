'211
x = Array(1, 2, 3, 4, 5)
For i = 0 To UBound(x)
If x(i) Mod 2 = 0 Then
s = s + x(i)
q = q + 1
End If
Next
If q <> 0 Then
lst.AddItem "Mean: " & s / q
Else
lst.AddItem 0
End If
