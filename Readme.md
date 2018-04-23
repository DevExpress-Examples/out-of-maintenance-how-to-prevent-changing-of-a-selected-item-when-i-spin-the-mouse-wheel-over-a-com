# How to prevent changing of a selected item when I spin the mouse wheel over a ComboBox


<p>Please handle the RepositoryItem.MouseWheel event, typecast the e argument to DXMouseEventArgs and set the DXMouseEventArgs.Handled property to True.</p>

<br/>


