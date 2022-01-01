using EditorJs.Blazor.Models;
using Microsoft.JSInterop;

namespace EditorJs.Blazor;

public class EditorJsInterop : IAsyncDisposable
{
    
    private readonly Lazy<Task<IJSObjectReference>> _editorJsModuleTask;

    public EditorJsInterop(IJSRuntime jsRuntime)
    {
        _editorJsModuleTask = new (() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/EditorJs.Blazor/editorManager.js").AsTask());
    }

    public async ValueTask<EditorJsModel> CreateEditor(EditorJsModel model)
    {
        var caller = await _editorJsModuleTask.Value;
        return await caller.InvokeAsync<EditorJsModel>("createEditor", model);
    }
    public async ValueTask DisposeAsync()
    {
        if (_editorJsModuleTask.IsValueCreated)
        {
            var module = await _editorJsModuleTask.Value;
            await module.DisposeAsync();
        }
    }
}