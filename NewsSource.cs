public class NewsSource : MonoBehaviour // TypeDefIndex: 11125
{	// Fields
	private static readonly Regex BbcodeParse; // 0x0
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

	// Methods

	// RVA: 0xA35220 Offset: 0xA34620 VA: 0x180A35220
	public void Awake() { }

	// RVA: 0xA35380 Offset: 0xA34780 VA: 0x180A35380
	public void OnEnable() { }

	// RVA: 0xA35E90 Offset: 0xA35290 VA: 0x180A35E90
	public void SetStory(SteamNewsSource.Story story) { }

	// RVA: 0xA35410 Offset: 0xA34810 VA: 0x180A35410
	private void ParseBbcode(StringBuilder currentParagraph, string bbcode, ref string firstImage, int depth = 0) { }

	// RVA: 0xA35270 Offset: 0xA34670 VA: 0x180A35270
	private static string[] GetBulletPoints(string listContent) { }

	// RVA: 0xA34FC0 Offset: 0xA343C0 VA: 0x180A34FC0
	private void AppendParagraph(StringBuilder currentParagraph) { }

	// RVA: 0xA34F00 Offset: 0xA34300 VA: 0x180A34F00
	private void AppendImage(StringBuilder currentParagraph, string url) { }

	// RVA: 0xA350A0 Offset: 0xA344A0 VA: 0x180A350A0
	private void AppendYouTube(StringBuilder currentParagraph, string videoId) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0xA360D0 Offset: 0xA354D0 VA: 0x180A360D0
	private static void .cctor() { }

}

private sealed class NewsSource.<>c__DisplayClass12_0 // TypeDefIndex: 11126
{	// Fields
	public SteamNewsSource.Story story; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA4FCB0 Offset: 0xA4F0B0 VA: 0x180A4FCB0
	internal void <SetStory>b__0() { }

}

private sealed class NewsSource.<>c__DisplayClass18_0 // TypeDefIndex: 11127
{	// Fields
	public string videoUrl; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA4FD30 Offset: 0xA4F130 VA: 0x180A4FD30
	internal void <AppendYouTube>b__0() { }

}

