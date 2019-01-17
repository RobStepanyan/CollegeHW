'106
n = Val(InputBox("N: "))
If n < 4 Then
MsgBox "Tivy petq e lini >=4"
Else
x = 3
y = 3
For i = 1 To n - 3
s = s + x ^ 2 + Sin(y)
x = x - y
y = y ^ 2 - 6
Next
lst.AddItem s
End If
