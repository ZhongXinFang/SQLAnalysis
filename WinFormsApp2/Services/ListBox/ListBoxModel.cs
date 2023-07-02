namespace MainForm.Services.ListBox;
internal class ListBoxModel
{
    public ListBoxModel(string? name = null)
    {
        Id = Guid.NewGuid();
        Name = (name is null || string.IsNullOrWhiteSpace(name)) ? CreateDateTime.ToString("yy-MM-dd-HH-mm-ss-fff") : name;
    }

    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime CreateDateTime { get; init; } = DateTime.Now;

    public string OriginalSQL { get; set; } = null!;
    public string NewSQL { get; set; } = null!;
}
