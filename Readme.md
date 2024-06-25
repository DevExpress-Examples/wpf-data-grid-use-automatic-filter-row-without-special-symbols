<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653971/14.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T150880)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-use-automatic-filter-row-without-special-symbols&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-use-automatic-filter-row-without-special-symbols&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
