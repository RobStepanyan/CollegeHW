'243
p = 1
t = Val(InputBox("T: "))
For i = 1 To n
If x(i) Mod t = 0 Then
p = p + 1
End If
Next
lst.AddItem p
