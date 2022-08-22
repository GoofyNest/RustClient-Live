public class DeferredAction // TypeDefIndex: 11309
{	private Object sender; // 0x10
	private Action action; // 0x18
	private ActionPriority priority; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Idle>k__BackingField; // 0x24

	public bool Idle { get; set; }
	public int Index { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_Idle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Idle(bool value) { }

	public int get_Index() { }

	public void .ctor(Object sender, Action action, ActionPriority priority = 2) { }

	public void Action() { }

	public void Invoke() { }

	public static bool op_Implicit(DeferredAction obj) { }

	public static void Invoke(Object sender, Action action, ActionPriority priority = 2) { }

}

