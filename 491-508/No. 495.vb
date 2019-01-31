Dim x() As Integer
n = Val(InputBox("N "))
ReDim x(1 To n, 1 To 2 * n)
p1.Scale (0, 0)-(n * 2 + 1, n + 1)
p2.Scale (0, 0)-(n * 2 + 1, n + 1)
p1.Cls
p2.Cls
For i = 1 To n
For j = 1 To 2 * n
x(i, j) = Rnd * 100 - 50
p1.CurrentX = j
p1.CurrentY = i
p1.Print x(i, j)
Next
Next
'----------------------------
For i = 1 To n
For ii = i To n
If x(i, 2 * n) < x(ii, 2 * n) Then
k = x(i, 2 * n)
x(i, 2 * n) = x(ii, 2 * n)
x(ii, 2 * n) = k
End If
Next
Next
'-------------------------
For i = 1 To n
For j = 1 To 2 * n
p2.CurrentX = j
p2.CurrentY = i
p2.Print x(i, j)
Next
Next
