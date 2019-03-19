Dim max As Integer
Private Sub Command1_Click()
mv
MsgBox max
End Sub

Public Sub mv()
tiv = Val(InputBox("Tiv: "))
If tiv <> 0 Then
mv
End If
If tiv = 0 Then
max = tiv
End If
If max < tiv Then
max = tiv
End If
End Sub
