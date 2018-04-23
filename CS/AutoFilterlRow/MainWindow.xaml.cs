using System;
using System.Collections.Generic;
using System.Linq;
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
using DevExpress.Xpf.Grid;
using DevExpress.Data.Filtering;

namespace AutoFilterlRow
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grid1.ItemsSource = Data.GetData();
        }
    }

    public class NewTableView : TableView
    {
        protected override CriteriaOperator CreateAutoFilterCriteria(string fieldName, AutoFilterCondition condition, object value)
        {
            if (condition == AutoFilterCondition.Equals)
            {
                return base.CreateAutoFilterCriteria(fieldName, condition, value);
            }
            string strValue = value.ToString();
            if (string.IsNullOrEmpty(strValue))
                return null;
            if (condition == AutoFilterCondition.Contains)
                return new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(fieldName), strValue);
            else
                return new FunctionOperator(FunctionOperatorType.StartsWith, new OperandProperty(fieldName), strValue);
        }
    }


}
