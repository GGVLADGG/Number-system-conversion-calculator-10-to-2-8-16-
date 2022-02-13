using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Калькулятор_системы_счислений___10___2__8__16_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int radio_button = 0;
        public static string number_without_points = "";
        string number_from_output_text = "";
        int check_points = 0;
        int pass_for_points = 0;
        string number_with_points = "0";
        int pass_for_number_with_points = 0;
        BigInteger whole_part_from_output_text = 0;
        BigInteger remains = 0;
        int count_elements = 0;
        int index_number = 0;
        string new_number = "";
        string output_number = "";
        double part_with_points = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void System_2(object sender, RoutedEventArgs e)
        {
            radio_button = 2;
        }
        private void System_8(object sender, RoutedEventArgs e)
        {
            radio_button = 8;
        }
        private void System_16(object sender, RoutedEventArgs e)
        {
            radio_button = 16;
        }
        private void Click_1(object sender, RoutedEventArgs e)
        {
            Output.Text += "1";
        }
        private void Click_2(object sender, RoutedEventArgs e)
        {
            Output.Text += "2";
        }
        private void Click_3(object sender, RoutedEventArgs e)
        {
            Output.Text += "3";
        }
        private void Click_4(object sender, RoutedEventArgs e)
        {
            Output.Text += "4";
        }
        private void Click_5(object sender, RoutedEventArgs e)
        {
            Output.Text += "5";
        }
        private void Click_6(object sender, RoutedEventArgs e)
        {
            Output.Text += "6";
        }
        private void Click_7(object sender, RoutedEventArgs e)
        {
            Output.Text += "7";
        }
        private void Click_8(object sender, RoutedEventArgs e)
        {
            Output.Text += "8";
        }
        private void Click_9(object sender, RoutedEventArgs e)
        {
            Output.Text += "9";
        }
        private void Click_0(object sender, RoutedEventArgs e)
        {
            Output.Text += "0";
        }
        private void Click_point(object sender, RoutedEventArgs e)
        {
            Output.Text += ".";
        }
        private void Click_Backspace(object sender, RoutedEventArgs e)
        {
            if (Output.Text == "")
            {

            }
            else
            {
                Output.Text = Output.Text.Remove(Output.Text.Length - 1);
            }
        }
        private void Click_equal(object sender, RoutedEventArgs e)
        {
            try
            {
                number_without_points = "";
                if (radio_button == 2)
                {
                    number_from_output_text = Output.Text;
                    if (number_from_output_text == "." || number_from_output_text == "")
                    {
                        MessageBox.Show("Введите какое-то число");
                    }
                    else
                    {
                        check_points = 0;
                        pass_for_points = 0;
                        foreach (char n in number_from_output_text)
                        {
                            if (n == '.')
                            {
                                check_points++;
                                if (check_points > 1)
                                {
                                    MessageBox.Show("Слишком много точек");
                                    pass_for_points = 1;
                                    break;
                                }
                            }
                        }
                        if (pass_for_points > 0)
                        {

                        }
                        else
                        {
                            foreach (char n in number_from_output_text)
                            {
                                if (n == '.')
                                {
                                    break;
                                }
                                else
                                {
                                    number_without_points += Convert.ToString(n);
                                }
                            }
                            number_with_points = "0";
                            pass_for_number_with_points = 0;
                            foreach (char n in number_from_output_text)
                            {
                                if (n == '.' || pass_for_number_with_points > 0)
                                {
                                    pass_for_number_with_points++;
                                    number_with_points += Convert.ToString(n);
                                }
                            }
                            if (number_with_points == "0." || number_with_points == "0")
                            {
                                MainPart2();
                                Output.Text = output_number;
                            }
                            else
                            {
                                OtherPart2();
                                MainPart2();
                                if (output_number == "")
                                {
                                    Output.Text = output_number + number_with_points;
                                }
                                else
                                {
                                    number_with_points = number_with_points.Remove(0, 1);
                                    Output.Text = output_number + number_with_points;
                                }
                            }
                        }
                    }
                }
                else if (radio_button == 8)
                {
                    number_from_output_text = Output.Text;
                    if (number_from_output_text == "." || number_from_output_text == "")
                    {
                        MessageBox.Show("Введите какое-то число");
                    }
                    else
                    {
                        check_points = 0;
                        pass_for_points = 0;
                        foreach (char n in number_from_output_text)
                        {
                            if (n == '.')
                            {
                                check_points++;
                                if (check_points > 1)
                                {
                                    MessageBox.Show("Слишком много точек");
                                    pass_for_points = 1;
                                    break;
                                }
                            }
                        }
                        if (pass_for_points > 0)
                        {

                        }
                        else
                        {
                            foreach (char n in number_from_output_text)
                            {
                                if (n == '.')
                                {
                                    break;
                                }
                                else
                                {
                                    number_without_points += Convert.ToString(n);
                                }
                            }
                            number_with_points = "0";
                            pass_for_number_with_points = 0;
                            foreach (char n in number_from_output_text)
                            {
                                if (n == '.' || pass_for_number_with_points > 0)
                                {
                                    pass_for_number_with_points++;
                                    number_with_points += Convert.ToString(n);
                                }
                            }
                            if (number_with_points == "0." || number_with_points == "0")
                            {
                                MainPart8();
                                Output.Text = output_number;
                            }
                            else
                            {
                                OtherPart8();
                                MainPart8();
                                if (output_number == "")
                                {
                                    Output.Text = output_number + number_with_points;
                                }
                                else
                                {
                                    number_with_points = number_with_points.Remove(0, 1);
                                    Output.Text = output_number + number_with_points;
                                }
                            }
                        }
                    }
                }
                else if (radio_button == 16)
                {
                    number_from_output_text = Output.Text;
                    if (number_from_output_text == "." || number_from_output_text == "")
                    {
                        MessageBox.Show("Введите какое-то число");
                    }
                    else
                    {
                        check_points = 0;
                        pass_for_points = 0;
                        foreach (char n in number_from_output_text)
                        {
                            if (n == '.')
                            {
                                check_points++;
                                if (check_points > 1)
                                {
                                    MessageBox.Show("Слишком много точек");
                                    pass_for_points = 1;
                                    break;
                                }
                            }
                        }
                        if (pass_for_points > 0)
                        {

                        }
                        else
                        {
                            foreach (char n in number_from_output_text)
                            {
                                if (n == '.')
                                {
                                    break;
                                }
                                else
                                {
                                    number_without_points += Convert.ToString(n);
                                }
                            }
                            number_with_points = "0";
                            pass_for_number_with_points = 0;
                            foreach (char n in number_from_output_text)
                            {
                                if (n == '.' || pass_for_number_with_points > 0)
                                {
                                    pass_for_number_with_points++;
                                    number_with_points += Convert.ToString(n);
                                }
                            }
                            if (number_with_points == "0." || number_with_points == "0")
                            {
                                MainPart16();
                                Output.Text = output_number;
                            }
                            else
                            {
                                OtherPart16();
                                MainPart16();
                                if (output_number == "")
                                {
                                    Output.Text = output_number + number_with_points;
                                }
                                else
                                {
                                    number_with_points = number_with_points.Remove(0, 1);
                                    Output.Text = output_number + number_with_points;
                                }
                            }
                        }
                    }
                }
                else if (radio_button == 0)
                {
                    MessageBox.Show("Вы не выбрали систему счисления");
                }
            }
            catch
            {
                MessageBox.Show("Конвертация невозможна");
            }
        }
        private void Click_Clear(object sender, RoutedEventArgs e)
        {
            Output.Text = "";
        }
        private void Click_Copy(object sender, RoutedEventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(Output.Text);
        }
        private void Click_Paste(object sender, RoutedEventArgs e)
        {
            Output.Text += Clipboard.GetText();
        }
        private void MainPart2()
        {
            whole_part_from_output_text = BigInteger.Parse(number_without_points);
            remains = 0;
            count_elements = 0;
            index_number = 0;
            new_number = "";
            output_number = "";
            while (whole_part_from_output_text >= 1)
            {
                remains = whole_part_from_output_text;
                remains %= 2;
                whole_part_from_output_text /= 2;
                new_number += Convert.ToString(remains);
            }
            foreach (char n in new_number)
            {
                count_elements++;
            }
            string[] massive = new string[count_elements];
            foreach (char n in new_number)
            {
                massive[index_number] = Convert.ToString(n);
                index_number++;
            }
            Array.Reverse(massive);
            for (int i = 0; i < massive.Length; i++)
            {
                output_number += Convert.ToString(massive[i]);
            }
        }
        private void OtherPart2()
        {
            number_with_points = number_with_points.Replace(".", ",");
            part_with_points = Convert.ToDouble(number_with_points);
            number_with_points = "0.";
            string support = "";
            while (number_with_points.Length < 13)
            {
                part_with_points *= 2;
                support = Convert.ToString(part_with_points);
                if (part_with_points >= 1)
                {
                    number_with_points += "1";
                    support = support.Remove(0, 1);
                    support = support.Insert(0, "0");
                    part_with_points = Convert.ToDouble(support);
                }
                else
                {
                    number_with_points += "0";
                }
            }
        }
        private void MainPart8()
        {
            whole_part_from_output_text = BigInteger.Parse(number_without_points);
            remains = 0;
            count_elements = 0;
            index_number = 0;
            new_number = "";
            output_number = "";
            while (whole_part_from_output_text != 0)
            {
                remains = whole_part_from_output_text;
                remains %= 8;
                whole_part_from_output_text /= 8;
                new_number += Convert.ToString(remains);
            }
            foreach (char n in new_number)
            {
                count_elements++;
            }
            string[] massive = new string[count_elements];
            foreach (char n in new_number)
            {
                massive[index_number] = Convert.ToString(n);
                index_number++;
            }
            Array.Reverse(massive);
            for (int i = 0; i < massive.Length; i++)
            {
                output_number += Convert.ToString(massive[i]);
            }
        }
        private void OtherPart8()
        {
            number_with_points = number_with_points.Replace(".", ",");
            part_with_points = Convert.ToDouble(number_with_points);
            number_with_points = "0.";
            string support = "";
            while (number_with_points.Length < 13)
            {
                part_with_points *= 8;
                support = Convert.ToString(part_with_points);
                if (part_with_points >= 1)
                {
                    foreach (char n in support)
                    {
                        number_with_points += Convert.ToString(n);
                        break;
                    }
                    support = support.Remove(0, 1);
                    support = support.Insert(0, "0");
                    part_with_points = Convert.ToDouble(support);
                }
                else
                {
                    number_with_points += "0";
                }
            }
        }
        private void MainPart16()
        {
            whole_part_from_output_text = BigInteger.Parse(number_without_points);
            remains = 0;
            count_elements = 0;
            index_number = 0;
            new_number = "";
            output_number = "";
            while (whole_part_from_output_text != 0)
            {
                remains = whole_part_from_output_text;
                remains %= 16;
                whole_part_from_output_text /= 16;
                if (remains == 10)
                {
                    new_number += "A";
                }
                else if (remains == 11)
                {
                    new_number += "B";
                }
                else if (remains == 12)
                {
                    new_number += "C";
                }
                else if (remains == 13)
                {
                    new_number += "D";
                }
                else if (remains == 14)
                {
                    new_number += "E";
                }
                else if (remains == 15)
                {
                    new_number += "F";
                }
                else
                {
                    new_number += Convert.ToString(remains);
                }
            }
            foreach (char n in new_number)
            {
                count_elements++;
            }
            string[] massive = new string[count_elements];
            foreach (char n in new_number)
            {
                massive[index_number] = Convert.ToString(n);
                index_number++;
            }
            Array.Reverse(massive);
            for (int i = 0; i < massive.Length; i++)
            {
                output_number += Convert.ToString(massive[i]);
            }
        }
        private void OtherPart16()
        {
            number_with_points = number_with_points.Replace(".", ",");
            part_with_points = Convert.ToDouble(number_with_points);
            number_with_points = "0.";
            string support = "";
            string double_numbers = "";
            int pass = 0;
            while (number_with_points.Length < 13)
            {
                double_numbers = "";
                pass = 0;
                part_with_points *= 16;
                support = Convert.ToString(part_with_points);
                if (part_with_points >= 10)
                {
                    foreach (char n in support)
                    {
                        if (pass >= 2)
                        {

                        }
                        else
                        {
                            pass++;
                            double_numbers += Convert.ToString(n);
                        }
                    }
                    if (double_numbers == "10")
                    {
                        number_with_points += "A";
                    }
                    else if (double_numbers == "11")
                    {
                        number_with_points += "B";
                    }
                    else if (double_numbers == "12")
                    {
                        number_with_points += "C";
                    }
                    else if (double_numbers == "13")
                    {
                        number_with_points += "D";
                    }
                    else if (double_numbers == "14")
                    {
                        number_with_points += "E";
                    }
                    else if (double_numbers == "15")
                    {
                        number_with_points += "F";
                    }
                    support = support.Remove(0, 2);
                    support = support.Insert(0, "0");
                    support = support.Insert(0, "0");
                    part_with_points = Convert.ToDouble(support);
                }
                else if (part_with_points >= 1 && part_with_points < 10)
                {
                    foreach (char n in support)
                    {
                        number_with_points += Convert.ToString(n);
                        break;
                    }
                    support = support.Remove(0, 1);
                    support = support.Insert(0, "0");
                    part_with_points = Convert.ToDouble(support);
                }
                else
                {
                    number_with_points += "0";
                }
            }
        }
    }
}
