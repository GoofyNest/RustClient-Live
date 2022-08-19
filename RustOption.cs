public class RustOption : RustControl // TypeDefIndex: 7025
{	// Fields
	public RustButton Left; // 0x30
	public RustButton Right; // 0x38
	public RustText Text; // 0x40
	public Option[] Options; // 0x48
	private int CurrentOption; // 0x50
	public RustOption.ChangedEvent OnChanged; // 0x58

	// Properties
	public Option Value { get; }

	// Methods

	// RVA: 0xFB9CB0 Offset: 0xFB90B0 VA: 0x180FB9CB0
	public Option get_Value() { }

	// RVA: 0xFC96C0 Offset: 0xFC8AC0 VA: 0x180FC96C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFC9A30 Offset: 0xFC8E30 VA: 0x180FC9A30
	public void SetOptions(Option[] options) { }

	// RVA: 0xFC99B0 Offset: 0xFC8DB0 VA: 0x180FC99B0
	public void SetOption(int i) { }

	// RVA: 0xFC9950 Offset: 0xFC8D50 VA: 0x180FC9950
	public void SetOptionDefault() { }

	// RVA: 0xFC97A0 Offset: 0xFC8BA0 VA: 0x180FC97A0
	public void OnLeft() { }

	// RVA: 0xFC9840 Offset: 0xFC8C40 VA: 0x180FC9840
	public void OnRight() { }

	// RVA: 0xFC95A0 Offset: 0xFC89A0 VA: 0x180FC95A0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFC9AB0 Offset: 0xFC8EB0 VA: 0x180FC9AB0
	public void .ctor() { }

}

public class RustOption.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7026
{	// Methods

	// RVA: 0xFB8DF0 Offset: 0xFB81F0 VA: 0x180FB8DF0
	public void .ctor() { }

}

