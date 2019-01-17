For t = 1 To 9
For d = 1 To 9
If t <> d Then
For p = 1 To 9
If p <> t And p <> d Then
For r = 1 To 9
If r <> t And r <> d And r <> p Then
For i = 1 To 9
If i <> r And i <> t And i <> d And i <> p Then
For v = 1 To 9
If v <> i And v <> r And v <> t And v <> d And v <> p Then
For a = 1 To 9
If a <> v And a <> i And a <> r And a <> t And a <> d And a <> p Then
For y = 1 To 9
If y <> a And y <> v And y <> i And y <> r And y <> t And y <> d And y <> p Then
For b = 1 To 9
If b <> y And b <> a And b <> v And b <> i And b <> r And b <> t And b <> d And b <> p Then
tri = t * 100 + r * 10 + i
dva = d * 100 + v * 10 + a
pytb = p * 1000 + y * 100 + t * 10 + b
If tri + dva = pytb Then
Print t & r & i & " + " & d & v & a & " = " & p & y & t & b
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
End If
Next
Next
