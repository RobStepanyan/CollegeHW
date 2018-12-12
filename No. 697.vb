'No. 697

n = Val(InputBox("N: "))
k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
If Len(k) > n Then
k = Right(k, Len(k) - n)
Else
For i = 1 To n - Len(k)
s = s & " "
Next
k = s & k
End If
Text2.Text = k
