<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653971/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T150880)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Use Automatic Filter Row Without Special Symbols

When a user enters text that begins with the `_` or `%` symbol into the [Automatic Filter Row](https://docs.devexpress.com/WPF/6132/controls-and-libraries/data-grid/filtering-and-searching/automatic-filter-row), the `GridControl` switches the [AutoFilterCondition](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.AutoFilterCondition) property to `Contains` and uses the entered text without the first symbol as filter criteria.

To prevent this behavior, create a [TableView](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView) descendant and override the `CreateAutoFilterCriteria` method as demonstrated in this example.

![image](https://github.com/DevExpress-Examples/the-use-of-automatic-filter-row-without-special-symbols-t150880/assets/65009440/ad16ab25-1600-48f1-bde4-cc1948afeb5a)

## Files to Review

* [MainWindow.xaml](./CS/AutoFilterlRow/MainWindow.xaml)
* [MainWindow.xaml.cs](./CS/AutoFilterlRow/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/AutoFilterlRow/MainWindow.xaml.vb))

## Documentation

* [Automatic Filter Row](https://docs.devexpress.com/WPF/6132/controls-and-libraries/data-grid/filtering-and-searching/automatic-filter-row)
* [Filtering and Searching](https://docs.devexpress.com/WPF/7356/controls-and-libraries/data-grid/filtering-and-searching)

## More Examples

* [WPF Data Grid - Allow Case Sensitive Filtering](https://github.com/DevExpress-Examples/how-to-perform-case-sensitive-filtering-e3349)
* [WPF Data Grid - Apply a Custom Filter Condition](https://github.com/DevExpress-Examples/wpf-data-grid-implement-custom-filtering)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-use-automatic-filter-row-without-special-symbols&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-use-automatic-filter-row-without-special-symbols&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
