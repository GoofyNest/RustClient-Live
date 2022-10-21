public class RustText : TextMeshProUGUI, ILocalize // TypeDefIndex: 7069
{
	public bool IsLocalized; 
	public string Token; 
	[TextAreaAttribute] 
	public string English; 
	public Translate.Phrase Phrase; 
	[FormerlySerializedAsAttribute] 
	public bool AutoSetWidth; 
	public bool AutoSetHeight; 
	public bool AutoSizeParent; 
	public float MinWidth; 
	public float MaxWidth; 
	private object[] localizationArguments; 

	public string LanguageToken { get; }
	public string LanguageEnglish { get; }


	public string get_LanguageToken() { }

	public string get_LanguageEnglish() { }

	public void SetPhrase(Translate.Phrase phrase) { }

	protected override void Awake() { }

	public void SetPhraseArguments(object[] args) { }

	public void SetText(string str) { }

	public virtual void DoAutoSize() { }

	public override void Rebuild(CanvasUpdate update) { }

	private string GetLocalizedText(bool englishVersion) { }

	private void UpdateLocalizedText(bool forceEnglish) { }

	public static void OnLanguageChanged() { }

	public void .ctor() { }

}

