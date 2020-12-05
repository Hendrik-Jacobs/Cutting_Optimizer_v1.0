namespace Cutting_Optimizer
{
    public static class MessageBoxReturn
    {
        public static bool Return { get; set; }
        public static string text { get; set; }
        public static string Button1 { get; set; }
        public static string Button2 { get; set; }


        public static void SetStrings(string t, string b1, string b2)
        {
            text = t;
            Button1 = b1;
            Button2 = b2;
        }
    }
}
