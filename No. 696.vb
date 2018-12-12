'No. 696

a = Val(Text1.Text)
Do While (a >= 1)
r = a Mod 2
Text2.Text = r & Text2.Text
a = a \ 2
Loop
