a = Val(InputBox("A:  "))

If (a \ 100) + (a \ 10 Mod 10) < 5 Then
f = "a"
Else
f = "b"
End If
lst.AddItem "F = " & f
