'485
'-------------------------------
Dim x() As Integer
n = Val(InputBox("N: "))
ReDim x(1 To n, 1 To n)
p1.Cls
p1.Scale (0, 0)-(n + 1, n + 1)
For i = 1 To n
bac = False
For j = 1 To n
x(i, j) = Rnd * 100 - 50
p1.CurrentX = j
p1.CurrentY = i
p1.Print x(i, j)
Next
Next
'-------------------------------
'----Artagrelu zona--------
Max = x(1, 1)
mi = 1
mj = 1
For i = 1 To m
For j = 1 To m
If x(i, j) > Max Then
Max = x(i, j)
mi = i
mj = j
End If
Next
Next

For i = 1 To m
For j = 1 To m
If i = mi Or j = mi Then
s = s + x(i, j)
End If
lnext
Next
lst.AddItem s
'---------------------------
