public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple> // TypeDefIndex: 125
{	// Methods

	// RVA: 0x234290 Offset: 0x233690 VA: 0x180234290 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21AE70 Offset: 0x21A270 VA: 0x18021AE70 Slot: 4
	public bool Equals(ValueTuple other) { }

	// RVA: 0x2343D0 Offset: 0x2337D0 VA: 0x1802343D0 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: 0x234420 Offset: 0x233820 VA: 0x180234420 Slot: 8
	private int System.IComparable.CompareTo(object other) { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 9
	public int CompareTo(ValueTuple other) { }

	// RVA: 0x2342E0 Offset: 0x2336E0 VA: 0x1802342E0 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117C10 Offset: 0x117010 VA: 0x180117C10 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x234510 Offset: 0x233910 VA: 0x180234510 Slot: 3
	public override string ToString() { }

	// RVA: 0x2142170 Offset: 0x2141570 VA: 0x182142170
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x21421F0 Offset: 0x21415F0 VA: 0x1821421F0
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

}

