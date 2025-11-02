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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Input_Changed(object sender, EventArgs e)
        {
            if (double.TryParse(Input1.Text, out double num1) &&
                double.TryParse(Input2.Text, out double num2) &&
                OperatorBox.SelectedItem is ComboBoxItem selectedOp)
            {
                string op = selectedOp.Content.ToString();
                double result = 0;

                switch (op)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "×": result = num1 * num2; break;
                    case "÷": result = num2 != 0 ? num1 / num2 : double.NaN; break;
                }

                ResultBox.Text = result % 1 == 0
                    ? result.ToString("F0")
                    : result.ToString("F6");

            }
            else
            {
                ResultBox.Text = "";
            }
        }

    }
}