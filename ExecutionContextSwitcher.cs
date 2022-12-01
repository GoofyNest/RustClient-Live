internal struct ExecutionContextSwitcher // TypeDefIndex: 781
{
	internal ExecutionContext.Reader outerEC;
	internal bool outerECBelongsToScope;
	internal object hecsw;
	internal Thread thread;


	[ReliabilityContractAttribute]
	[HandleProcessCorruptedStateExceptionsAttribute]
	internal bool UndoNoThrow() { }

	[ReliabilityContractAttribute]
	internal void Undo() { }

}

