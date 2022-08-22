public class RustOption : RustControl // TypeDefIndex: 7025
{	public RustButton Left; // 0x30
	public RustButton Right; // 0x38
	public RustText Text; // 0x40
	public Option[] Options; // 0x48
	private int CurrentOption; // 0x50
	public RustOption.ChangedEvent OnChanged; // 0x58

	public Option Value { get; }


	public Option get_Value() { }

	protected override void Awake() { }

	public void SetOptions(Option[] options) { }

	public void SetOption(int i) { }

	public void SetOptionDefault() { }

	public void OnLeft() { }

	public void OnRight() { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public void .ctor() { }

}

public class RustOption.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7026
{
	public void .ctor() { }

}

