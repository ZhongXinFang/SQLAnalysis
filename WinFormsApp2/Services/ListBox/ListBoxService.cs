namespace MainForm.Services.ListBox;
internal class ListBoxService
{
    public List<ListBoxModel> Data { get; set; } = new();

    public void Add(ListBoxModel d)
    {
        Data.Insert(0, d);
    }
}
