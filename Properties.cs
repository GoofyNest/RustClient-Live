public class Properties // TypeDefIndex: 7099
{
	private object Parent;
	private RectTransform Canvas;
	[CompilerGeneratedAttribute]
	private Action UpdateControlsFromValues;
	public List<FieldInfo> Fields;
	[CompilerGeneratedAttribute]
	private bool <IsDirty>k__BackingField;

	public bool IsDirty { get; set; }


	[CompilerGeneratedAttribute]
	public void add_UpdateControlsFromValues(Action value) { }

	[CompilerGeneratedAttribute]
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

	[CompilerGeneratedAttribute]
	public bool get_IsDirty() { }

	[CompilerGeneratedAttribute]
	public void set_IsDirty(bool value) { }

	private void MarkDirty() { }

	public void Load(JProperty entry) { }

}

private sealed class Properties.<>c__DisplayClass10_0 // TypeDefIndex: 7100
{
	public RustInput ctrl;
	public FieldInfo f;
	public Properties <>4__this;


	public void .ctor() { }

	internal void <CreateReadOnlyControl>

}

private sealed class Properties.<>c__DisplayClass11_0 // TypeDefIndex: 7101
{
	public FieldInfo f;
	public Properties <>4__this;


	public void .ctor() { }

	internal void <CreateStringControl>

}

private sealed class Properties.<>c__DisplayClass11_1 // TypeDefIndex: 7102
{
	public RustButtonGroup ctrl;
	public Properties.<>c


	public void .ctor() { }

	internal void <CreateStringControl>

}

private sealed class Properties.<>c // TypeDefIndex: 7103
{
	public static readonly Properties.<>c <>9;
	public static Func<OptionAttribute, Option> <>9__11_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal Option <CreateStringControl>

}

private sealed class Properties.<>c__DisplayClass12_0 // TypeDefIndex: 7104
{
	public FieldInfo f;
	public Properties <>4__this;
	public RustToggle ctrl;


	public void .ctor() { }

	internal void <CreateBooleanControl>

	internal void <CreateBooleanControl>

}

private sealed class Properties.<>c__DisplayClass13_0 // TypeDefIndex: 7105
{
	public FieldInfo f;
	public Properties <>4__this;


	public void .ctor() { }

	internal void <CreateNumericControl>

}

private sealed class Properties.<>c__DisplayClass13_1 // TypeDefIndex: 7106
{
	public RustSlider ctrl;
	public Properties.<>c


	public void .ctor() { }

	internal void <CreateNumericControl>

}

