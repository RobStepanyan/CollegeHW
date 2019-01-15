a = Val(InputBox("A:  "))

If (a Mod 10 = a \ 100) Or (a Mod 10 = a \ 10 Mod 10) Or (a \ 10 Mod 10 = a \ 100) Then
t = True
Else
t = False
End If
lst.AddItem "T = " & t
