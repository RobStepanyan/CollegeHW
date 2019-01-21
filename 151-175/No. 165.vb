'165
n = Val(InputBox("N: "))
Do While 3 ^ i < n
i = i + 1
Loop
If 3 ^ i = n Then
t = True
lst.AddItem "T = True, 3^" & i & " = " & n
Else
t = False
lst.AddItem "T = False"
End If
