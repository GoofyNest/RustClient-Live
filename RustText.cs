public class RustText : TextMeshProUGUI, ILocalize // TypeDefIndex: 7033
{	// Fields
	public bool IsLocalized; // 0xB80
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

	// Properties
	public string LanguageToken { get; }
	public string LanguageEnglish { get; }

	// Methods

	// RVA: 0xFCB3A0 Offset: 0xFCA7A0 VA: 0x180FCB3A0 Slot: 135
	public string get_LanguageToken() { }

	// RVA: 0xFCB390 Offset: 0xFCA790 VA: 0x180FCB390 Slot: 136
	public string get_LanguageEnglish() { }

	// RVA: 0xFCB190 Offset: 0xFCA590 VA: 0x180FCB190
	public void SetPhrase(Translate.Phrase phrase) { }

	// RVA: 0xFCA960 Offset: 0xFC9D60 VA: 0x180FCA960 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFCB160 Offset: 0xFCA560 VA: 0x180FCB160
	public void SetPhraseArguments(object[] args) { }

	// RVA: 0xFCB210 Offset: 0xFCA610 VA: 0x180FCB210
	public void SetText(string str) { }

	// RVA: 0xFCA990 Offset: 0xFC9D90 VA: 0x180FCA990
	public void DoAutoSize() { }

	// RVA: 0xFCB0E0 Offset: 0xFCA4E0 VA: 0x180FCB0E0 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0xFCAF20 Offset: 0xFCA320 VA: 0x180FCAF20
	private string GetLocalizedText(bool englishVersion) { }

	// RVA: 0xFCB240 Offset: 0xFCA640 VA: 0x180FCB240
	private void UpdateLocalizedText(bool forceEnglish) { }

	// RVA: 0xFCB050 Offset: 0xFCA450 VA: 0x180FCB050
	public static void OnLanguageChanged() { }

	// RVA: 0xFCB370 Offset: 0xFCA770 VA: 0x180FCB370
	public void .ctor() { }

}

