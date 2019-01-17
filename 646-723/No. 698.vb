'No. 698

x = Text1.Text
y = Text2.Text
n = Val(InputBox("N: "))
m = Val(InputBox("M: "))
If x = "" Or y = "" Then
MsgBox "Datark e"
Exit Sub
End If
Text3.Text = Left(x, m) & Right(y, n)
