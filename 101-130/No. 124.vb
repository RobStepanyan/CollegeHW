'124
s = 1
For i = 2 To 18
If i Mod 2 = 1 Then
x = 2 ^ (i - 4)
Else
x = i ^ 2 + 2
End If
y = i ^ 2 + 2
s = s * x * y
Next
lst.AddItem s
