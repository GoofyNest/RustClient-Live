public class Properties // TypeDefIndex: 7055
{	// Fields
	private object Parent; // 0x10
	private RectTransform Canvas; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action UpdateControlsFromValues; // 0x20
	public List<FieldInfo> Fields; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsDirty>k__BackingField; // 0x30

	// Properties
	public bool IsDirty { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC39C0 Offset: 0xFC2DC0 VA: 0x180FC39C0
	public void add_UpdateControlsFromValues(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC3A60 Offset: 0xFC2E60 VA: 0x180FC3A60
	public void remove_UpdateControlsFromValues(Action value) { }

	// RVA: 0xFC3910 Offset: 0xFC2D10 VA: 0x180FC3910
	public void .ctor(object Parent, RectTransform Canvas) { }

	// RVA: 0xFC2260 Offset: 0xFC1660 VA: 0x180FC2260
	public void CreateControls() { }

	// RVA: 0xFC1A70 Offset: 0xFC0E70 VA: 0x180FC1A70
	private void AddControl(RustControl ctrl, LabelAttribute label) { }

	// RVA: 0xFC2060 Offset: 0xFC1460 VA: 0x180FC2060
	private bool CreateControl(FieldInfo f) { }

	// RVA: 0xFC26D0 Offset: 0xFC1AD0 VA: 0x180FC26D0
	private bool CreateReadOnlyControl(FieldInfo f) { }

	// RVA: 0xFC2A00 Offset: 0xFC1E00 VA: 0x180FC2A00
	private bool CreateStringControl(FieldInfo f) { }

	// RVA: 0xFC1D90 Offset: 0xFC1190 VA: 0x180FC1D90
	private bool CreateBooleanControl(FieldInfo f) { }

	// RVA: 0xFC2300 Offset: 0xFC1700 VA: 0x180FC2300
	private bool CreateNumericControl(FieldInfo f) { }

	// RVA: 0xFC38F0 Offset: 0xFC2CF0 VA: 0x180FC38F0
	public void SyncControls() { }

	// RVA: 0xFC2D50 Offset: 0xFC2150 VA: 0x180FC2D50
	public Dictionary<string, object> GetValues() { }

	// RVA: 0xFC3770 Offset: 0xFC2B70 VA: 0x180FC3770
	public void SetValues(Dictionary<string, object> d) { }

	// RVA: 0xFC3120 Offset: 0xFC2520 VA: 0x180FC3120
	public void SetValues(Dictionary<string, object> a, Dictionary<string, object> b, float delta) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x829920 Offset: 0x828D20 VA: 0x180829920
	public void set_IsDirty(bool value) { }

	// RVA: 0xFC3110 Offset: 0xFC2510 VA: 0x180FC3110
	private void MarkDirty() { }

	// RVA: 0xFC2EF0 Offset: 0xFC22F0 VA: 0x180FC2EF0
	public void Load(JProperty entry) { }

}

private sealed class Properties.<>c__DisplayClass10_0 // TypeDefIndex: 7056
{	// Fields
	public RustInput ctrl; // 0x10
	public FieldInfo f; // 0x18
	public Properties <>4__this; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD33A0 Offset: 0xFD27A0 VA: 0x180FD33A0
	internal void <CreateReadOnlyControl>b__0() { }

}

private sealed class Properties.<>c__DisplayClass11_0 // TypeDefIndex: 7057
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3430 Offset: 0xFD2830 VA: 0x180FD3430
	internal void <CreateStringControl>b__1(Option x) { }

}

private sealed class Properties.<>c__DisplayClass11_1 // TypeDefIndex: 7058
{	// Fields
	public RustButtonGroup ctrl; // 0x10
	public Properties.<>c__DisplayClass11_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3480 Offset: 0xFD2880 VA: 0x180FD3480
	internal void <CreateStringControl>b__2() { }

}

private sealed class Properties.<>c // TypeDefIndex: 7059
{	// Fields
	public static readonly Properties.<>c <>9; // 0x0
	public static Func<OptionAttribute, Option> <>9__11_0; // 0x8

	// Methods

	// RVA: 0xFD3E00 Offset: 0xFD3200 VA: 0x180FD3E00
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3270 Offset: 0xFD2670 VA: 0x180FD3270
	internal Option <CreateStringControl>b__11_0(OptionAttribute x) { }

}

private sealed class Properties.<>c__DisplayClass12_0 // TypeDefIndex: 7060
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18
	public RustToggle ctrl; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3780 Offset: 0xFD2B80 VA: 0x180FD3780
	internal void <CreateBooleanControl>b__0(bool x) { }

	// RVA: 0xFD3820 Offset: 0xFD2C20 VA: 0x180FD3820
	internal void <CreateBooleanControl>b__1() { }

}

private sealed class Properties.<>c__DisplayClass13_0 // TypeDefIndex: 7061
{	// Fields
	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD38D0 Offset: 0xFD2CD0 VA: 0x180FD38D0
	internal void <CreateNumericControl>b__0(float x) { }

}

private sealed class Properties.<>c__DisplayClass13_1 // TypeDefIndex: 7062
{	// Fields
	public RustSlider ctrl; // 0x10
	public Properties.<>c__DisplayClass13_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3970 Offset: 0xFD2D70 VA: 0x180FD3970
	internal void <CreateNumericControl>b__1() { }

}

