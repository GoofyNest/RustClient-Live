public class RustButtonGroup : RustControl // TypeDefIndex: 7014
{	public Option[] Options; // 0x30
	public string ButtonStyle; // 0x38
	private int CurrentOption; // 0x40
	public RustButtonGroup.ChangedEvent OnChanged; // 0x48

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

public class RustButtonGroup.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7015
{
	public void .ctor() { }

}

private sealed class RustButtonGroup.<>c__DisplayClass12_0 // TypeDefIndex: 7016
{	public int buttonNumber; // 0x10
	public RustButtonGroup <>4__this; // 0x18


	public void .ctor() { }

	internal void <BuildContents>b__0() { }

}

