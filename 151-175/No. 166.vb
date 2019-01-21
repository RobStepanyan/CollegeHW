'166
n = Val(InputBox("N: "))
Do While 4 ^ i < n
i = i + 1
Loop
If 4 ^ i = n Then
y = True
lst.AddItem "Y = 1, 4^" & i & " = " & n
Else
y = False
lst.AddItem "Y = 0"
End If
