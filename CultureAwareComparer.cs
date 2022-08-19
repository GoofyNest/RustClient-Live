internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 304
{	// Fields
	private CompareInfo _compareInfo; // 0x10
	private bool _ignoreCase; // 0x18
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private CompareOptions _options; // 0x1C

	// Methods

	// RVA: 0x178CE50 Offset: 0x178C250 VA: 0x18178CE50
	internal void .ctor(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x178CC10 Offset: 0x178C010 VA: 0x18178CC10 Slot: 10
	public override int Compare(string x, string y) { }

	// RVA: 0x178CC70 Offset: 0x178C070 VA: 0x18178CC70 Slot: 11
	public override bool Equals(string x, string y) { }

	// RVA: 0x178CD80 Offset: 0x178C180 VA: 0x18178CD80 Slot: 12
	public override int GetHashCode(string obj) { }

	// RVA: 0x178CCD0 Offset: 0x178C0D0 VA: 0x18178CCD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x178CE10 Offset: 0x178C210 VA: 0x18178CE10 Slot: 2
	public override int GetHashCode() { }

}

