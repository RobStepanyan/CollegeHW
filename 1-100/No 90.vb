'90
lst.Clear
x = -30
Do
If x > 5 Then
y = Sin(x)
Else
y = Cos(x)
End If
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 3.5
Loop While x <= 30
