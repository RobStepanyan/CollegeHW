'89
lst.Clear
x = -5
Do
If x > 3 Then
y = Log(x) / Log(4)
Else
y = -9
End If
lst.AddItem "X = " & Round(x, 2) & " | Y= " & Round(y, 2)
x = x + 1.5
Loop While x <= 9
