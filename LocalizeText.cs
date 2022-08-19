public class LocalizeText : MonoBehaviour, IClientComponent, ILocalize // TypeDefIndex: 11272
{	// Fields
	public string token; // 0x18
	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string english; // 0x20
	public string append; // 0x28
	public LocalizeText.SpecialMode specialMode; // 0x30
	private object[] Tokens; // 0x38

	// Properties
	public string LanguageToken { get; set; }
	public string LanguageEnglish { get; set; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	public string get_LanguageToken() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_LanguageToken(string value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 5
	public string get_LanguageEnglish() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_LanguageEnglish(string value) { }

	// RVA: 0x4FB160 Offset: 0x4FA560 VA: 0x1804FB160
	private string GetText(bool englishVersion) { }

	// RVA: 0x4FB150 Offset: 0x4FA550 VA: 0x1804FB150
	private void Awake() { }

	// RVA: 0x4FB150 Offset: 0x4FA550 VA: 0x1804FB150
	public void RebuildText() { }

	// RVA: 0x4FB890 Offset: 0x4FAC90 VA: 0x1804FB890
	private void UpdateText(bool forceEnglish) { }

	// RVA: 0x4FB310 Offset: 0x4FA710 VA: 0x1804FB310
	public void SetToken(int i, object token) { }

	// RVA: 0x4FB5B0 Offset: 0x4FA9B0 VA: 0x1804FB5B0
	public void SetTokens(object[] tokens) { }

	// RVA: 0x4FB280 Offset: 0x4FA680 VA: 0x1804FB280
	public static void OnLanguageChanged() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public enum LocalizeText.SpecialMode // TypeDefIndex: 11273
{	// Fields
	public int value__; // 0x0
	public const LocalizeText.SpecialMode None = 0;
	public const LocalizeText.SpecialMode AllUppercase = 1;
	public const LocalizeText.SpecialMode AllLowercase = 2;

}

