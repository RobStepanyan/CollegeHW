Dim x() As Integer
n = Val(InputBox("N "))
ReDim x(1 To n, 1 To n)
p1.Scale (0, 0)-(n + 1, n + 1)
p1.Cls
For i = 1 To n
For j = 1 To n
x(i, j) = Rnd * 100 - 50
p1.CurrentX = j
p1.CurrentY = i
p1.Print x(i, j)
Next
Next
'---------------------------
For i = 1 To n
Max = x(i, 1)
mj = 1
For j = 2 To n
If x(i, j) >= Max Then
Max = x(i, j)
mj = j
End If
Next
s = 1
For j = 1 To mj - 1
s = s * x(i, j)
Next
If s = 1 Then
s = 0
End If
lst.AddItem s
Next
