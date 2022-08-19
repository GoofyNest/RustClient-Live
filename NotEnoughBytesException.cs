public sealed class NotEnoughBytesException : MidiException // TypeDefIndex: 7579
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <ExpectedCount>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly long <ActualCount>k__BackingField; // 0x90

	// Methods

	// RVA: 0x139B220 Offset: 0x139A620 VA: 0x18139B220
	internal void .ctor(string message, Exception innerException) { }

	// RVA: 0x139E500 Offset: 0x139D900 VA: 0x18139E500
	internal void .ctor(string message, long expectedCount, long actualCount) { }

}

