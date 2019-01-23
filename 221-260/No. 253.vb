'253
Min = x(1)
For i = 2 To n
If x(i) < Min Then
Mi = i
Min = x(i)
End If
Next
Max = x(1)
For i = 2 To n
If x(i) > Max Then
Mi = i
Max = x(i)
End If
Next
lst.AddItem Max + Min
