'255
Max = x(1) + 1
For i = 2 To n
If x(i) > Max Then
Max = x(i) + i
End If
Next
lst.AddItem "Max + index = " & Max
