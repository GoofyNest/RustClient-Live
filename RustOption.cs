public class RustOption : RustControl // TypeDefIndex: 7065
{
	public RustButton Left; 
	public RustButton Right; 
	public RustText Text; 
	public Option[] Options; 
	private int CurrentOption; 
	public RustOption.ChangedEvent OnChanged; 

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

public class RustOption.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7066
{

	public void .ctor() { }

}

