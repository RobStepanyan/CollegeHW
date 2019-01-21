'169
x = Val(InputBox("X: "))
y = Val(InputBox("Y: "))
z = 5
For i = 2 To Sqr(x + y)
If (x + y) Mod i = 0 Then
z = 6
End If
Next
lst.AddItem "Z = " & z
