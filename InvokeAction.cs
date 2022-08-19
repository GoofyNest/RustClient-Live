public struct InvokeAction : IEquatable<InvokeAction> // TypeDefIndex: 5568
{	// Fields
	public Behaviour sender; // 0x0
	public Action action; // 0x8
	public float initial; // 0x10
	public float repeat; // 0x14
	public float random; // 0x18

	// Methods

	// RVA: 0x2214D0 Offset: 0x2208D0 VA: 0x1802214D0
	public void .ctor(Behaviour sender, Action action, float initial = 0, float repeat = -1, float random = 0) { }

	// RVA: 0x221420 Offset: 0x220820 VA: 0x180221420 Slot: 4
	public bool Equals(InvokeAction other) { }

	// RVA: 0x221330 Offset: 0x220730 VA: 0x180221330 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF2E70 Offset: 0xF2270 VA: 0x1800F2E70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19865D0 Offset: 0x19859D0 VA: 0x1819865D0
	public static bool op_Equality(InvokeAction x, InvokeAction y) { }

	// RVA: 0x1986670 Offset: 0x1985A70 VA: 0x181986670
	public static bool op_Inequality(InvokeAction x, InvokeAction y) { }

}

