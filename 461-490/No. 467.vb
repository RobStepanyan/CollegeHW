'467
'-------------------------------
Dim x() As Integer
m = Val(InputBox("M: "))
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
ReDim x(1 To m, 1 To m)
p1.Scale (0, 0)-(m + 1, m + 1)
For i = 1 To m
bac = False
For j = 1 To m
x(i, j) = Rnd * 100 - 50
p1.CurrentX = j
p1.CurrentY = i
p1.Print x(i, j)
'-------------------------------
'----Artagrelu zona--------
If x(i, j) < 0 Then
bac = True
End If
Next
If bac = True Then
lst.AddItem x(i, 1)
Else
lst.AddItem x(i, m)
End If
'---------------------------
Next
