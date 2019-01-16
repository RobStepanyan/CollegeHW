'74
lst.Clear
x = -3.8
Do While x <= 5.4
y = 2 ^ (x + 4)
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 0.3
Loop
