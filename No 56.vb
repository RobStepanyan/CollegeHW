a = Val(InputBox("A:  "))

If (a Mod 10) > (a \ 10 Mod 10) Then
lst.AddItem (a \ 100 + a \ 10 Mod 10 + a Mod 10) / a
Else
lst.AddItem a
End If
