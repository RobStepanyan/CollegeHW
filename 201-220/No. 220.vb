'220
x = Array(1, 2, 3, 4, 5)
For i = 0 To UBound(x)
If x(i) Mod 2 = 0 Then
z = z + 1
Else
k = k + 1
End If
Next
lst.AddItem "Kent: " & k & "Hat"
lst.AddItem "Zuyg: " & z & "Hat"
