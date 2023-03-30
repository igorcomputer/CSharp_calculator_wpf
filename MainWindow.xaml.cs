using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CalcApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        int num1 = 0;
        int num2 = 0;
        string op = "";
        public MainWindow() {
            InitializeComponent();
        }
        private void btn_num_Click(object sender, RoutedEventArgs e) {

            Button button = (Button)sender;
            string str = button.Content.ToString();
            int num = Int32.Parse(str);

            if (op == "") {
                num1 = num1 * 10 + num;
                txtValue.Text = num1.ToString();
            } else {
                num2 = num2 * 10 + num;
                txtValue.Text = num2.ToString();
            }
        }

        private void btn_op_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            op = button.Content.ToString();
        }

        private void btn_eq_Click(object sender, RoutedEventArgs e) {
            int result = 0;
            switch (op) {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "Min":
                    result = Math.Min(num1, num2);
                    break;
                case "Max":
                    result = Math.Max(num1, num2); 
                    break;
                case "Avg":
                    result = GetAvg(num1, num2);
                    break;
            }

            txtValue.Text = result.ToString();
            op = "";
            num1 = result;
        }

        private int GetAvg(int a, int b) {
            return (a + b) / 2;
        }

    }
}
