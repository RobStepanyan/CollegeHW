'158
s = 1
For i = 100 To 999
If i Mod 6 <> 0 Then
s = s * i
End If
Next
lst.AddItem s
