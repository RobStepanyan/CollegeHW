'130
s = 1
For i = 1 To 10
If i / 5 = Round(i / 5) Then
x = i
Else
x = i ^ 2
End If
If i / 3 = Round(i / 3) Then
y = i ^ 3
Else
y = 6
End If
s = s * x * y
Next
lst.AddItem s
