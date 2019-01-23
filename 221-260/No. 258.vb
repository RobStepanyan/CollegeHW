'258
Max = x(1)
Mi = 1
For i = 2 To n
If x(i) >= Max Then
Mi = i
Max = x(i)
End If
Next
lst.AddItem "Max: " & "x(" & Mi & ")=" & Max
