a = Val(InputBox("A:  "))
b = Val(InputBox("B: "))
c = Val(InputBox("C: "))
If (a + b < c) Or (a + c < b) Or (c + b < a) Then
lst.AddItem "y=2"
Else
lst.AddItem "y=1"
End If
