namespace Cutting_Optimizer
{
    // Texts shown in 'Help'-Window
    class HelpTexts
    {
        public static string Boards = "1D objects are called BARS in this program.\n" +
                                      "2D objects are called BOARDS in this program.\n" +
                                      "Every BAR has the following properties:\n" +
                                      "     - LENGTH\n" +
                                      "     - THICKNESS\n" +
                                      "     - AMOUNT\n" +
                                      "     - PRICE\n\n" +
                                      "Every BOARD has the following properties:\n" +
                                      "     - WIDTH\n" +
                                      "     - HEIGHT\n" +
                                      "     - THICKNESS\n" +
                                      "     - AMOUNT\n" +
                                      "     - PRICE\n\n" +
                                      "WIDTH, HEIGHT, LENGTH, THICKNESS, PRICE can not be 0.\n" + 
                                      "Amount can be a number or * for unlimited amount.\n" +
                                      "PRICE can be 0.";


        public static string Parts = "Same properties like Boards/Bars, except of Price.\n" + 
                                      "No unlimited amount possible.\n" + 
                                      "THICKNESS can be 0. In this case 0 means that this part \n" +
                                      "can be used with every board (thickness).";


        public static string Space = "Space needed between parts.\n" + 
                                     "Can be 0.";


        public static string Run = "Sort your Boards and Parts before running the calculation:\n" +
                                   "\n" +
                                   "        - Start with the smallest Boards and put the biggest\n" +
                                   "          to the end of the list.\n" +
                                   "\n" +
                                   "        - Start with the biggest parts and put the smallest\n" +
                                   "          to the end of the list. (Auto-Sort avaible.)\n" +
                                   "\n" +
                                   "(You don't have to do this, but it's recommended.)\n" +
                                   "\n" +
                                   "Tipp: Change options (recursion steps, shift parts, close holes\n" +
                                   "simple mode) and RUN again to find the best solution.\n" +
                                   "\n" +
                                   "Searching a solution keeps longer, when there are more (small)\n" +
                                   "parts. In this cases try simple mode first or recursion with a\n" +
                                   "low number of recursion steps.";


        public static string Options = "Max Recursion Steps:\n" +
                                       "        This value tells the program how long it should\n" +
                                       "        search for solutions.\n" +
                                       "        It's recommended to use no values over 10000.\n\n" +
                                       "Shift Parts in Recursion:\n" +
                                       "        More flexible search for part positions (2D).\n" +
                                       "Where close Holes:\n" +
                                       "        Try to fit unused in free spaces in a solution\n" +
                                       "        found with recursion (2D). Options:\n" +
                                       "        - For every solution found with recursion\n" +
                                       "        - Only for the best solution found\n" +
                                       "        - Off\n" +
                                       "\n" +
                                       "Simple Mode:\n" +
                                       "        In this mode no recursion is used (2D).\n" +
                                       "        The algorithm scrolls through all poosible\n" +
                                       "        coordinates one time and sets the biggest\n" +
                                       "        possible part, if it finds a free space.\n" +
                                       "        \n" +
                                       "        This is much faster then recursion, but in\n" +
                                       "        some cases you will not find the best solution.\n" +
                                       "        In some cases you will find a better solution\n" +
                                       "        with this method, than with recursion.\n" +
                                       "\n" +
                                       "Sort Parts: \n" +
                                       "        Automaticly sort Parts from big to small.\n" +
                                       "\n" +
                                       "You have to create a folder for saving the\n" +
                                       "Options manually: c:/Cutting_Optimizer_Options\n\n";


        public static string Shortcuts = "You can access these functions via shortcuts (single Key):\n\n" +
                                         "      S - Save\n" +
                                         "      L - Load\n" +
                                         "      I - Save Image\n" +
                                         "      R - Run\n" +
                                         "      O - Open Options Window\n" +
                                         "      H - Open Help Window\n" +
                                         "      Q - Switch to 1D-Input\n" +
                                         "      W - Switch to 2D-Input\n" +
                                         "      B - Jump to Board Input\n" +
                                         "      P - Jump to Part Input\n" +
                                         "      S - Jump to Space Input\n";



        public static string About = "Cutting Optimizer v1.0 \n" + 
                                     "Hendrik Jacobs \n" + 
                                     "2020";
    }
}
