'86
lst.Clear
x = -5
Do
If x > 2 Then
y = 3 ^ (x + 4)
Else
y = -8
End If
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 2
Loop While x <= 8
