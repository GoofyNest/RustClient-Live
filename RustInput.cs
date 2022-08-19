public class RustInput : RustControl // TypeDefIndex: 7021
{	// Fields
	public TMP_InputField InputField; // 0x30
	public Image Background; // 0x38
	public RustInput.ChangedEvent OnValueChanged; // 0x40
	public RustInput.ChangedEvent OnEndEdit; // 0x48
	public RustInput.ChangedEvent OnSubmit; // 0x50

	// Properties
	public RustText Placeholder { get; }
	public bool IsFocused { get; }
	public string Value { get; }
	public string Text { get; set; }
	public override StyleAsset.Group CurrentStyleCollection { get; }

	// Methods

	// RVA: 0xFC7F20 Offset: 0xFC7320 VA: 0x180FC7F20
	public RustText get_Placeholder() { }

	// RVA: 0xFC7F00 Offset: 0xFC7300 VA: 0x180FC7F00
	public bool get_IsFocused() { }

	// RVA: 0xFC7FB0 Offset: 0xFC73B0 VA: 0x180FC7FB0
	public string get_Value() { }

	// RVA: 0xFC7FB0 Offset: 0xFC73B0 VA: 0x180FC7FB0
	public string get_Text() { }

	// RVA: 0xFC7FD0 Offset: 0xFC73D0 VA: 0x180FC7FD0
	public void set_Text(string value) { }

	// RVA: 0xFC79C0 Offset: 0xFC6DC0 VA: 0x180FC79C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFC7D60 Offset: 0xFC7160 VA: 0x180FC7D60 Slot: 28
	public override StyleAsset.Group get_CurrentStyleCollection() { }

	// RVA: 0xFC77A0 Offset: 0xFC6BA0 VA: 0x180FC77A0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFC7D00 Offset: 0xFC7100 VA: 0x180FC7D00
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC7BC0 Offset: 0xFC6FC0 VA: 0x180FC7BC0
	private void <Awake>b__15_0(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC7C20 Offset: 0xFC7020 VA: 0x180FC7C20
	private void <Awake>b__15_1(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC7C80 Offset: 0xFC7080 VA: 0x180FC7C80
	private void <Awake>b__15_2(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC7CE0 Offset: 0xFC70E0 VA: 0x180FC7CE0
	private void <Awake>b__15_3(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC7CE0 Offset: 0xFC70E0 VA: 0x180FC7CE0
	private void <Awake>b__15_4(string x) { }

}

public class RustInput.ChangedEvent : UnityEvent<string> // TypeDefIndex: 7022
{	// Methods

	// RVA: 0xFB8E30 Offset: 0xFB8230 VA: 0x180FB8E30
	public void .ctor() { }

}

