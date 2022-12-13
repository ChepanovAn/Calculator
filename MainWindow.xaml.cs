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

namespace WpfApp4
{
  
    public partial class MainWindow : Window
    {
        double first;
        double second;
        char op;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtResult.Text += btn.Content.ToString();     
           
        }
       
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            first = Double.Parse(TxtResult.Text);
            op = '+';
            TxtResult.Clear();
        }
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            first = Double.Parse(TxtResult.Text);
            op = '-';
            TxtResult.Clear();
        }
        private void MultButton_Click(object sender, RoutedEventArgs e)
        {
            first = Double.Parse(TxtResult.Text);
            op = '*';
            TxtResult.Clear();
        }
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            first = Double.Parse(TxtResult.Text);
            op = '/';
            TxtResult.Clear();
        }
        private void EqualsButton_Click(object sender, RoutedEventArgs e)        
        {
            second = Double.Parse(TxtResult.Text);

            int number = 0;   
            string result=number.ToString();

            if (second==0)
            {
                result = "На 0 делить нельзя";
                TxtResult.Text = result;
                return;
            }

            switch (op)
            {
                case '+':
                    double result_plus = first + second;
                    result = result_plus.ToString();                    
                    break;
                    
                case '-':
                    double result_minus = first - second;
                    result = result_minus.ToString();                    
                    break;

                case '*':
                    double result_multip = first * second;
                    result = result_multip.ToString();                    
                    break;   
                    
                case '/':
                        switch (second)
                        {
                        case 0:
                            result="На 0 делить нельзя";
                            break;
                        default:
                            double result_divide = first / second;
                            result = result_divide.ToString();
                            break;
                        }                          
                    break;                   
            }
            TxtResult.Text = result;
        }                
        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            TxtResult.Clear();
        }        
    }
}
