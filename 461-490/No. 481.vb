'481
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
'-------------------------------
'----Artagrelu zona--------
s = s + x(i, j)
q = q + 1
Next
Next
m = s / q
q = 0
For i = 1 To m
For j = 1 To m
If x(i, j) > m Then
q = q + 1
End If
Next
Next
lst.AddItem q
'---------------------------
