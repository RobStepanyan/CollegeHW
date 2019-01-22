'219
x = Array(1, 2, 3, 4, 5)
k = Val(InputBox("K: "))
For i = 1 To UBound(x)
If i Mod k = 0 Then
s = s + 1
End If
Next
lst.AddItem s
