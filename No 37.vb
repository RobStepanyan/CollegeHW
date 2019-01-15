a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
d = Val(InputBox("D: "))
If d - c = c - b And c - b = b - a Then
lst.AddItem True
Else
lst.AddItem False
End If
