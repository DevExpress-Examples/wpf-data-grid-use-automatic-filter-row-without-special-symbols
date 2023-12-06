using DevExpress.Data.Filtering;
using DevExpress.Xpf.Grid;
using System.Windows;

namespace AutoFilterlRow {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            grid1.ItemsSource = Data.GetData();
        }
    }

    public class NewTableView : TableView {
        protected override CriteriaOperator CreateAutoFilterCriteria(string fieldName, AutoFilterCondition condition, object value) {
            if (condition == AutoFilterCondition.Equals) {
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
