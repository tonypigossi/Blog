namespace BlogApi
{
    public class Configuration
    {
        public static string JwtKey = "xBRCGnTdeVZU0eLz2uDMe2aRQ==FQSbqZP/bkm5PKsA/qAhkg==lbxx3BHbGUWK87p/n/MPYw==";
        public static string ApiKeyName { get; set; }
        public static string ApiKey { get; set; }
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }    
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}