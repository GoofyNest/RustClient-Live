public class TweakUIDropdown : TweakUIBase // TypeDefIndex: 11140
{	public Button Left; // 0x30
	public Button Right; // 0x38
	public TextMeshProUGUI Current; // 0x40
	public Image BackgroundImage; // 0x48
	public TweakUIDropdown.NameValue[] nameValues; // 0x50
	public bool assignImageColor; // 0x58
	public int currentValue; // 0x5C


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
{	public string value; // 0x10
	public Color imageColor; // 0x18
	public Translate.Phrase label; // 0x28


	public void .ctor() { }

}

