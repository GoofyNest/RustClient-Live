public class Menu : RustControl // TypeDefIndex: 7008
{	public bool AllowFiltering; // 0x30
	public int MaxResults; // 0x34
	public Image Border; // 0x38
	public Image Background; // 0x40
	public Option[] Options; // 0x48
	public RectTransform OptionCanvas; // 0x50
	public RustInput FilterField; // 0x58
	public Option SelectedOption; // 0x60
	public Menu.ChangedEvent OnSelected; // 0x80
	public Blocker Blocker; // 0x88


	protected override void Awake() { }

	public void Build() { }

	private void OnOptionSelected(Option option) { }

	private IEnumerable<Option> GetOptions() { }

	internal void Popup(RectTransform source) { }

	private void RestrainToScreen() { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Awake>b__11_0(string x) { }

}

public class Menu.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7009
{
	public void .ctor() { }

}

private sealed class Menu.<>c__DisplayClass12_0 // TypeDefIndex: 7010
{	public Option option; // 0x10
	public Menu <>4__this; // 0x30


	public void .ctor() { }

	internal void <Build>b__0() { }

}

private sealed class Menu.<>c__DisplayClass14_0 // TypeDefIndex: 7011
{	public string searchString; // 0x10


	public void .ctor() { }

	internal bool <GetOptions>b__1(Option x) { }

}

private sealed class Menu.<>c // TypeDefIndex: 7012
{	public static readonly Menu.<>c <>9; // 0x0
	public static Func<Option, Option> <>9__14_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal Option <GetOptions>b__14_0(Option x) { }

}

