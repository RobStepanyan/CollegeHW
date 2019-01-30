'466
'-------------------------------
Dim x() As Integer
m = Val(InputBox("M: "))
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
ReDim x(1 To m, 1 To m)
p1.Scale (0, 0)-(m + 1, m + 1)
For i = 1 To m
ach = True
For j = 1 To m
x(i, j) = Rnd * 100 - 50
p1.CurrentX = j
p1.CurrentY = i
p1.Print x(i, j)
'-------------------------------
'----Artagrelu zona--------
If j + 1 <= m Then
If x(i, j) > x(i, j + 1) Then
ach = False
End If
End If
Next
If ach = False Then
lst.AddItem 3
Else
lst.AddItem -3
End If
'---------------------------
Next
