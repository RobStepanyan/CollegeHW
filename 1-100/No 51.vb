a = Val(InputBox("A:  "))

If a Mod 10 = a \ 100 + a \ 10 Mod 10 Then
t = True
Else
t = False
End If
lst.AddItem "T = " & t
