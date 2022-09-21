using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Drawing;
using System.Threading.Tasks;

public class BrowserService
{
    private readonly IJSRuntime _js;

    public BrowserService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task<BrowserDimension> GetDimensions()
    {
        return await _js.InvokeAsync<BrowserDimension>("getDimensions");
    }

    public async Task<BrowserAndElementDimension> GetBrowserAndElementDimensionsAsync(ElementReference el1, ElementReference el2)
    {
        return await _js.InvokeAsync<BrowserAndElementDimension>("getBrowserAndElementDimensions", el1, el2);
    }
}

public class BrowserDimension
{
    public int Width { get; set; }
    public int Height { get; set; }
}
public class BrowserAndElementDimension
{
    public int BrowserWidth { get; set; }
    public int BrowserHeight { get; set; }

    public float ElementTop { get; set; }
    public float ElementBot { get; set; }
    public float ElementLeft { get; set; }
    public float ElementRight { get; set; }

    public float ElementHeight2 { get; set; }
}
