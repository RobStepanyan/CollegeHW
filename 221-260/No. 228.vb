'228
k = Val(InputBox("K: "))
For i = 1 To n
If i Mod k = 0 Then
s = s + x(i)
End If
Next
lst.AddItem s 
