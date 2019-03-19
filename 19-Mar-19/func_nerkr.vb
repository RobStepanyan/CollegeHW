Dim artiv As Integer
Dim tarb As Integer
Dim n As Integer
Public Function nerkr(a As Integer, d As Integer, n) As Integer
If n = 1 Then
nerkr = a
Else
nerkr = nerkr(a * d, d, n - 1)
End If
End Function

Private Sub Command1_Click()
artiv = Val(InputBox("Tiv: "))
tarb = Val(InputBox("Tiv: "))
n = Val(InputBox("N:"))
MsgBox nerkr(artiv, tarb, n)
End Sub
