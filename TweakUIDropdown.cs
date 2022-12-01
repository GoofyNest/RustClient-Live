public class TweakUIDropdown : TweakUIBase // TypeDefIndex: 12934
{
	public RustText Current;
	public Image BackgroundImage;
	public RustButton Opener;
	public RectTransform Dropdown;
	public RectTransform DropdownContainer;
	public GameObject DropdownItemPrefab;
	public TweakUIDropdown.NameValue[] nameValues;
	public bool assignImageColor;
	public UnityEvent onValueChanged;
	public int currentValue;


	protected override void Init() { }

	protected void OnEnable() { }

	public void UpdateDropdownOptions() { }

	public void OnValueChanged() { }

	public void OnDropdownOpen() { }

	public void ChangeValue(int index) { }

	protected override void SetConvarValue() { }

	public override void ResetToConvar() { }

	private void ShowValue(string value) { }

	public void .ctor() { }

}

public class TweakUIDropdown.NameValue // TypeDefIndex: 12935
{
	public string value;
	public Color imageColor;
	public Translate.Phrase label;


	public void .ctor() { }

}

private sealed class TweakUIDropdown.<>c__DisplayClass13_0 // TypeDefIndex: 12936
{
	public int itemIndex;
	public TweakUIDropdown <>4__this;


	public void .ctor() { }

	internal void <UpdateDropdownOptions>

}

