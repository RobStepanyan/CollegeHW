'167
x = Val(InputBox("X: "))
y = False
For n = 1 To 30
If Sin(x) ^ n < 0 Then
y = True
End If
Next
lst.AddItem "Y = " & y
