public class RustText : TextMeshProUGUI, ILocalize // TypeDefIndex: 7033
{	public bool IsLocalized; // 0xB80
	public string Token; // 0xB88
	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string English; // 0xB90
	public Translate.Phrase Phrase; // 0xB98
	[FormerlySerializedAsAttribute] // RVA: 0x721A0 Offset: 0x715A0 VA: 0x1800721A0
	public bool AutoSetWidth; // 0xBA0
	public bool AutoSetHeight; // 0xBA1
	public bool AutoSizeParent; // 0xBA2
	public float MinWidth; // 0xBA4
	public float MaxWidth; // 0xBA8
	private object[] localizationArguments; // 0xBB0

	public string LanguageToken { get; }
	public string LanguageEnglish { get; }


	public string get_LanguageToken() { }

	public string get_LanguageEnglish() { }

	public void SetPhrase(Translate.Phrase phrase) { }

	protected override void Awake() { }

	public void SetPhraseArguments(object[] args) { }

	public void SetText(string str) { }

	public void DoAutoSize() { }

	public override void Rebuild(CanvasUpdate update) { }

	private string GetLocalizedText(bool englishVersion) { }

	private void UpdateLocalizedText(bool forceEnglish) { }

	public static void OnLanguageChanged() { }

	public void .ctor() { }

}

