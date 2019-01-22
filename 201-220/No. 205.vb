'205
n = Val(InputBox("N: "))
g = 1
Do While n <> 0
text1.Text = n Mod 10 & text1.Text
n = n \ 10
Loop
