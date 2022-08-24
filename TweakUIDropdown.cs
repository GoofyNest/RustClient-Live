public class TweakUIDropdown : TweakUIBase // TypeDefIndex: 11140
{
	public Button Left; 
	public Button Right; 
	public TextMeshProUGUI Current; 
	public Image BackgroundImage; 
	public TweakUIDropdown.NameValue[] nameValues; 
	public bool assignImageColor; 
	public int currentValue; 


	protected override void Init() { }

	protected void OnEnable() { }

	public void OnValueChanged() { }

	public void ChangeValue(int change) { }

	protected override void SetConvarValue() { }

	public override void ResetToConvar() { }

	private void ShowValue(string value) { }

	public void .ctor() { }

}

public class TweakUIDropdown.NameValue // TypeDefIndex: 11141
{
	public string value; 
	public Color imageColor; 
	public Translate.Phrase label; 


	public void .ctor() { }

}

