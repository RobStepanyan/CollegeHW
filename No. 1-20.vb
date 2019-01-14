dim x as variant
dim y as variant
dim z as variant
dim p as variant

'1

x = val(inputbox("X: "))
y = val(inputbox("Y: "))
z = (y+1)*(x+(x^2 +1)^6 * sin(x^2 -3)-tan(y))
lst1.additem "Xnd1: " & z

'2
x = val(inputbox("x = ")
y = val(inputbox("y = ")

z = (x^2-4)/(y^2+x^2)+2^sin(sqr(x^2+1))
lst1.additem "Xnd2: " & z 

'3
x = val(inputbox("x = ")
y = val(inputbox("y = ")
z = 1/tan(abs(x^2 -y)/(x^2+y^2)) + log(x^2+1)/log(10)
lst1.additem "Xnd3: " & z

'4
x = val(inputbox("x = ")
y = val(inputbox("y = ")
z = ln(exp(x)+1)+(x^2+4)^(1/3)

lst1.additem "Xnd4: " & z 

'5
x = val(inputbox("x = ")
y = val(inputbox("y = ")
z = (2^x - 5)/(3^y) + 2 + log((abs(x)+1)^4 + y^2)

lst1.additem "Xnd5: " & z 

'6
x = val(inputbox("x = ")
y = val(inputbox("y = ")
z = atn((3*x+4)/y^2+4)+sqr((x^2+3)^3)

lst1.additem "Xnd6: " & z 

'7
x = val(inputbox("x = ")
y = val(inputbox("y = ")
z = ((x^2 + y^2)^5 + 4)^7 + sin(cos(x+y))

lst1.additem "Xnd7: " & z 

'8
x = val(inputbox("x = ")
y = val(inputbox("y = ")
z = (x^2+((y^2+4)^(1/3))^(1/4))+(abs(x)+abs(y))^10

lst1.additem "Xnd8: " & z

'9
x = val(inputbox("x = ")
y = val(inputbox("y = ")
z = ((x+4)/(y^2 + 4)^3)^(1/5)
p = sin((x+z)^2) + 3*z + y/x^2

lst1.additem "Xnd8: " & z

'10
x = val(inputbox("x = ")
y = val(inputbox("y = ")
z = sin(3.14/(12+x))*cos((y+z)/(3.14+z^2))+exp(z+4)

lst1.additem "Xnd10: " & z 

'11
a = Val(InputBox("a="))
b = Val(InputBox("b="))
If a ^ 2 + b ^ 2 > 5 Then
y = 3 * Exp(a - x) + Log(a ^ 2 + b ^ 2 + 5) / Log(3)
Else
If a ^ 2 + b ^ 2 < 1 Then
y = Tan(a + b) ^ 4
Else
y = -3
End If
End If
lst1.AddItem "Xnd11: " & y

'12
x = val(inputbox("x = ")
a = val(inputbox("a= ")

if x>=-5 and x<=5 then
y = (1+a^2)^6
else
if x > 5 then
y = cos(ln(abs(x))^2)+x^8
else 
y = a 
end if 
end if

lst1.additem "Xnd12: " & y 

'13
a = Val(InputBox("a="))
b = Val(InputBox("b="))
If a + Abs(b) < -5 Then
Exp (a + x) * Cos(a + x + b) ^ 2
Else
If a + Abs(b) > 2 Then
y = (Atn(a + x)) ^ (1 / 3)
Else
y = a + Abs(b)
lst1.AddItem "Xnd13: " & y

'14
a = Val(InputBox("a="))
b = Val(InputBox("b="))
if a + b < 3 then
y = atn(a+b)^4
else
if a+b>5 then
y = log(2)/log(8) * (a+b)
else
y = a^15
end if 
end if 
lst1.additem "Xnd14: " & y

'15
a = Val(InputBox("a="))
b = Val(InputBox("b="))
c = Val(InputBox("c="))
x = Val(InputBox("x="))
If -1 < c < 1 Then
y = b + Tan(c + a) ^ 5
Else
If c <= -1 Then
y = Cos * ln(Abs(x)) ^ 2 + x ^ 8
Else
y = a ^ -10
End If
End If
lst_pat.AddItem "Xnd15: " & y

'16
x = val(inputbox("x = ")
a = val(inputbox("a= ")
if abs(a) > 3 then
y = sin(abs(x+a)^2)+ cos(x^2)^2
else 
y = (a^2+x^2)^(1/4)*log(a^2+x^4)/log(2)
end if 
lst1.additem Xnd16: " & y 

'17
a = val(inputbox("a= ")
if abs(a)>3 then
y = log(5)/log(2)*(4+a^2)+log(z+a)
else
y =(z^4+4*a)^5
end if 
lst1.additem "Xnd17: " & y 

'18
x = Val(InputBox("x="))
z = Val(InputBox("z="))
If x>=1 and x<=7 Then
y = (Abs(x) + 2 * Abs(z)) ^ (1 / 4) + Exp(Abs(x + 1))
Else
y = Tan((x + z) ^ 7) ^ 2
End If
lst_pat.AddItem Xnd18: " & y

'19
a = Val(InputBox("a="))
b = Val(InputBox("b="))
c = Val(InputBox("c="))
If a + b < 7 Then
y = 1 / Tan(a ^ 2 + b ^ 2 + c) ^ 2
Else
y = 10 ^ -7
End If
lst_pat.AddItem "Xnd19: " & y

'20
x = val(inputbox("x = ")
a = val(inputbox("a= ")
if a<3 then
y = exp(cos(x+a+b))*tg(a+b^2)
else 
y = log(4+a^2+b^2)/log(3)
end if 

lst1.additem "Xnd20: " & y 

