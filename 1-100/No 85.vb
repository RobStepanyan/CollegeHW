'85
lst.Clear
x = -3.3
Do
y = Abs(2 * x + x ^ 3)
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 0.3
Loop While x <= 2.7
