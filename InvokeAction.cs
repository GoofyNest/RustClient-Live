public struct InvokeAction : IEquatable<InvokeAction> // TypeDefIndex: 5568
{	public Behaviour sender; // 0x0
	public Action action; // 0x8
	public float initial; // 0x10
	public float repeat; // 0x14
	public float random; // 0x18


	public void .ctor(Behaviour sender, Action action, float initial = 0, float repeat = -1, float random = 0) { }

	public bool Equals(InvokeAction other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(InvokeAction x, InvokeAction y) { }

	public static bool op_Inequality(InvokeAction x, InvokeAction y) { }

}

