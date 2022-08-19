internal class IOSelectorJob : IThreadPoolWorkItem // TypeDefIndex: 2595
{	// Fields
	private IOOperation operation; // 0x10
	private IOAsyncCallback callback; // 0x18
	private IOAsyncResult state; // 0x20

	// Methods

	// RVA: 0x12EF0B0 Offset: 0x12EE4B0 VA: 0x1812EF0B0
	public void .ctor(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state) { }

	// RVA: 0x1560950 Offset: 0x155FD50 VA: 0x181560950 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x1560920 Offset: 0x155FD20 VA: 0x181560920
	public void MarkDisposed() { }

}

