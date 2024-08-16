using static System.Console;string src=@"using static System.Console;string src=@""{0}"";src=src.Replace(Environme
nt.NewLine,"""");src=string.Format(src,src.Replace(""\"""",""\""\""""));const int scl=3,row=5*scl,col=3*scl,cnt=8,
pad=2*scl,wlen=col*cnt+pad*(cnt-1),hlen=row;int[]dig=new int[cnt];Write(""\x1b[?25l"");int[]font=[31599,19812,3118
3,31207,23524,29671,29679,30866,31727,31719,1040];for(;TimeOnly.FromDateTime(DateTime.Now) is var tm;Thread.Sleep(
10)){{dig[0]=tm.Hour/10;dig[1]=tm.Hour%10;dig[2]=10;dig[3]=tm.Minute/10;dig[4]=tm.Minute%10;dig[5]=10;dig[6]=tm.Se
cond/10;dig[7]=tm.Second%10;for(int y=0,k=0,lpi=0;y<hlen;++y){{for(int x=0;x<wlen;++x){{int i=x/(col+pad),j=x%(col
+pad);Write(((j<col&&((font[dig[i]]>>(((row-y-1)/scl*col+j)/scl))&1)!=0)?""\x1b[5;91m"":""\x1b[""+""0;90m"")+src[l
pi++]);if(++k%wlen==0)Write(""\n"");}}}}Write(""\x1b[""+$""{{hlen}}A""+""\x1b[""+$""{{wlen}}D""+$""\x1b[""+$""{{0}
}m"");}}";src=src.Replace(Environment.NewLine,"");src=string.Format(src,src.Replace("\"","\"\""));const int scl=3,
row=5*scl,col=3*scl,cnt=8,pad=2*scl,wlen=col*cnt+pad*(cnt-1),hlen=row;int[]dig=new int[cnt];Write("\x1b[?25l");int
[]font=[31599,19812,31183,31207,23524,29671,29679,30866,31727,31719,1040];for(;TimeOnly.FromDateTime(DateTime.Now)
 is var tm;Thread.Sleep(10)){dig[0]=tm.Hour/10;dig[1]=tm.Hour%10;dig[2]=10;dig[3]=tm.Minute/10;dig[4]=tm.Minute%10
;dig[5]=10;dig[6]=tm.Second/10;dig[7]=tm.Second%10;for(int y=0,k=0,lpi=0;y<hlen;++y){for(int x=0;x<wlen;++x){int i
=x/(col+pad),j=x%(col+pad);Write(((j<col&&((font[dig[i]]>>(((row-y-1)/scl*col+j)/scl))&1)!=0)?"\x1b[5;91m":"\x1b["
+"0;90m")+src[lpi++]);if(++k%wlen==0)Write("\n");}}Write("\x1b["+$"{hlen}A"+"\x1b["+$"{wlen}D"+$"\x1b["+$"{0}m");}
