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
mxj = 1
Min = x(i, 1)
mnj = 1
For j = 2 To n
If x(i, j) > Max Then
Max = x(i, j)
mxj = j
End If
If x(i, j) < Min Then
Min = x(i, j)
mnj = j
End If
Next
If Abs(mxj - mnj) = 1 Then
lst.AddItem 0
Else
s = 0
If mxj > mnj Then
For j = mnj + 1 To mxj - 1
s = s + x(i, j)
Next
Else
For j = mxj + 1 To mnj - 1
s = s + x(i, j)
Next
lst.AddItem s
End If
End If
Next
