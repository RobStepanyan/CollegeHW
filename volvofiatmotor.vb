For v = 1 To 9
For f = 1 To 9
If f <> v Then
For m = 1 To 9
If m <> f And m <> v Then
For o = 0 To 9
If o <> m And o <> v And o <> f Then
For l = 0 To 9
If l <> o And l <> v And l <> f And m <> l Then
For i = 0 To 9
If i <> l And i <> v And i <> o And i <> m And i <> f Then
For a = 0 To 9
If a <> l And a <> v And a <> o And a <> m And a <> f And a <> i Then
For t = 0 To 9
If t <> l And t <> v And t <> o And t <> m And t <> f And t <> i And t <> a Then
For r = 0 To 9
If r <> l And r <> v And r <> o And r <> m And r <> f And r <> i And r <> a And r <> t Then
volvo = v * 10010 + o * 1001 + l * 100
fiat = f * 1000 + i * 100 + a * 10 + t
motor = m * 10000 + o * 1010 + t * 100 + r
If volvo + fiat = motor Then
Print v & o & l & v & o & " + " & f & i & a & t & " = " & m & o & t & o & r
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
