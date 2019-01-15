a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
If a > b Then
Max = a
Else
Max = b
End If
If c > Max Then
Max = c
End If
lst.AddItem Max

