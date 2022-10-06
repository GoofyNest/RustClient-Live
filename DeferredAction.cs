public class DeferredAction // TypeDefIndex: 13048
{
	private Object sender; 
	private Action action; 
	private ActionPriority priority; 
	[CompilerGeneratedAttribute] 
	private bool <Idle>k__BackingField; 

	public bool Idle { get; set; }
	public int Index { get; }


	[CompilerGeneratedAttribute] 
	public bool get_Idle() { }

	[CompilerGeneratedAttribute] 
	private void set_Idle(bool value) { }

	public int get_Index() { }

	public void .ctor(Object sender, Action action, ActionPriority priority = 2) { }

	public void Action() { }

	public void Invoke() { }

	public static bool op_Implicit(DeferredAction obj) { }

	public static void Invoke(Object sender, Action action, ActionPriority priority = 2) { }

}

