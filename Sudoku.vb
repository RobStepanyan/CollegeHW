n = Val(InputBox("N: "))
Pic1.Scale (0, 0)-(n, n)
Pic1.Cls
'DrawingLines
For i = 1 To n
Pic1.Line (0, i)-(n, i)
Pic1.Line (i, 0)-(i, n)
Next

'tiv - number
'st - first elements of lines
tiv = 1
st = 1
For i = 1 To n
For j = 1 To n
Pic1.CurrentX = j - 1
Pic1.CurrentY = i - 1
Pic1.Print tiv
tiv = tiv + 1
If tiv > n Then
tiv = 1
End If
Next
st = st + 2
If st > n Then
st = 2
End If
tiv = st
Next
