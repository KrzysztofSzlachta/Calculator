using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    Kalkulator kalkulator = new Kalkulator();
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn)
        {
            string display = number_display.Text;
            string content = btn.Content.ToString();

            switch (content)
            {
                case "del":
                    if (display.Length > 1)
                    {
                        display = display.Substring(0, display.Length - 1);
                    }
                    else
                    {
                        display = "0";
                    }
                    number_display.Text = display;
                    break;

                case "CE":
                    number_display.Text = "0";
                    break;

                case "C":
                    kalkulator.Erase();
                    number_display.Text = "0";
                    break;

                case "=":
                    kalkulator.secondNumber = double.Parse(display);
                    number_display.Text = kalkulator.Calculate();
                    break;
                case "+":
                case "-":
                case "x":
                case "/":
                    if (kalkulator.firstNumber != null && kalkulator.operation != null)
                    {
                        kalkulator.secondNumber = double.Parse(display);
                        number_display.Text = kalkulator.Calculate();
                        kalkulator.operation = content;
                        break;
                    }
                    kalkulator.operation = content;
                    break;

                case "%":
                case "1/x":
                case "x^2":
                case "sqrt":
                    if(display != "0" && kalkulator.firstNumber != null)
                    {
                        kalkulator.secondNumber = double.Parse(display);
                        number_display.Text = kalkulator.SpecjalCalculate(content);
                    }
                    if (kalkulator.firstNumber == null)
                    {
                        kalkulator.firstNumber = double.Parse(display);
                        number_display.Text = kalkulator.SpecjalCalculate(content);
                    }
                    break;

                case ",":
                    if (!display.Contains(","))
                    {
                        number_display.Text += btn.Content.ToString();
                    }
                    break;

                case "+/-":
                    if (display == "0" || display == "0,")
                    {
                        break;
                    }
                    if (display.Contains("-"))
                    {
                        number_display.Text = display.Substring(1);
                    }
                    else
                    {
                        number_display.Text = "-" + display;
                    }
                    break;

                default:
                    if (kalkulator.firstNumber == null && kalkulator.operation != null)
                    {
                        kalkulator.firstNumber = double.Parse(display);
                        number_display.Text = content;
                        break;
                    }
                    if (kalkulator.operation != null && display != "0")
                    {
                        number_display.Text = content;
                        break;
                    }
                    if (display == "0" || display == "Error")
                    {
                        number_display.Text = content;
                        break;
                    }
                    else
                    {
                        number_display.Text += content;
                        break;
                    }
            }
        }
    }
}
