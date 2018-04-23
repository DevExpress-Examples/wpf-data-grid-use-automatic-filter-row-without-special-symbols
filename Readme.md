# The use of Automatic Filter Row without special symbols


<p>When an end-user enters text into the AutoFilterRow for filtering that begins with '_' or '%', <strong>GridControl </strong>automatically replaces the AutoFilterCondition with "Contains" and uses the entered text without the first symbol as filter criteria.<br />To avoid this, it is necessary to create a TableView child and override the CreateAutoFilterCriteria method.</p>

<br/>


