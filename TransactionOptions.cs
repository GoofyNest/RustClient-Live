public struct TransactionOptions // TypeDefIndex: 3988
{	// Fields
	private IsolationLevel level; // 0x0
	private TimeSpan timeout; // 0x8

	// Methods

	// RVA: 0x14B440 Offset: 0x14A840 VA: 0x18014B440
	internal void .ctor(IsolationLevel level, TimeSpan timeout) { }

	// RVA: 0x2307A10 Offset: 0x2306E10 VA: 0x182307A10
	public static bool op_Equality(TransactionOptions x, TransactionOptions y) { }

	// RVA: 0x23FA50 Offset: 0x23EE50 VA: 0x18023FA50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23FB40 Offset: 0x23EF40 VA: 0x18023FB40 Slot: 2
	public override int GetHashCode() { }

}

