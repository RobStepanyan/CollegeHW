Private Sub Command1_Click()
Dim x() As Integer
n = Val(InputBox("N: "))
ReDim x(1 To n, 1 To n)
Pic1.Scale (0, 0)-(n, n)
Pic1.FontSize = 50
Pic1.Cls
'Drawing lines
For i = 1 To n
Pic1.Line (0, i)-(n, i)
Pic1.Line (i, 0)-(i, n)
Next

For i = 1 To n
For j = 1 To n
x(i, j) = 0
Next
Next
tb = Val(InputBox("Yntrel tarberaky (1 kam 2 kam 3)"))

'→↑ alt ↓
If tb = 1 Then
i = 1
j = n / 2 + 0.5
For tiv = 1 To n ^ 2
x(i, j) = tiv
ii = i
jj = j
i = i - 1
j = j + 1
If j > n Then
j = 1
End If
If i = 0 Then
i = n
End If
If x(i, j) <> 0 Then
i = ii + 1
j = jj
End If
Next
Else

'→→↓ alt →↑
'Tb 2-um n-i min = 5
If tb = 2 Then
i = 1
j = 1
For tiv = 1 To n ^ 2
x(i, j) = tiv
ii = i
jj = j
'Qayl
i = i + 1
j = j + 2
If j = n + 1 Then
j = 1
End If
If j = n + 2 Then
j = 2
End If
If i > n Then
i = 1
End If
If x(i, j) <> 0 Then
i = ii - 1
j = jj + 1
End If
If j > n Then
j = 1
End If
If i = 0 Then
i = n
End If
Next
End If

'→↓↓ alt ↑↑↑
If tb = 3 Then
i = 1
j = n / 2 + 0.5
For tiv = 1 To n ^ 2
x(i, j) = tiv
ii = i
jj = j
'Qayl
i = i + 2
j = j + 1
If i = n + 1 Then
i = 1
End If
If i = n + 2 Then
i = 2
End If
If j > n Then
j = 1
End If
If x(i, j) <> 0 Then
i = ii - 3
j = jj
End If
If i = -2 Then
i = n - 2
End If
If i = -1 Then
i = n - 1
End If
If i = 0 Then
i = n
End If
Next
End If
End If


text1.text = (n^2+1)/2*n
Pic1.Cls
'Drawing lines & elements
For i = 1 To n
Pic1.Line (0, i)-(n, i)
Pic1.Line (i, 0)-(i, n)
Next
For i = 1 To n
For j = 1 To n
Pic1.CurrentX = j - 1
Pic1.CurrentY = i - 1
Pic1.Print x(i, j)
Next
Next
End Sub
