<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653971/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T150880)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/AutoFilterlRow/Data.cs) (VB: [Data.vb](./VB/AutoFilterlRow/Data.vb))
* [MainWindow.xaml](./CS/AutoFilterlRow/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/AutoFilterlRow/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/AutoFilterlRow/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/AutoFilterlRow/MainWindow.xaml.vb))**
<!-- default file list end -->
# The use of Automatic Filter Row without special symbols


<p>When an end-user enters text into the AutoFilterRow for filtering that begins with '_' or '%', <strong>GridControl </strong>automatically replaces the AutoFilterCondition with "Contains" and uses the entered text without the first symbol as filter criteria.<br />To avoid this, it is necessary to create a TableView child and override the CreateAutoFilterCriteria method.</p>

<br/>


