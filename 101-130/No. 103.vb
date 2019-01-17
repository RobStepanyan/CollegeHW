'103
n = Val(InputBox("N: "))
If n < 4 Then
MsgBox "Tivy petq e lini >=4"
Else
x = 2
y = 1
s = 1
For i = 4 To n
s = s + x ^ 2 + y
x = x ^ 2
y = Tan(y)
Next
lst.AddItem s
End If
