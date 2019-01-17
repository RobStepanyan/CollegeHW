'126
For i = 1 To 16
If i / 5 = Round(i / 5) Then
x = i
Else
x = 0
End If
If i / 7 = Round(i / 7) Then
y = i ^ 2
Else
y = i
End If
s = s + x - y
Next
lst.AddItem s
