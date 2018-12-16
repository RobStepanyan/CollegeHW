'No. 721

x = Text1.Text
If x = "" Then
MsgBox "Datark e"
Exit Sub
End If
For i = 1 To Len(x)
If i Mod 2 = 1 Then
k = Mid(x, i, 1) & k
Else
z = Mid(x, i, 1) & z
End If
Next
Text2.Text = z & k
