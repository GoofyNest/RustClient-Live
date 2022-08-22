public class RustInput : RustControl // TypeDefIndex: 7021
{	public TMP_InputField InputField; // 0x30
	public Image Background; // 0x38
	public RustInput.ChangedEvent OnValueChanged; // 0x40
	public RustInput.ChangedEvent OnEndEdit; // 0x48
	public RustInput.ChangedEvent OnSubmit; // 0x50

	public RustText Placeholder { get; }
	public bool IsFocused { get; }
	public string Value { get; }
	public string Text { get; set; }
	public override StyleAsset.Group CurrentStyleCollection { get; }


	public RustText get_Placeholder() { }

	public bool get_IsFocused() { }

	public string get_Value() { }

	public string get_Text() { }

	public void set_Text(string value) { }

	protected override void Awake() { }

	public override StyleAsset.Group get_CurrentStyleCollection() { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Awake>b__15_0(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Awake>b__15_1(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Awake>b__15_2(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Awake>b__15_3(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Awake>b__15_4(string x) { }

}

public class RustInput.ChangedEvent : UnityEvent<string> // TypeDefIndex: 7022
{
	public void .ctor() { }

}

