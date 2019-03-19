Dim tiv As Integer
Public Function nfib(n As Integer) As Integer
If n = 0 Or n = 1 Then
nfib = 1
Else
If n > 1 Then
nfib = nfib(0)
nfib = nfib(1)
End If
nfib = nfib(n - 1) + nfib(n - 2)
End If
End Function

Private Sub Command1_Click()
tiv = Val(InputBox("Tiv: "))
MsgBox nfib(tiv)
End Sub
