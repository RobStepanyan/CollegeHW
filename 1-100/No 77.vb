'77
lst.Clear
x = -8
Do While x <= 8
If x > 3 Then
y = x ^ 2 + 4 * x ^ 8
Else
y = 0
End If
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 3
Loop
