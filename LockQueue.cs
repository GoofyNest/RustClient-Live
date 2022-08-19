internal class LockQueue // TypeDefIndex: 825
{	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x148FB60 Offset: 0x148EF60 VA: 0x18148FB60
	public bool Wait(int timeout) { }

	// RVA: 0x148FCF0 Offset: 0x148F0F0 VA: 0x18148FCF0
	public bool get_IsEmpty() { }

	// RVA: 0x148F9E0 Offset: 0x148EDE0 VA: 0x18148F9E0
	public void Pulse() { }

}

