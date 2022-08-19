internal class TimedBlock : IComparable<TimedBlock> // TypeDefIndex: 5634
{	// Fields
	public readonly DateTime deadline; // 0x10
	public readonly Action block; // 0x18
	public readonly string blockName; // 0x20

	// Methods

	// RVA: 0x13C6D00 Offset: 0x13C6100 VA: 0x1813C6D00
	public void .ctor(DateTime deadline, Action block, string blockName) { }

	// RVA: 0x13C6A50 Offset: 0x13C5E50 VA: 0x1813C6A50 Slot: 4
	public int CompareTo(TimedBlock other) { }

	// RVA: 0x13C6A80 Offset: 0x13C5E80 VA: 0x1813C6A80 Slot: 3
	public override string ToString() { }

}

