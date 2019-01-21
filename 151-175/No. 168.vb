'168
n = Val(InputBox("N: "))
p = True
For i = 2 To Sqr(n)
If n Mod i = 0 Then
p = False
End If
Next
lst.AddItem "P = " & p
