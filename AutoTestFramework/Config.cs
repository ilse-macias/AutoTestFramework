namespace AutoTestFramework
{
    public static class Config
    {
        public static string BaseURL = "http://testing.todvachev.com/";
        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "ValidUser";
                public static string Password = "asdf1234!";
                public static string RepeatPassword = "asdf1234!";
                public static string Email = "example@example.com";
            }

            public static class Invalid
            {
                public static class Username
                {
                    public static string FourCharacters = "asdf";
                    public static string ThirteenCharacters = "Asdfgasdfgas";
                }

                public static class Password
                {
                    public static string onlyNumbers = "123456";
                    public static string onlyLetters = "asbcds";
                }

                public static class Email
                {
                    public static string invalidEmail = "example@";
                } 
            }
        }

    }
}
