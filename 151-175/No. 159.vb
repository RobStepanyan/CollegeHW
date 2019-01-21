'159
s = 1
For i = 100 To 999
If i Mod 3 = 1 And i Mod 4 = 2 Then
s = s * i
End If
Next
lst.AddItem s
