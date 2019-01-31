'492
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
mxi = 1
Min = x(1, 1)
mni = 1
For i = 1 To n
For j = 1 To m
If x(i, j) > Max Then
Max = x(i, j)
mxi = i
End If
If x(i, j) < Min Then
Min = x(i, j)
mni = i
End If
Next
Next
For j = 1 To n
k = x(mxi, j)
x(mxi, j) = x(mni, j)
x(mni, j) = k
Next
'-------------------------
For i = 1 To n
For j = 1 To m
p2.CurrentX = j
p2.CurrentY = i
p2.Print x(i, j)
Next
Next
