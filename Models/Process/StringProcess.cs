namespace TRANHOANGCHUNGBTH.Models.Process
{
    public class StringProcess
    {
        public string khoangtrang(string strInput)
        {
            string kq="";
            strInput = strInput.Trim();
            int index=strInput.IndexOf(" ");
            while(strInput.IndexOf(" ")>0)
            {
                strInput=strInput.Replace(" "," ");
            }
        kq=strInput;
        return kq;
        }
    }
}