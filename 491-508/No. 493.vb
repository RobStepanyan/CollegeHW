Dim x() As Integer
n = Val(InputBox("N "))
m = Val(InputBox("M: "))
ReDim x(1 To n, 1 To m)
p1.Scale (0, 0)-(m + 1, n + 1)
p2.Scale (0, 0)-(m + 1, n + 1)
p1.Cls
p2.Cls
For i = 1 To n
For j = 1 To m
x(i, j) = Rnd * 100 - 50
p1.CurrentX = j
p1.CurrentY = i
p1.Print x(i, j)
Next
Next
'----------------------------
Max = x(1, 1)
mi = 1
mj = 1
For i = 1 To n
For j = 1 To m
If x(i, j) > Max Then
Max = x(i, j)
mi = i
mj = j
End If
Next
Next
For i = 1 To n
For j = 1 To m
If i = mi Or j = mj Then
x(i, j) = Empty
End If
Next
Next
'-------------------------
For i = 1 To n
For j = 1 To m
p2.CurrentX = j
p2.CurrentY = i
p2.Print x(i, j)
Next
Next
