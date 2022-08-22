internal class LockQueue // TypeDefIndex: 825
{	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	public bool IsEmpty { get; }


	public void .ctor(ReaderWriterLock rwlock) { }

	public bool Wait(int timeout) { }

	public bool get_IsEmpty() { }

	public void Pulse() { }

}

