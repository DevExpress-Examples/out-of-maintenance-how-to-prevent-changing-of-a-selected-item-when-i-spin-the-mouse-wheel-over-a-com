<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to prevent changing of a selected item when I spin the mouse wheel over a ComboBox


<p>Please handle the RepositoryItem.MouseWheel event, typecast the e argument to DXMouseEventArgs and set the DXMouseEventArgs.Handled property to True.</p>

<br/>


