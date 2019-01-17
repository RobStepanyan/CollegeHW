'82
lst.Clear
x = -2.7
Do
y = (x + x ^ 2) ^ 7
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 0.5
Loop While x <= 3.3
