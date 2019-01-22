'208
n = Val(InputBox("N: "))
t = True
v = n Mod 10
Do While n > 9
n = n \ 10
If (n Mod 10) - v <> 0 Then
t = False
End If
v = n Mod 10
Loop
lst.AddItem "T = " & t
