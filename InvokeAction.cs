public struct InvokeAction : IEquatable<InvokeAction> // TypeDefIndex: 5573
{
	public Behaviour sender; 
	public Action action; 
	public float initial; 
	public float repeat; 
	public float random; 


	public void .ctor(Behaviour sender, Action action, float initial = 0, float repeat = -1, float random = 0) { }

	public bool Equals(InvokeAction other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(InvokeAction x, InvokeAction y) { }

	public static bool op_Inequality(InvokeAction x, InvokeAction y) { }

}

