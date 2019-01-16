'81
lst.Clear
x = -7.5
Do While x <= 8.3
y = Log(x ^ 2 + 4) / Log(3)
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 0.3
Loop While x <= 8.3
