'230
k = Val(InputBox("K: "))
For i = 1 To n
If Int(x(i)) Mod k = 0 Then
s = s + x(i)
q = q + 1
End If
Next
lst.AddItem s / q
