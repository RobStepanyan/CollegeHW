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
c = Val(InputBox("C: "))
For i = 1 To n
p = 1
s = 0
Max = x(i, 1)
For j = 1 To n
s = s + x(i, j)
p = p * x(i, j)
If x(i, j) > Max Then
Max = x(i, j)
End If
Next
If Max > c Then
lst.AddItem s
Else
lst.AddItem p
End If
