public class NewsSource : MonoBehaviour // TypeDefIndex: 12917
{
	private static readonly Regex BbcodeParse;
	public RustText title;
	public RustText date;
	public RustText authorName;
	public HttpImage coverImage;
	public RectTransform container;
	public Button button;
	public RustText paragraphTemplate;
	public HttpImage imageTemplate;
	public HttpImage youtubeTemplate;
	private static readonly string[] BulletSeparators;


	public void Awake() { }

	public void OnEnable() { }

	public void SetStory(SteamNewsSource.Story story) { }

	private void ParseBbcode(ref NewsSource.ParagraphBuilder currentParagraph, string bbcode, ref string firstImage, int depth = 0) { }

	private static string[] GetBulletPoints(string listContent) { }

	private void AppendParagraph(ref NewsSource.ParagraphBuilder currentParagraph) { }

	private void AppendImage(ref NewsSource.ParagraphBuilder currentParagraph, string url) { }

	private void AppendYouTube(ref NewsSource.ParagraphBuilder currentParagraph, string videoId) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct NewsSource.ParagraphBuilder // TypeDefIndex: 12918
{
	public StringBuilder StringBuilder;
	public List<string> Links;


	public static NewsSource.ParagraphBuilder New() { }

	public void AppendLine() { }

	public void Append(string text) { }

}

private sealed class NewsSource.<>c__DisplayClass12_0 // TypeDefIndex: 12919
{
	public SteamNewsSource.Story story;


	public void .ctor() { }

	internal void <SetStory>

	internal Manifest.NewsInfo.BlogInfo <SetStory>g__GetBlogPost|1() { }

}

private sealed class NewsSource.<>c // TypeDefIndex: 12920
{
	public static readonly NewsSource.<>c <>9;
	public static Func<Manifest.NewsInfo.BlogInfo, string> <>9__12_2;


	private static void .cctor() { }

	public void .ctor() { }

	internal string <SetStory>

}

private sealed class NewsSource.<>c__DisplayClass18_0 // TypeDefIndex: 12921
{
	public string videoUrl;


	public void .ctor() { }

	internal void <AppendYouTube>

}

