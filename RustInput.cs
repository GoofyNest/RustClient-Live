public class RustInput : RustControl // TypeDefIndex: 7057
{
	public TMP_InputField InputField; 
	public Image Background; 
	public RustInput.ChangedEvent OnValueChanged; 
	public RustInput.ChangedEvent OnEndEdit; 
	public RustInput.ChangedEvent OnSubmit; 

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

	[CompilerGeneratedAttribute] 
	private void <Awake>b__15_0(string x) { }

	[CompilerGeneratedAttribute] 
	private void <Awake>b__15_1(string x) { }

	[CompilerGeneratedAttribute] 
	private void <Awake>b__15_2(string x) { }

	[CompilerGeneratedAttribute] 
	private void <Awake>b__15_3(string x) { }

	[CompilerGeneratedAttribute] 
	private void <Awake>b__15_4(string x) { }

}

public class RustInput.ChangedEvent : UnityEvent<string> // TypeDefIndex: 7058
{

	public void .ctor() { }

}

