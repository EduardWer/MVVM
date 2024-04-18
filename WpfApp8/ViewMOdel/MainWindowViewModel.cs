using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using WpfApp8.ViewMOdel.Helpers;

namespace WpfApp8.ViewMOdel
{
    internal class MainWindowViewModel : BindingHelper
    {
        private void Button_Click1(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;
            button.Content = "X";

            button.IsEnabled = false;
            bot_xod();
            Win();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = "X";
            button.IsEnabled = false;
            bot_xod();
            Win();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = "X";
            button.IsEnabled = false;
            bot_xod();
            Win();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = "X";
            button.IsEnabled = false;
            bot_xod();
            Win();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = "X";
            button.IsEnabled = false;
            bot_xod();
            Win();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = "X";
            button.IsEnabled = false;
            bot_xod();
            Win();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = "X";
            button.IsEnabled = false;
            bot_xod();
            Win();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = "X";
            button.IsEnabled = false;
            bot_xod();
            Win();
        }

        public void Win()
        {
            if (Button1.Content == "X" && button2.Content == "X" && button3.Content == "X")
            {
                MessageBox.Show("ФУУУУУУУУУ с читами играть плохо, играйте снова");
                StartGame();
            }
            if (button4.Content == "X" && button5.Content == "X" && button6.Content == "X")
            {
                MessageBox.Show("ФУУУУУУУУУ с читами играть плохо, играйте снова");
                StartGame();
            }
            if (button7.Content == "X" && button8.Content == "X" && button9.Content == "X")
            {
                MessageBox.Show("ФУУУУУУУУУ с читами играть плохо, играйте снова");
                StartGame();
            }
            if (Button1.Content == "X" && button4.Content == "X" && button7.Content == "X")
            {
                MessageBox.Show("ФУУУУУУУУУ с читами играть плохо, играйте снова");
                StartGame();

            }
            if (button2.Content == "X" && button5.Content == "X" && button8.Content == "X")
            {
                MessageBox.Show("ФУУУУУУУУУ с читами играть плохо, играйте снова");
                StartGame();

            }
            if (button3.Content == "X" && button6.Content == "X" && button9.Content == "X")
            {
                MessageBox.Show("ФУУУУУУУУУ с читами играть плохо, играйте снова");
                StartGame();

            }
            if (Button1.Content == "X" && button5.Content == "X" && button9.Content == "X")
            {
                MessageBox.Show("ФУУУУУУУУУ с читами играть плохо, играйте снова");
                StartGame();

            }
            if (button3.Content == "X" && button5.Content == "X" && button7.Content == "X")
            {
                MessageBox.Show("ФУУУУУУУУУ с читами играть плохо, играйте снова");
                StartGame();
            }
            if (Button1.Content == "0" && button2.Content == "0" && button3.Content == "0")
            {
                MessageBox.Show("С вашей карты списан весь баланс \n" +
                    "            Не отчаивайтесь, попробуйте снова 😊😊");
                StartGame();
            }
            if (button4.Content == "0" && button5.Content == "0" && button6.Content == "0")
            {
                MessageBox.Show("С вашей карты списан весь баланс \n" +
                    "            Не отчаивайтесь, попробуйте снова 😊😊");
                StartGame();
            }
            if (button7.Content == "0" && button8.Content == "0" && button9.Content == "0")
            {
                MessageBox.Show("С вашей карты списан весь баланс \n" +
                    "            Не отчаивайтесь, попробуйте снова 😊😊");
                StartGame();
            }
            if (Button1.Content == "0" && button4.Content == "0" && button7.Content == "0")
            {
                MessageBox.Show("С вашей карты списан весь баланс \n" +
                    "            Не отчаивайтесь, попробуйте снова 😊😊");
                StartGame();
            }
            if (button2.Content == "0" && button5.Content == "0" && button8.Content == "0")
            {
                MessageBox.Show("С вашей карты списан весь баланс \n" +
                    "            Не отчаивайтесь, попробуйте снова 😊😊");
                StartGame();
            }
            if (button3.Content == "0" && button6.Content == "0" && button9.Content == "0")
            {
                MessageBox.Show("С вашей карты списан весь баланс \n" +
                    "            Не отчаивайтесь, попробуйте снова 😊😊");
                StartGame();
            }
            if (Button1.Content == "0" && button5.Content == "0" && button9.Content == "0")
            {
                MessageBox.Show("С вашей карты списан весь баланс \n" +
                    "            Не отчаивайтесь, попробуйте снова 😊😊");
                StartGame();
            }
            if (button3.Content == "0" && button5.Content == "0" && button7.Content == "0")
            {
                MessageBox.Show("С вашей карты списан весь баланс \n" +
                    "            Не отчаивайтесь, попробуйте снова 😊😊");
                StartGame();
            }
            if (!Button1.IsEnabled && !button2.IsEnabled && !button3.IsEnabled && !button4.IsEnabled && !button5.IsEnabled && !button6.IsEnabled && !button7.IsEnabled && !button8.IsEnabled && !button9.IsEnabled)
            {
                MessageBox.Show("Ничья");
                StartGame();
            }
        }
        public void StartGame()
        {
            Button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
            Button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
        }
        private void bot_xod()
        {
            while (Button1.IsEnabled || button2.IsEnabled || button3.IsEnabled || button4.IsEnabled || button5.IsEnabled || button6.IsEnabled || button7.IsEnabled || button8.IsEnabled || button9.IsEnabled)
            {
                Random random = new Random();
                int rand = random.Next(1, 10);
                switch (rand)
                {

                    case 1:
                        if (Button1.IsEnabled)
                        {
                            Button1.Content = "0";
                            Button1.IsEnabled = false;
                            return;
                        }
                        break;
                    case 2:
                        if (button2.IsEnabled)
                        {
                            button2.Content = "0";
                            button2.IsEnabled = false;
                            return;
                        }
                        break;
                    case 3:
                        if (button3.IsEnabled)
                        {
                            button3.Content = "0";
                            button3.IsEnabled = false;
                            return;
                        }
                        break;
                    case 4:
                        if (button4.IsEnabled)
                        {
                            button4.Content = "0";
                            button4.IsEnabled = false;
                            return;
                        }
                        break;
                    case 5:
                        if (button5.IsEnabled)
                        {
                            button5.Content = "0";
                            button5.IsEnabled = false;
                            return;
                        }
                        break;
                    case 6:
                        if (button6.IsEnabled)
                        {
                            button6.Content = "0";
                            button6.IsEnabled = false;
                            return;
                        }
                        break;
                    case 7:
                        if (button7.IsEnabled)
                        {
                            button7.Content = "0";
                            button7.IsEnabled = false;
                            return;
                        }
                        break;
                    case 8:
                        if (button8.IsEnabled)
                        {
                            button8.Content = "0";
                            button8.IsEnabled = false;
                            return;
                        }
                        break;
                    case 9:
                        if (button9.IsEnabled)
                        {
                            button9.Content = "0";
                            button9.IsEnabled = false;
                            return;
                        }
                        break;


                }



            }

        }
    }
}
