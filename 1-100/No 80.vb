'80
lst.Clear
x = -5
Do While x <= 5
If x > 5 Then
y = 2 ^ (5 - x)
Else
y = 7 - x
End If
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 2
Loop
