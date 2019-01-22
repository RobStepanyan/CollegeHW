'209
n = Val(InputBox("N: "))
t = False
Do While n > 9
If n Mod 10 Mod 2 = 1 Then
t = True
End If
n = n \ 10
Loop
lst.AddItem "T = " & t
