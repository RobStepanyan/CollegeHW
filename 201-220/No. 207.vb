'207
n = Val(InputBox("N: "))
t = False
Do While n <> 0
If n Mod 10 = 2 Then
t = True
End If
n = n \ 10
Loop
lst.AddItem "T = " & t
