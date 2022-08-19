public class DeferredAction // TypeDefIndex: 11309
{	// Fields
	private Object sender; // 0x10
	private Action action; // 0x18
	private ActionPriority priority; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Idle>k__BackingField; // 0x24

	// Properties
	public bool Idle { get; set; }
	public int Index { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7723F0 Offset: 0x7717F0 VA: 0x1807723F0
	public bool get_Idle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772430 Offset: 0x771830 VA: 0x180772430
	private void set_Idle(bool value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_Index() { }

	// RVA: 0x8EAA70 Offset: 0x8E9E70 VA: 0x1808EAA70
	public void .ctor(Object sender, Action action, ActionPriority priority = 2) { }

	// RVA: 0x8EA810 Offset: 0x8E9C10 VA: 0x1808EA810
	public void Action() { }

	// RVA: 0x8EA9E0 Offset: 0x8E9DE0 VA: 0x1808EA9E0
	public void Invoke() { }

	// RVA: 0x6B8100 Offset: 0x6B7500 VA: 0x1806B8100
	public static bool op_Implicit(DeferredAction obj) { }

	// RVA: 0x8EA8D0 Offset: 0x8E9CD0 VA: 0x1808EA8D0
	public static void Invoke(Object sender, Action action, ActionPriority priority = 2) { }

}

