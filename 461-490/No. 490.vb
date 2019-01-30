'490
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

For i = 1 To n
For j = 1 To n
If x(i, j) < 0 Then
bj = j
End If
Next
For j = 1 To bj - 1
s = s + x(i, j)
Next
lst.AddItem s
Next
'---------------------------
