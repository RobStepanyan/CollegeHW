'170
n = Val(InputBox("N: "))
Do While True
n = n + 1
Do While 2 ^ i < n
i = i + 1
Loop
If 2 ^ i = n Then
lst.AddItem "2 ^ " & i & " = " & n
Exit Do
End If
Loop
