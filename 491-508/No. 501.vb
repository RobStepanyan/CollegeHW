Dim x() As Integer
n = Val(InputBox("N "))
ReDim x(1 To n, 1 To n)
p1.Scale (0, 0)-(n + 1, n + 1)
p2.Scale (0, 0)-(n + 1, n + 1)
p1.Cls
p2.Cls
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
s = 1
For j = 1 To n
If x(i, j) Mod 2 = 0 And (i + j) Mod 2 = 1 And x(i, j) < x(i, i) Then
s = s * x(i, j)
End If
Next
lst.AddItem s
Next
