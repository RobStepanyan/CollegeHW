'462
'-------------------------------
Dim x() As Integer
m = Val(InputBox("M: "))
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
ReDim x(1 To m, 1 To m)
p1.Scale (0, 0)-(m + 1, m + 1)
For i = 1 To m
For j = 1 To m
x(i, j) = Rnd * 100 - 50
p1.CurrentX = j
p1.CurrentY = i
p1.Print x(i, j)
'-------------------------------
'----Artagrelu zona--------
If i = j And x(i, j) = 0 Then
For jj = 1 To m
lst.AddItem x(i, jj)
Next
End If
'---------------------------
Next
Next
