public class Properties // TypeDefIndex: 7055
{	private object Parent; // 0x10
	private RectTransform Canvas; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action UpdateControlsFromValues; // 0x20
	public List<FieldInfo> Fields; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsDirty>k__BackingField; // 0x30

	public bool IsDirty { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_UpdateControlsFromValues(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_UpdateControlsFromValues(Action value) { }

	public void .ctor(object Parent, RectTransform Canvas) { }

	public void CreateControls() { }

	private void AddControl(RustControl ctrl, LabelAttribute label) { }

	private bool CreateControl(FieldInfo f) { }

	private bool CreateReadOnlyControl(FieldInfo f) { }

	private bool CreateStringControl(FieldInfo f) { }

	private bool CreateBooleanControl(FieldInfo f) { }

	private bool CreateNumericControl(FieldInfo f) { }

	public void SyncControls() { }

	public Dictionary<string, object> GetValues() { }

	public void SetValues(Dictionary<string, object> d) { }

	public void SetValues(Dictionary<string, object> a, Dictionary<string, object> b, float delta) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_IsDirty(bool value) { }

	private void MarkDirty() { }

	public void Load(JProperty entry) { }

}

private sealed class Properties.<>c__DisplayClass10_0 // TypeDefIndex: 7056
{	public RustInput ctrl; // 0x10
	public FieldInfo f; // 0x18
	public Properties <>4__this; // 0x20


	public void .ctor() { }

	internal void <CreateReadOnlyControl>b__0() { }

}

private sealed class Properties.<>c__DisplayClass11_0 // TypeDefIndex: 7057
{	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18


	public void .ctor() { }

	internal void <CreateStringControl>b__1(Option x) { }

}

private sealed class Properties.<>c__DisplayClass11_1 // TypeDefIndex: 7058
{	public RustButtonGroup ctrl; // 0x10
	public Properties.<>c__DisplayClass11_0 CS$<>8__locals1; // 0x18


	public void .ctor() { }

	internal void <CreateStringControl>b__2() { }

}

private sealed class Properties.<>c // TypeDefIndex: 7059
{	public static readonly Properties.<>c <>9; // 0x0
	public static Func<OptionAttribute, Option> <>9__11_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal Option <CreateStringControl>b__11_0(OptionAttribute x) { }

}

private sealed class Properties.<>c__DisplayClass12_0 // TypeDefIndex: 7060
{	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18
	public RustToggle ctrl; // 0x20


	public void .ctor() { }

	internal void <CreateBooleanControl>b__0(bool x) { }

	internal void <CreateBooleanControl>b__1() { }

}

private sealed class Properties.<>c__DisplayClass13_0 // TypeDefIndex: 7061
{	public FieldInfo f; // 0x10
	public Properties <>4__this; // 0x18


	public void .ctor() { }

	internal void <CreateNumericControl>b__0(float x) { }

}

private sealed class Properties.<>c__DisplayClass13_1 // TypeDefIndex: 7062
{	public RustSlider ctrl; // 0x10
	public Properties.<>c__DisplayClass13_0 CS$<>8__locals1; // 0x18


	public void .ctor() { }

	internal void <CreateNumericControl>b__1() { }

}

