a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
If a < b Then
Min = a
Else
Min = b
End If
If c < Min Then
Min = c
End If
lst.AddItem Min
