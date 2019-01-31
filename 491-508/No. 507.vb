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
bac = False
For j = 1 To n - 1
If x(i, j) Mod 2 < 0 Then
bac = True
bj = j
Exit For
End If
Next
If bac = False Then
lst.AddItem 100
Else
s = 0
For j = bj + 1 To n
s = s + x(i, j)
Next
lst.AddItem s
End If
Next
