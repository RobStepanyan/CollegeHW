'83
lst.Clear
x = -4.8
Do
y = Atn(x + 1) ^ 2
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 0.2
Loop While x <= 5.2
