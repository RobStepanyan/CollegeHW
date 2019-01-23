'256
Min = x(1) + 1
For i = 2 To n
If x(i) < Min Then
Min = x(i) + i
End If
Next
lst.AddItem "Min + index = " & Min
