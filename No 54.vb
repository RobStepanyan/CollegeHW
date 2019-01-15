a = Val(InputBox("A:  "))

If (a \ 100) > (a \ 10 Mod 10) Then
Max = a \ 100
Else
Max = a \ 10 Mod 10
End If
If a Mod 10 > Max Then
Max = a Mod 10
End If
lst.AddItem Max
