For m = 1 To 9
For s = 1 To 9
If s <> m Then
For y = 0 To 9
If y <> s And y <> m Then
For x = 0 To 9
If x <> y And x <> s And x <> m Then
For a = 0 To 9
If a <> x And a <> y And a <> s And a <> m Then
For l = 0 To 9
If l <> a And l <> x And l <> y And l <> s And l <> m Then
For o = 0 To 9
If o <> l And o <> a And o <> x And o <> y And o <> s And o <> m Then
For N = 0 To 9
If N <> o And N <> l And N <> a And N <> x And N <> y And N <> s And N <> m Then
myxa = m * 1000 + y * 100 + x * 10 + a
slon = s * 1000 + l * 100 + o * 10 + N
If myxa * 2 = slon Then
List1.AddItem m & y & x & a & " + " & m & y & x & a & " = " & s & l & o & N
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
