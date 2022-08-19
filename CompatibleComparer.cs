internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 1386
{	// Fields
	private IComparer _comparer; // 0x10
	private IHashCodeProvider _hcp; // 0x18

	// Properties
	internal IComparer Comparer { get; }
	internal IHashCodeProvider HashCodeProvider { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x144D4A0 Offset: 0x144C8A0 VA: 0x18144D4A0
	public int Compare(object a, object b) { }

	// RVA: 0x144D640 Offset: 0x144CA40 VA: 0x18144D640 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x144D7A0 Offset: 0x144CBA0 VA: 0x18144D7A0 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal IComparer get_Comparer() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal IHashCodeProvider get_HashCodeProvider() { }

}

internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 3105
{	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x1599A40 Offset: 0x1598E40 VA: 0x181599A40 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x1599B50 Offset: 0x1598F50 VA: 0x181599B50 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public IComparer get_Comparer() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x1599C00 Offset: 0x1599000 VA: 0x181599C00
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x1599CD0 Offset: 0x15990D0 VA: 0x181599CD0
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

}

