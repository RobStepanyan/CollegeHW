'152
s = 1
n = Val(InputBox("N: "))
For i = 1 To n
If n Mod i = 0 Then
s = s * i
End If
Next
lst.AddItem s
