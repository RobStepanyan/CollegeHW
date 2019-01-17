For o = 1 To 9
For p = 1 To 9
If o <> p Then
For d = 0 To 9
If d <> o And d <> p Then
For i = 0 To 9
If i <> d And i <> o And i <> p Then
For n = 0 To 9
If n <> i And n <> d And n <> o And n <> p Then
For y = 0 To 9
If y <> n And y <> i And y <> d And y <> o And y <> p Then
For t = 0 To 9
If t <> y And t <> n And t <> i And t <> d And t <> o And t <> p Then
For b = 0 To 9
If b <> t And b <> y And b <> n And b <> i And b <> d And b <> o And b <> p Then
odin = o * 1000 + d * 100 + i * 10 + n
pytb = p * 1000 + y * 100 * t * 10 + b
If odin * 5 = pytb Then
Print o & d & i & n & " + " & o & d & i & n & " + " & o & d & i & n & " + " & o & d & i & n & " + " & o & d & i & n & " = " & p & y & t & b
End If
End If
Next
End If
Next
End If
Next
End If
Next
End If
Next
End If
Next
End If
Next
Next
