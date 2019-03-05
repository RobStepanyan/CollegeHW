Private Sub mnux1_Click()
Dim x() As Integer
n = Val(InputBox("N: "))
pic1.Scale (0, 0)-(n + 1, n + 1)
pic1.Cls
ReDim x(1 To n, 1 To n)
tiv = 1
For i = 1 To n
For j = 1 To n
x(i, j) = tiv
tiv = tiv + 1
pic1.CurrentX = j
pic1.CurrentY = i
pic1.Print x(i, j)
Next
Next
End Sub

Private Sub mnux2_Click()
Dim x() As Integer
n = Val(InputBox("N: "))
m = Val(InputBox("M: "))
pic1.Scale (0, 0)-(m + 1, n + 1)
pic1.Cls
ReDim x(1 To n, 1 To m)
tiv = 1
z = False
For i = 1 To n
For j = 1 To m
If z = False Then
x(i, j) = tiv
tiv = tiv + 1
z = True
Else
x(i, j) = 0
z = False
End If
pic1.CurrentX = j
pic1.CurrentY = i
pic1.Print x(i, j)
Next
Next
End Sub

Private Sub mnux21_Click()
Dim x() As Integer
n = Val(InputBox("N: "))
ReDim x(1 To n)
lst1.Clear
For i = 1 To n
x(i) = Rnd * 100 - 50
lst1.AddItem x(i)
Next
m1 = x(1)
mi1 = 1
m2 = x(2)
mi2 = 2
m3 = x(3)
mi3 = 3
For i = 2 To n
If x(i) < m1 Then
m1 = x(i)
mi1 = i
End If
Next
For i = 1 To n
If x(i) < m2 And mi1 <> i Then
m2 = x(i)
mi2 = i
End If
Next
For i = 1 To n
If x(i) < m3 And mi1 <> i And mi2 <> i Then
m3 = x(i)
mi3 = i
End If
Next
MsgBox "Poqr1 =  " & m1 & " |Poqr2 = " & m2 & " |Poqr3 = " & m3
End Sub

Private Sub mnux22_Click()
Dim x() As Integer
Dim y() As Integer
n = Val(InputBox("N: "))
ReDim x(1 To n)
lst1.Clear
lst2.Clear
q = 0
For i = 1 To n
x(i) = Rnd * 10 - 5
lst1.AddItem x(i)
If x(i) = 0 Then
q = q + 1
End If
Next
ReDim y(1 To n - q)
For i = 1 To UBound(x)
If x(i) = 0 Then
m = m + 1
End If
If x(i) <> 0 Then
y(i - m) = x(i)
End If
Next
For i = 1 To UBound(y)
lst2.AddItem y(i)
Next
End Sub

Private Sub mnux23_Click()
Dim a() As Integer
Dim b() As Integer
Dim c() As Integer
n = Val(InputBox("N: "))
ReDim a(1 To n)
ReDim b(1 To n)
ReDim c(1 To 2 * n)
lst1.Clear
lst2.Clear
lst3.Clear
For i = 1 To n
a(i) = Rnd * 100 - 50
lst1.AddItem a(i)
Next
For i = 1 To n
b(i) = Rnd * 100 - 50
lst2.AddItem b(i)
Next
For i = 1 To 2 * n
c(i) = 0
Next
s = 1
For i = 1 To n
c(s) = a(i)
s = s + 2
Next
s = 2
For i = 1 To n
c(s) = b(i)
s = s + 2
Next
For i = 1 To UBound(c)
lst3.AddItem c(i)
Next
End Sub

Private Sub mnux3_Click()
Dim x() As Integer
n = Val(InputBox("N: "))
m = Val(InputBox("M: "))
pic1.Scale (0, 0)-(m + 1, n + 1)
pic1.Cls
ReDim x(1 To n, 1 To m)
For i = 1 To n
For j = 1 To m
If j >= i Then
x(i, j) = 1
Else
x(i, j) = 0
End If
pic1.CurrentX = j
pic1.CurrentY = i
pic1.Print x(i, j)
Next
Next

End Sub

Private Sub mnux31_Click()
n = Val(InputBox("N: "))
X1 = 1
X2 = 0
x3 = X1 + X2
lst1.Clear
lst1.AddItem X2
lst1.AddItem X1
Do While X2 + x3 <= n
X1 = X2
X2 = x3
x3 = X1 + X2
lst1.AddItem x3
Loop
End Sub

Private Sub mnux32_Click()
nax = Text1.Text
hin = InputBox("Hin tar kam bar: ")
nor = InputBox("Nor tar kam bar: ")
nax = Replace(nax, hin, nor)
Text2.Text = nax
End Sub

Private Sub mnux33_Click()
nax = Text1.Text
l = Split(nax, " ")
Text2.Text = ""
For i = 0 To UBound(l)
q = 0
For j = 1 To Len(l(i))
If Mid(l(i), j, 1) = "a" Then
q = q + 1
End If
Next
If q > 1 Then
Text2.Text = Text2.Text & " " & l(i)
End If
Next
End Sub
