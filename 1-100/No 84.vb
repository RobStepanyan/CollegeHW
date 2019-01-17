'84
lst.Clear
x = -6.4
Do
y = Exp(1 / Tan(x))
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 0.2
Loop While x <= 2.4
