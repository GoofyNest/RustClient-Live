public class RustButtonGroup : RustControl // TypeDefIndex: 7014
{	// Fields
	public Option[] Options; // 0x30
	public string ButtonStyle; // 0x38
	private int CurrentOption; // 0x40
	public RustButtonGroup.ChangedEvent OnChanged; // 0x48

	// Properties
	public Option Value { get; }

	// Methods

	// RVA: 0xFC5470 Offset: 0xFC4870 VA: 0x180FC5470
	public Option get_Value() { }

	// RVA: 0xFC4E80 Offset: 0xFC4280 VA: 0x180FC4E80 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFC52F0 Offset: 0xFC46F0 VA: 0x180FC52F0
	public void SetOption(int i) { }

	// RVA: 0xFC5250 Offset: 0xFC4650 VA: 0x180FC5250
	public void SetOption(string value) { }

	// RVA: 0xFC5130 Offset: 0xFC4530 VA: 0x180FC5130
	private void ButtonPressed(int i) { }

	// RVA: 0xFC51E0 Offset: 0xFC45E0 VA: 0x180FC51E0
	public void SetOptionDefault() { }

	// RVA: 0xFC4EA0 Offset: 0xFC42A0 VA: 0x180FC4EA0
	public void BuildContents() { }

	// RVA: 0xFC5400 Offset: 0xFC4800 VA: 0x180FC5400
	public void .ctor() { }

}

public class RustButtonGroup.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7015
{	// Methods

	// RVA: 0xFB8F30 Offset: 0xFB8330 VA: 0x180FB8F30
	public void .ctor() { }

}

private sealed class RustButtonGroup.<>c__DisplayClass12_0 // TypeDefIndex: 7016
{	// Fields
	public int buttonNumber; // 0x10
	public RustButtonGroup <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD35A0 Offset: 0xFD29A0 VA: 0x180FD35A0
	internal void <BuildContents>b__0() { }

}

