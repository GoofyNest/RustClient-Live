public class NewsSource : MonoBehaviour // TypeDefIndex: 11125
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

	private void ParseBbcode(StringBuilder currentParagraph, string bbcode, ref string firstImage, int depth = 0) { }

	private static string[] GetBulletPoints(string listContent) { }

	private void AppendParagraph(StringBuilder currentParagraph) { }

	private void AppendImage(StringBuilder currentParagraph, string url) { }

	private void AppendYouTube(StringBuilder currentParagraph, string videoId) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class NewsSource.<>c__DisplayClass12_0 // TypeDefIndex: 11126
{
	public SteamNewsSource.Story story; 


	public void .ctor() { }

	internal void <SetStory>b__0() { }

}

private sealed class NewsSource.<>c__DisplayClass18_0 // TypeDefIndex: 11127
{
	public string videoUrl; 


	public void .ctor() { }

	internal void <AppendYouTube>b__0() { }

}

