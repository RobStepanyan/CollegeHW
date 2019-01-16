'72
lst.Clear
x = -5.4
Do While x <= 1.2
y = 1 / Tan(x ^ 2) ^ 2
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 0.4
Loop
