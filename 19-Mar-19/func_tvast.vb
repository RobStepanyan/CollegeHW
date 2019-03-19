Dim tiv As Integer
Dim ast As Integer
Private Sub Command1_Click()
tiv = Val(InputBox("Tiv: "))
ast = Val(InputBox("Astichan: "))
MsgBox tvast(tiv, ast)
End Sub

Public Function tvast(a As Integer, n As Integer) As Integer
If n = 0 Then
tvast = 1
Else
If n = 1 Then
tvast = a
Else
tvast = tvast(a * tiv, n - 1)
End If
End If
End Function
