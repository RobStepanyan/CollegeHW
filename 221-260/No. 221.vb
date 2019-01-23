'221
'------This Section is Same for Others --------
Dim x() As Integer
n = Val(InputBox("N: "))
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
ReDim x(1 To n)
For i = 1 To n
x(i) = Rnd * 100 - 50
Next
'-----------------------------------------------
For i = 1 To n
If x(i) >= a And x(i) <= b Then
s = s + x(i)
End If
Next
lst.AddItem s
