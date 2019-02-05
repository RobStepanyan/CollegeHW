Dim x() As Integer
Dim n As Integer
Public Sub mutq()
For i = 1 To n
For j = 1 To n
x(i, j) = Rnd * 97 + 2
MSFlexGrid1.Row = i
MSFlexGrid1.Col = j
MSFlexGrid1.CellBackColor = vbWhite
MSFlexGrid1.Text = x(i, j)
Next
Next
End Sub

Public Function symm(tiv As Integer) As Boolean
If tiv Mod 10 = tiv \ 10 Then
symm = True
Else
symm = False
End If
End Function

Private Sub Command1_Click()
n = InputBox("N: ")
MSFlexGrid1.Rows = n + 1
MSFlexGrid1.Cols = n + 1
ReDim x(1 To n, 1 To n)
'Toxer, syuner labels
For i = 1 To n
MSFlexGrid1.Row = i
MSFlexGrid1.Col = 0
MSFlexGrid1.Text = i & " Tox"
Next
For i = 1 To n
MSFlexGrid1.Row = 0
MSFlexGrid1.Col = i
MSFlexGrid1.Text = i & " Syun"
Next
mutq
For i = 1 To n
For j = 1 To n
If symm(x(i, j)) = True Then
MSFlexGrid1.Row = i
MSFlexGrid1.Col = j
MSFlexGrid1.CellBackColor = vbYellow
End If
Next
Next

End Sub
