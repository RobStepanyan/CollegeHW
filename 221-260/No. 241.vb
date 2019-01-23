'241
k = Val(InputBox("K: "))
For i = 1 To n
If x(i) Mod k = 0 Then
p = p + x(i)
End If
Next
lst.AddItem p
