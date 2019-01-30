'469
'-------------------------------
Dim x() As Integer
m = Val(InputBox("M: "))
ReDim x(1 To m, 1 To m)
p1.Clear
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
If i + j = n + 1 And x(i, j) < 0 Then
For ii = 1 To n
lst.AddItem x(ii, j)
Next
Exit For
Exit For
End If
'---------------------------
Next
Next
