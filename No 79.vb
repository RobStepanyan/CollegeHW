'79
lst.Clear
x = -4
Do While x <= 5
If x > 1 Then
y = Log(x) / Log(4)
Else
y = -9
End If
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 1
Loop
