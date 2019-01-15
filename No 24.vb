a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
If (a = 1 And b = 1) Or (a = 1 And c = 1) Or (c = 1 And b = 1) Then
lst.AddItem True
Else
lst.AddItem False
End If
