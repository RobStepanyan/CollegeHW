'88
lst.Clear
x = -3
Do
If x > 1 Then
y = 6 * Exp(8 + x)
Else
y = x + 4
End If
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 0.8
Loop While x <= 3
