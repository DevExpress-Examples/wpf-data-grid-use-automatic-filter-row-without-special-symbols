<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/AutoFilterlRow/Data.cs) (VB: [Data.vb](./VB/AutoFilterlRow/Data.vb))
* [MainWindow.xaml](./CS/AutoFilterlRow/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/AutoFilterlRow/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/AutoFilterlRow/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/AutoFilterlRow/MainWindow.xaml.vb))**
<!-- default file list end -->
# The use of Automatic Filter Row without special symbols


<p>When an end-user enters text into the AutoFilterRow for filtering that begins with '_' or '%', <strong>GridControl </strong>automatically replaces the AutoFilterCondition with "Contains" and uses the entered text without the first symbol as filter criteria.<br />To avoid this, it is necessary to create a TableView child and override the CreateAutoFilterCriteria method.</p>

<br/>


