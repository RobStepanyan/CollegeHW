'No. 652

Dim x() As Variant
k = Text1.Text
If k = "" Then
MsgBox "Datark e"
Exit Sub
End If
l = Len(k)
ReDim x(1 To l)
q = 0
Text2.Text = ""
For i = 1 To l
    x(i) = Mid(k, i, 1)
    krk = False
    For j = 1 To l
            If j <> i Then
                If x(i) = Mid(k, j, 1) Then
                    krk = True
                End If
            End If
    Next
    If krk = True Then
    Text2.Text = Text2.Text & x(i)
    End If
Next
