public class NewsSource : MonoBehaviour // TypeDefIndex: 11125
{	private static readonly Regex BbcodeParse; // 0x0
	public RustText title; // 0x18
	public RustText date; // 0x20
	public RustText authorName; // 0x28
	public HttpImage coverImage; // 0x30
	public RectTransform container; // 0x38
	public Button button; // 0x40
	public RustText paragraphTemplate; // 0x48
	public HttpImage imageTemplate; // 0x50
	public HttpImage youtubeTemplate; // 0x58
	private static readonly string[] BulletSeparators; // 0x8


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
{	public SteamNewsSource.Story story; // 0x10


	public void .ctor() { }

	internal void <SetStory>b__0() { }

}

private sealed class NewsSource.<>c__DisplayClass18_0 // TypeDefIndex: 11127
{	public string videoUrl; // 0x10


	public void .ctor() { }

	internal void <AppendYouTube>b__0() { }

}

