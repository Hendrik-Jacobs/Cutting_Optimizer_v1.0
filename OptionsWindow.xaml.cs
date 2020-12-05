using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;

namespace Cutting_Optimizer
{
    public partial class OptionsWindow : Window
    {
        public OptionsWindow()
        {
            InitializeComponent();
            box.Text = Options.MaxStage.ToString();
            showTablesbox.IsChecked = Options.ShowParttables;
            showPricesbox.IsChecked = Options.ShowPrices;
            sumPartsbox.IsChecked = Options.SumParts;
            sumBoardsbox.IsChecked = Options.SumBoards;
            shiftbox.IsChecked = Options.Shift;
            if (Options.CloseHolesEvery)
            {
                closeHolesBox.SelectedIndex = 0;
            }
            else if (Options.CloseHolesEnd)
            {
                closeHolesBox.SelectedIndex = 1;
            }
            else
            {
                closeHolesBox.SelectedIndex = 2;
            }
            simplebox.IsChecked = Options.SimpleMode;
            sortPartsbox.IsChecked = Options.SortParts;
        }

        private void ClickSave(object sender, RoutedEventArgs e)
        {
            try
            {
                Options.MaxStage = Int32.Parse(box.Text);
            }
            catch { }

            if (Options.MaxStage >= 10000)
            {
                MessageBoxReturn.SetStrings("More Recursion Steps as recommended.\n" + "Continue?", "OK", "Cancel");
                CustomMessageBox customMessageBox = new CustomMessageBox();
                customMessageBox.Width += 50;
                customMessageBox.MinWidth += 50;
                customMessageBox.MaxWidth += 50;
                customMessageBox.Button1.Width +=25;
                customMessageBox.Button2.Width += 25;
                customMessageBox.ShowDialog();

                if (!MessageBoxReturn.Return)
                {
                    return;
                }
            }

            Options.ShowParttables = (showTablesbox.IsChecked == true);
            Options.ShowPrices = (showPricesbox.IsChecked == true);
            Options.SumParts = (sumPartsbox.IsChecked == true);
            Options.SumBoards = (sumBoardsbox.IsChecked == true);
            Options.Shift = (shiftbox.IsChecked == true);
            switch (closeHolesBox.SelectedIndex)
            {
                case 0:
                    Options.CloseHolesEvery = true;
                    Options.CloseHolesEnd = false;
                    break;
                case 1:
                    Options.CloseHolesEvery = false;
                    Options.CloseHolesEnd = true;
                    break;
                case 2:
                    Options.CloseHolesEvery = false;
                    Options.CloseHolesEnd = false;
                    break;
            }
            Options.SimpleMode = (simplebox.IsChecked == true);
            Options.SortParts = (sortPartsbox.IsChecked == true);

            bool run = true;

            while (run)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter("c:/Cutting_Optimizer_Options/Options.txt"))
                    {
                        sw.WriteLine(box.Text);
                        char c = (Options.ShowParttables) ? '1' : '0';
                        sw.WriteLine(c);
                        c = (Options.ShowPrices) ? '1' : '0';
                        sw.WriteLine(c);
                        c = (Options.SumParts) ? '1' : '0';
                        sw.WriteLine(c);
                        c = (Options.SumBoards) ? '1' : '0';
                        sw.WriteLine(c);
                        c = (Options.Shift) ? '1' : '0';
                        sw.WriteLine(c);
                        c = (Options.CloseHolesEvery) ? '1' : '0';
                        sw.WriteLine(c);
                        c = (Options.CloseHolesEnd) ? '1' : '0';
                        sw.WriteLine(c);
                        c = (Options.SimpleMode) ? '1' : '0';
                        sw.WriteLine(c);
                        c = (Options.SortParts) ? '1' : '0';
                        sw.WriteLine(c);
                    }
                    run = false;
                }
                catch
                {                   
                    string text = "Can't save options to file.\n" +
                                    "Please create empty folder:\n\n" +
                                    "c:/Cutting_Optimizer_Options";


                    MessageBoxReturn.SetStrings(text, "Try again", "Close without \n" +
                                                                   "saving to file.");
                    CustomMessageBox customMessageBox = new CustomMessageBox();
                    customMessageBox.Height += 50;
                    customMessageBox.Width += 30;
                    customMessageBox.MinHeight += 50;
                    customMessageBox.MinWidth += 30;
                    customMessageBox.MaxHeight += 50;
                    customMessageBox.MaxWidth += 30;
                    customMessageBox.Button1.Width += 18;
                    customMessageBox.Button2.Width += 18;
                    customMessageBox.Button2.Height *= 2;
                    customMessageBox.stackPanel.Height += 50;
                    customMessageBox.border.Height += 30;
                    customMessageBox.ShowDialog();

                    if (!MessageBoxReturn.Return)
                    {
                        run = false;
                    }                    
                }
            }
            this.Close();
        }



        // Select all Text when go to TextBox.
        private void KeySelectedBox(object sender, RoutedEventArgs e)
        {
            TextBox tb = (sender as TextBox);
            tb.SelectAll();
        }



        // Only int to TextBox.
        private void PreviewText(object sender, TextCompositionEventArgs e)
        {
            if (!Tools.IsNumber(e.Text))
            {
                e.Handled = true;
            }            
        }
    }
}
