using System.Text;


namespace module4
{
    public class StringChecker : IStringChecker
    {
        private StringBuilder stringBuilder;
        public void AddString(string str)
        {
            stringBuilder = new StringBuilder();
            stringBuilder.Append(str[0] + "");
        }


        public string ShowResult()
        {
            return stringBuilder.ToString();
        }
    }
}
