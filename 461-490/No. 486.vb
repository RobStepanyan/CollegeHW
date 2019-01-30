'486
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
If (i = j Or i + j = n + 1) And x(i, j) > 0 Then
s = s + x(i, j) ^ 2
q = q + 1
End If
Next
Next
lst.AddItem Sqr(s / q)
'---------------------------
