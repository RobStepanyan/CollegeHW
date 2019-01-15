a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
d = Val(InputBox("D: "))
If (a = b + c + d) Or (b = a + c + d) Or (c = a + b + d) Or (d = a + b + c) Then
lst.AddItem True
Else
lst.AddItem False
End If
