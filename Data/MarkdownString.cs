namespace blazor_erp.Data;

public class MarkdownString
{
    public string Text { get; private set; }

    public MarkdownString(string text)
    {
        Text = text;
    }

    // Additional methods for processing markdown can be added here
    public override string ToString() => Text;
}
