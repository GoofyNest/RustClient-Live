internal struct ExecutionContextSwitcher // TypeDefIndex: 781
{	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB4220 Offset: 0xB3620 VA: 0x1800B4220
	[ReliabilityContractAttribute] // RVA: 0xB4220 Offset: 0xB3620 VA: 0x1800B4220
	// RVA: 0x1F0570 Offset: 0x1EF970 VA: 0x1801F0570
	internal bool UndoNoThrow() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x1F0580 Offset: 0x1EF980 VA: 0x1801F0580
	internal void Undo() { }

}

