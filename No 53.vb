a = Val(InputBox("A:  "))
k = Val(InputBox("K: "))

If a > k Then
lst.AddItem a / (a \ 100 + a \ 10 Mod 10 + a Mod 10)
Else
lst.AddItem (a \ 100 + a \ 10 Mod 10 + a Mod 10) / a
End If
