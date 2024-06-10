namespace Lab5
{
    internal class SMTP_Client
    {
        private string SMTPHost;
        private int SMTPPort;
        private string Username;
        private string Password;

        public SMTP_Client()
        {
            this.SMTPHost = "smtp.gmail.com";
            this.SMTPPort = 587;
            this.Username = "";
            this.Password = "";
        }

        public SMTP_Client(string sMTPHost, int sMTPPort, string username, string password)
        {
            this.SMTPHost = sMTPHost;
            this.SMTPPort = sMTPPort;
            this.Username = username;
            this.Password = password;
        }

        public string Get_host()
        {
            return this.SMTPHost;
        }
        public int Get_port()
        {
            return this.SMTPPort;
        }

        public string Get_username()
        {
            return this.Username;
        }

        public string Get_pass()
        {
            return this.Password;
        }
    }
}
