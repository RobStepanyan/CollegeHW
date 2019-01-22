'210
n = Val(InputBox("N: "))
Do While n <> 0
q = q + 1
If q Mod 2 = 1 Then
z = z + n Mod 10
Else
k = k + n Mod 10
End If
n = n \ 10
Loop
If k = z Then
lst.AddItem True
Else
lst.AddItem False
End If
