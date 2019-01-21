'173
n = Val(InputBox("N: "))
a = Val(InputBox("A: "))
b = Val(InputBox("B: "))
h = n
lst.AddItem "H = " & h
s = a + h
Do While s <= b
lst.AddItem s
s = s + h
Loop
