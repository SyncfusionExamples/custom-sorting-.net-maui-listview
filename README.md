# Custom sorting with .Net MAUI ListView (SfListView)
This example describes how to custom sorting with .Net MAUI ListView (SfListView).

## Sample

```xaml
<ContentPage.Resources>
    <ResourceDictionary>
      <local:CustomSortComparer x:Key="CustomSortComparer" />
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfListView x:Name="listView"
                    ItemSize="70" Margin="0,10,0,0"
                    ItemsSource="{Binding ContactsInfo}">

    <syncfusion:SfListView.DataSource>
        <data:DataSource>
            <data:DataSource.SortDescriptors>
                <data:SortDescriptor Comparer="{StaticResource CustomSortComparer}"/>
            </data:DataSource.SortDescriptors>
        </data:DataSource>
    </syncfusion:SfListView.DataSource>

    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>

C# :

public class CustomSortComparer : IComparer<object>
{
    public int Compare(object x, object y)
    {
        if (x.GetType() == typeof(ListViewContactsInfo))
        {
            var xitem = (x as ListViewContactsInfo).ContactName;
            var yitem = (y as ListViewContactsInfo).ContactName;

            if (xitem.Length > yitem.Length)
            {
                return 1;
            }
            else if (xitem.Length < yitem.Length)
            {
                return -1;
            }
            else
            {
                if (string.Compare(xitem, yitem) == -1)
                    return -1;
                else if (string.Compare(xitem, yitem) == 1)
                    return 1;
            }
        }

        return 0;
    }
}
```
