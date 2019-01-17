a = Val(InputBox("A:  "))

If a > 300 Then
lst.AddItem (a \ 10 Mod 10) / (a Mod 10)
Else
lst.AddItem (a \ 100) / (a Mod 10)
End If
