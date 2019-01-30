'465
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
s = s + x(i, j)
Next
If s > b Then
s = 1
Else
s = 0
End If
lst.AddItem s
s = 0
'---------------------------
Next
