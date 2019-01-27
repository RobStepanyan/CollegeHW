'No 457
Dim x() As Integer
n = Val(InputBox("N: "))
Pic1.Scale (0, 0)-(n + 1, n + 1)
ReDim x(1 To n, 1 To n) As Integer
Pic1.Cls
For i = 1 To n
For j = 1 To n
x(i, j) = Rnd * 100 - 50
Pic1.CurrentX = j
Pic1.CurrentY = i
Pic1.Print x(i, j)

If x(i, j) mod 2 = 1 Then
s = s + x(i, j)
End If
Next
Next
MsgBox s
