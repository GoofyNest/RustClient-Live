internal struct ExecutionContextSwitcher // TypeDefIndex: 781
{	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18


	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0xB4220 Offset: 0xB3620 VA: 0x1800B4220
	[ReliabilityContractAttribute] // RVA: 0xB4220 Offset: 0xB3620 VA: 0x1800B4220
	internal bool UndoNoThrow() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	internal void Undo() { }

}

