'125
For i = 1 To 10
If i / 3 = Round(i / 3) Then
x = Log(i)
Else
x = 3
End If
If i / 7 = Round(i / 7) Then
y = Log(i) / Log(3)
Else
y = 3
End If
s = s + x - y
Next
lst.AddItem s
