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

Public Sub symm()
For i = 1 To n
For j = 1 To n
If x(i, j) Mod 10 = x(i, j) \ 10 Then
MSFlexGrid1.Row = i
MSFlexGrid1.Col = j
MSFlexGrid1.CellBackColor = vbYellow
End If
Next
Next
End Sub

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
symm
End Sub
