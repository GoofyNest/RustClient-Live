public class RustButtonGroup : RustControl // TypeDefIndex: 7057
{
	public Option[] Options;
	public string ButtonStyle;
	private int CurrentOption;
	public RustButtonGroup.ChangedEvent OnChanged;

	public Option Value { get; }


	public Option get_Value() { }

	protected override void Awake() { }

	public void SetOption(int i) { }

	public void SetOption(string value) { }

	private void ButtonPressed(int i) { }

	public void SetOptionDefault() { }

	public void BuildContents() { }

	public void .ctor() { }

}

public class RustButtonGroup.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7058
{

	public void .ctor() { }

}

private sealed class RustButtonGroup.<>c__DisplayClass12_0 // TypeDefIndex: 7059
{
	public int buttonNumber;
	public RustButtonGroup <>4__this;


	public void .ctor() { }

	internal void <BuildContents>

}

