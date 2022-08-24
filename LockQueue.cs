internal class LockQueue // TypeDefIndex: 825
{
	private ReaderWriterLock rwlock; 
	private int lockCount; 

	public bool IsEmpty { get; }


	public void .ctor(ReaderWriterLock rwlock) { }

	public bool Wait(int timeout) { }

	public bool get_IsEmpty() { }

	public void Pulse() { }

}

