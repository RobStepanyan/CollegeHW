'No 444
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

If j > n and x(i, j) < 0 and i mod 2 = 1 Then
q = q +1
End If
Next
Next
MsgBox q
