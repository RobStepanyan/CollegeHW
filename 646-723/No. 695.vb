'No. 695

a = Val(Text1.Text)
d = 0
Do While (a <> 0)
v = a Mod 10
s = s + 2 ^ d * v
d = d + 1
a = a \ 10
Loop
Text2.Text = s
