/// <ImplicitUsings>disable</ImplicitUsings>
using System;
using System.Threading;

internal static class ProgramUncondensed
{
    private static void _Main()
    {
        string source = @"using System;using System.Threading;u
sing static System.Console;string src=@""{0}"";const int scl=3,row=5*scl,col=3*scl,cnt=8,pad=2*scl,wlen=col*cnt+pa
d*(cnt-1),hlen=row;src=src.Replace(Environment.NewLine,"""");src=string.Format(src,src.Replace(""\"""",""\""\"""")
);int[]di=new int[cnt],font=new int[]{{31599,19812,31183,31207,23524,29671,29679,30866,31727,31719,1040}};Write(""
\x1b[?25l"");for(;;){{Thread.Sleep(1);TimeOnly tim=TimeOnly.FromDateTime(DateTime.Now);var(h,m,s)=(tim.Hour,tim.Mi
nute,tim.Second);di[0]=h/10;di[1]=h%10;di[2]=10;di[3]=m/10;di[4]=m%10;di[5]=10;di[6]=s/10;di[7]=s%10;for(int y=0,k
=0,si=0;y<hlen;++y)for(int x=0;x<wlen;++x){{int i=x/(col+pad),j=x%(col+pad);Write(((j<col&&((font[di[i]]>>(((row-y
-1)/scl*col+j)/scl))&1)!=0)?""\x1b[5;91m"":""\x1b[0;90m"")+src[si++]);if(++k%wlen==0)Write(""\n"");}}Write($""\x1b
[{{hlen}}A\x1b[{{wlen}}D\x1b[0m"");}}";

        source = source.Replace(Environment.NewLine, "");
        source = string.Format(source, source.Replace("\"", "\"\""));

        const int scale = 3;
        const int rowPixels = 5 * scale;
        const int columnPixels = 3 * scale;
        const int digitCount = 8;
        const int digitPadding = 2 * scale;
        const int displayWidth = columnPixels * digitCount + digitPadding * (digitCount - 1);
        const int displayHeight = rowPixels;

        Span<int> digits = stackalloc int[digitCount];
        Span<int> font = stackalloc int[11] { 31599, 19812, 31183, 31207, 23524, 29671, 29679, 30866, 31727, 31719, 1040 };

        Console.Write("\x1b[?25l");

        while (true)
        {
            Thread.Sleep(1);

            TimeOnly tim = TimeOnly.FromDateTime(DateTime.Now); 
            var (h, m, s) = (tim.Hour, tim.Minute, tim.Second);
            digits[0] = h / 10;
            digits[1] = h % 10;
            digits[2] = 10;
            digits[3] = m / 10;
            digits[4] = m % 10;
            digits[5] = 10;
            digits[6] = s / 10;
            digits[7] = s % 10;

            for (int y = 0, w = 0, si = 0; y < displayHeight; ++y)
            {
                for (int x = 0; x < displayWidth; ++x)
                {
                    int d = x / (columnPixels + digitPadding);
                    int dx = x % (columnPixels + digitPadding);

                    char c = source[si++];

                    if (dx < columnPixels && (font[digits[d]] >> ((rowPixels - y - 1) / scale * columnPixels + dx) / scale & 1) != 0)
                        Console.Write("\x1b[5;91m" + c);
                    else
                        Console.Write("\x1b[0;90m" + c);

                    if (++w % displayWidth == 0)
                        Console.WriteLine();
                }
            }

            Console.Write($"\x1b[{displayHeight}A\x1b[{displayWidth}D\x1b[0m");
        }
    }
}
