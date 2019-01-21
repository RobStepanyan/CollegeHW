'153
n = Val(InputBox("N: "))
For i = 1 To n
If n Mod i = 2 Then
s = s + i
End If
Next
lst.AddItem s
