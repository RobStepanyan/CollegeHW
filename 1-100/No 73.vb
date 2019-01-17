'73
lst.Clear
x = 7.5
Do While x <= 12.5
y = (x + 1) ^ 2
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 0.2
Loop
