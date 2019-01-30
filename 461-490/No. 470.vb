'470
'-------------------------------
Dim x() As Integer
m = Val(InputBox("M: "))
ReDim x(1 To m, 1 To m)
p1.Cls
p1.Scale (0, 0)-(m + 1, m + 1)
For i = 1 To m
bac = False
For j = 1 To m
x(i, j) = Rnd * 100 - 50
p1.CurrentX = j
p1.CurrentY = i
p1.Print x(i, j)
Next
Next
'-------------------------------
'----Artagrelu zona--------
For i = 1 To m
If x(i, 1) = x(i, m) Then
lst.AddItem x(i, i)
Else
lst.AddItem 0
End If
Next
'---------------------------
