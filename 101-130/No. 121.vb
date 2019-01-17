'121
For i = 1 To 16
If i Mod 2 = 1 Then
x = i
y = i ^ 2
Else
x = i ^ 3
y = i
End If
s = s + (x - y) ^ 2
Next
lst.AddItem s
