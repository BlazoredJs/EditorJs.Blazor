namespace EditorJs.Blazor.Models;

public class EditorJsModel
{
    public string HolderId { get; set; }
    public EditorToolsModel Tools { get; set; }
    public string Data { get; set; }
    public bool AutoFocus { get; set; } = true;
}

public class EditorToolsModel
{
    public EditorHeaderModel Header { get; set; }
}

public class EditorHeaderModel
{
    public string Class { get; set; }
    public bool InlineToolbar { get; set; }
}