'78
lst.Clear
x = 10
Do While x <= 20
If x > 12 Then
y = Log(x ^ 3) / Log(3)
Else
y = x ^ 3
End If
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 2
Loop
