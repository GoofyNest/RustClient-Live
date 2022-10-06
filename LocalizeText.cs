public class LocalizeText : MonoBehaviour, IClientComponent, ILocalize // TypeDefIndex: 13011
{
	public string token; 
	[TextAreaAttribute] 
	public string english; 
	public string append; 
	public LocalizeText.SpecialMode specialMode; 
	private object[] Tokens; 

	public string LanguageToken { get; set; }
	public string LanguageEnglish { get; set; }


	public string get_LanguageToken() { }

	public void set_LanguageToken(string value) { }

	public string get_LanguageEnglish() { }

	public void set_LanguageEnglish(string value) { }

	private string GetText(bool englishVersion) { }

	private void Awake() { }

	public void RebuildText() { }

	private void UpdateText(bool forceEnglish) { }

	public void SetToken(int i, object token) { }

	public void SetTokens(object[] tokens) { }

	public static void OnLanguageChanged() { }

	public void .ctor() { }

}

public enum LocalizeText.SpecialMode // TypeDefIndex: 13012
{
	public int value__; 
	public const LocalizeText.SpecialMode None = 0;
	public const LocalizeText.SpecialMode AllUppercase = 1;
	public const LocalizeText.SpecialMode AllLowercase = 2;

}

