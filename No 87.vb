'87
lst.Clear
x = 10
Do
If x > 7 Then
y = Exp(Sin(x))
Else
y = 0
End If
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 3.2
Loop While x <= 23
