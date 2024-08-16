using System;using System.Threading;using static System.Console;string src=@"using System;using System.Threading;u
sing static System.Console;string src=@""{0}"";const int scl=3,row=5*scl,col=3*scl,cnt=8,pad=2*scl,wlen=col*cnt+pa
d*(cnt-1),hlen=row;src=src.Replace(Environment.NewLine,"""");src=string.Format(src,src.Replace(""\"""",""\""\"""")
);int[]di=new int[cnt],font=new int[]{{31599,19812,31183,31207,23524,29671,29679,30866,31727,31719,1040}};Write(""
\x1b[?25l"");for(;;){{Thread.Sleep(1);TimeOnly tim=TimeOnly.FromDateTime(DateTime.Now);var(h,m,s)=(tim.Hour,tim.Mi
nute,tim.Second);di[0]=h/10;di[1]=h%10;di[2]=10;di[3]=m/10;di[4]=m%10;di[5]=10;di[6]=s/10;di[7]=s%10;for(int y=0,k
=0,si=0;y<hlen;++y)for(int x=0;x<wlen;++x){{int i=x/(col+pad),j=x%(col+pad);Write(((j<col&&((font[di[i]]>>(((row-y
-1)/scl*col+j)/scl))&1)!=0)?""\x1b[5;91m"":""\x1b[0;90m"")+src[si++]);if(++k%wlen==0)Write(""\n"");}}Write($""\x1b
[{{hlen}}A\x1b[{{wlen}}D\x1b[0m"");}}";const int scl=3,row=5*scl,col=3*scl,cnt=8,pad=2*scl,wlen=col*cnt+pad*(cnt-1
),hlen=row;src=src.Replace(Environment.NewLine,"");src=string.Format(src,src.Replace("\"","\"\""));int[]di=new int
[cnt],font=new int[]{31599,19812,31183,31207,23524,29671,29679,30866,31727,31719,1040};Write("\x1b[?25l");for(;;){
Thread.Sleep(1);TimeOnly tim=TimeOnly.FromDateTime(DateTime.Now);var(h,m,s)=(tim.Hour,tim.Minute,tim.Second);di[0]
=h/10;di[1]=h%10;di[2]=10;di[3]=m/10;di[4]=m%10;di[5]=10;di[6]=s/10;di[7]=s%10;for(int y=0,k=0,si=0;y<hlen;++y)for
(int x=0;x<wlen;++x){int i=x/(col+pad),j=x%(col+pad);Write(((j<col&&((font[di[i]]>>(((row-y-1)/scl*col+j)/scl))&1)
!=0)?"\x1b[5;91m":"\x1b[0;90m")+src[si++]);if(++k%wlen==0)Write("\n");}Write($"\x1b[{hlen}A\x1b[{wlen}D\x1b[0m");}
