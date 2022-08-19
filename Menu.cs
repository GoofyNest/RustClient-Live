public class Menu : RustControl // TypeDefIndex: 7008
{	// Fields
	public bool AllowFiltering; // 0x30
	public int MaxResults; // 0x34
	public Image Border; // 0x38
	public Image Background; // 0x40
	public Option[] Options; // 0x48
	public RectTransform OptionCanvas; // 0x50
	public RustInput FilterField; // 0x58
	public Option SelectedOption; // 0x60
	public Menu.ChangedEvent OnSelected; // 0x80
	public Blocker Blocker; // 0x88

	// Methods

	// RVA: 0xFBF2D0 Offset: 0xFBE6D0 VA: 0x180FBF2D0 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFBF370 Offset: 0xFBE770 VA: 0x180FBF370
	public void Build() { }

	// RVA: 0xFBFA20 Offset: 0xFBEE20 VA: 0x180FBFA20
	private void OnOptionSelected(Option option) { }

	// RVA: 0xFBF860 Offset: 0xFBEC60 VA: 0x180FBF860
	private IEnumerable<Option> GetOptions() { }

	// RVA: 0xFBFB20 Offset: 0xFBEF20 VA: 0x180FBFB20
	internal void Popup(RectTransform source) { }

	// RVA: 0xFC07B0 Offset: 0xFBFBB0 VA: 0x180FC07B0
	private void RestrainToScreen() { }

	// RVA: 0xFBF1C0 Offset: 0xFBE5C0 VA: 0x180FBF1C0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0xFC0B00 Offset: 0xFBFF00 VA: 0x180FC0B00
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC0AF0 Offset: 0xFBFEF0 VA: 0x180FC0AF0
	private void <Awake>b__11_0(string x) { }

}

public class Menu.ChangedEvent : UnityEvent<Option> // TypeDefIndex: 7009
{	// Methods

	// RVA: 0xFB8E70 Offset: 0xFB8270 VA: 0x180FB8E70
	public void .ctor() { }

}

private sealed class Menu.<>c__DisplayClass12_0 // TypeDefIndex: 7010
{	// Fields
	public Option option; // 0x10
	public Menu <>4__this; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3660 Offset: 0xFD2A60 VA: 0x180FD3660
	internal void <Build>b__0() { }

}

private sealed class Menu.<>c__DisplayClass14_0 // TypeDefIndex: 7011
{	// Fields
	public string searchString; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3A20 Offset: 0xFD2E20 VA: 0x180FD3A20
	internal bool <GetOptions>b__1(Option x) { }

}

private sealed class Menu.<>c // TypeDefIndex: 7012
{	// Fields
	public static readonly Menu.<>c <>9; // 0x0
	public static Func<Option, Option> <>9__14_0; // 0x8

	// Methods

	// RVA: 0xFD3F20 Offset: 0xFD3320 VA: 0x180FD3F20
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3300 Offset: 0xFD2700 VA: 0x180FD3300
	internal Option <GetOptions>b__14_0(Option x) { }

}

