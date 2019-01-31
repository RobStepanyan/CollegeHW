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
Max = 0
For j = 1 To n
If x(i, j) Mod 2 = 1 Then
Max = x(i, j)
Exit For
End If
Next
For jj = j To n
If x(i, jj) > Max And x(i, jj) Mod 2 = 1 Then
Max = x(i, jj)
End If
Next
lst.AddItem Max
Next
