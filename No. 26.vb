a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
If (a Mod 2 = 0) Or (b Mod 2 = 0) Or (c Mod 2 = 0) Then
lst.AddItem 1
Else
lst.AddItem 2
End If
