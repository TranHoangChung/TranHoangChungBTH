namespace TRANHOANGCHUNGBTH.Models.Process
{
    public class GPT
    {
        public string ptbn(double hesoA,double hesoB)
        {
            string mess="";
            double x;
            if (hesoA==0 && hesoB==0)
            {
                    mess="PT vo so nghiem";
            }
            if (hesoA!=0)
            {
                x=-hesoB/hesoA;
                mess="PT co nghiem "+ x ;
            }
            else
            {
                mess="PT vo nghiem";
            }
             return mess;
        }
    public string ptbh(double a,double b,double c)
    {
        string message="";
        double denta,x1,x2;
        if (a==0)
        {
            message=ptbn(b,c);
        }
        else
        {
           denta=b*b-4*a*c;
           if (denta < 0)
           {
            message="PTVN";
           }
           if (denta == 0)
           {
            message="PT co nghiem kep x = "+(-b/(2*a));
           }
           else
           {
            x1=(-b + Math.Sqrt(denta)/(2*a));
            
            x2=(-b - Math.Sqrt(denta)/(2*a));
            message="PT co 2 nghiem : x1 =  " + x1 +" x2 =  " + x2 ;
           }

        }
        return message;
    }
 }
}