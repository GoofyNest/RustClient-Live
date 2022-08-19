public class TweakUIDropdown : TweakUIBase // TypeDefIndex: 11140
{	// Fields
	public Button Left; // 0x30
	public Button Right; // 0x38
	public TextMeshProUGUI Current; // 0x40
	public Image BackgroundImage; // 0x48
	public TweakUIDropdown.NameValue[] nameValues; // 0x50
	public bool assignImageColor; // 0x58
	public int currentValue; // 0x5C

	// Methods

	// RVA: 0x4D0C80 Offset: 0x4D0080 VA: 0x1804D0C80 Slot: 4
	protected override void Init() { }

	// RVA: 0x4BF5F0 Offset: 0x4BE9F0 VA: 0x1804BF5F0
	protected void OnEnable() { }

	// RVA: 0x4D0CB0 Offset: 0x4D00B0 VA: 0x1804D0CB0
	public void OnValueChanged() { }

	// RVA: 0x4D0BA0 Offset: 0x4CFFA0 VA: 0x1804D0BA0
	public void ChangeValue(int change) { }

	// RVA: 0x4D0D10 Offset: 0x4D0110 VA: 0x1804D0D10 Slot: 9
	protected override void SetConvarValue() { }

	// RVA: 0x4D0CD0 Offset: 0x4D00D0 VA: 0x1804D0CD0 Slot: 8
	public override void ResetToConvar() { }

	// RVA: 0x4D0DA0 Offset: 0x4D01A0 VA: 0x1804D0DA0
	private void ShowValue(string value) { }

	// RVA: 0x4D0B50 Offset: 0x4CFF50 VA: 0x1804D0B50
	public void .ctor() { }

}

public class TweakUIDropdown.NameValue // TypeDefIndex: 11141
{	// Fields
	public string value; // 0x10
	public Color imageColor; // 0x18
	public Translate.Phrase label; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

