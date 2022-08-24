public class Properties // TypeDefIndex: 7055
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

private sealed class Properties.<>c__DisplayClass10_0 // TypeDefIndex: 7056
{
	public RustInput ctrl; 
	public FieldInfo f; 
	public Properties <>4__this; 


public void .ctor() { }

internal void <CreateReadOnlyControl>b__0() { }

}

private sealed class Properties.<>c__DisplayClass11_0 // TypeDefIndex: 7057
{
	public FieldInfo f; 
	public Properties <>4__this; 


public void .ctor() { }

internal void <CreateStringControl>b__1(Option x) { }

}

private sealed class Properties.<>c__DisplayClass11_1 // TypeDefIndex: 7058
{
	public RustButtonGroup ctrl; 
	public Properties.<>c__DisplayClass11_0 CS$<>8__locals1; 


public void .ctor() { }

internal void <CreateStringControl>b__2() { }

}

private sealed class Properties.<>c // TypeDefIndex: 7059
{
	public static readonly Properties.<>c <>9; 
	public static Func<OptionAttribute, Option> <>9__11_0; 


private static void .cctor() { }

public void .ctor() { }

internal Option <CreateStringControl>b__11_0(OptionAttribute x) { }

}

private sealed class Properties.<>c__DisplayClass12_0 // TypeDefIndex: 7060
{
	public FieldInfo f; 
	public Properties <>4__this; 
	public RustToggle ctrl; 


public void .ctor() { }

internal void <CreateBooleanControl>b__0(bool x) { }

internal void <CreateBooleanControl>b__1() { }

}

private sealed class Properties.<>c__DisplayClass13_0 // TypeDefIndex: 7061
{
	public FieldInfo f; 
	public Properties <>4__this; 


public void .ctor() { }

internal void <CreateNumericControl>b__0(float x) { }

}

private sealed class Properties.<>c__DisplayClass13_1 // TypeDefIndex: 7062
{
	public RustSlider ctrl; 
	public Properties.<>c__DisplayClass13_0 CS$<>8__locals1; 


public void .ctor() { }

internal void <CreateNumericControl>b__1() { }

}

