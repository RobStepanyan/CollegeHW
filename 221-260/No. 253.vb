'253
Min = x(1)
Mi = 1
For i = 2 To n
If x(i) < Min Then
Mi = i
Min = x(i)
End If
Next
lst.AddItem "Min " & "x(" & Mi & ")=" & Min
Max = x(1)
Mi = 1
For i = 2 To n
If x(i) > Max Then
Mi = i
Max = x(i)
End If
Next
lst.AddItem "Max " & "x(" & Mi & ")=" & Max
