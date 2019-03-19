Dim artiv As Integer
Dim tarb As Integer
Dim n As Integer
Public Function ntvab(a As Integer, d As Integer, n) As Integer
If n = 1 Then
ntvab = a
Else
ntvab = ntvab(a + d, d, n - 1)
End If
End Function

Private Sub Command1_Click()
artiv = Val(InputBox("Tiv: "))
tarb = Val(InputBox("Tiv: "))
n = Val(InputBox("N:"))
MsgBox ntvab(artiv, tarb, n)
End Sub
