a = Val(InputBox("A:  "))

If (a \ 100) < (a \ 10 Mod 10) Then
Min = a \ 100
Else
Min = a \ 10 Mod 10
End If
If a Mod 10 < Min Then
Min = a Mod 10
End If
lst.AddItem Min
