'242
p = 1
m = Val(InputBox("M: "))
For i = 1 To n
If x(i) Mod m = 0 Then
p = p * x(i)
End If
Next
lst.AddItem p
