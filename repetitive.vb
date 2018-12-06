Dim a(0 To 1000000) As Integer
N = Val(InputBox("n: "))
Text1.Text = ""
'A(0) - quanity of digits
'A(1) - starting of factorial digits
a(0) = 1
a(1) = 1
j = 2
Do While j <= N And a(0) < 1000000
r = 0
i = 1
Do While i <= a(0) Or r <> 0
w = a(i) * j + r
a(i) = w Mod 10
r = w \ 10
If a(a(0) + 1) <> 0 Then
a(0) = a(0) + 1
End If
i = i + 1
Loop
j = j + 1
Loop
Dim y(0 To 9) As Integer
For i = a(0) To 1 Step -1
Text1.Text = Text1.Text & a(i)
y(a(i)) = y(a(i)) + 1
Next
Max = y(0)
imax = 0
For i = 1 To 9
If y(i) >= Max Then
Max = y(i)
imax = i
End If
Next
For i = 0 To 9
List1.AddItem i & " - " & y(i)
Next
Text2.Text = imax & " tivy" & Max & "Angam"
