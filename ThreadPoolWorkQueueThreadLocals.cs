internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 813
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x1605EC0 Offset: 0x16052C0 VA: 0x181605EC0
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x1605C40 Offset: 0x1605040 VA: 0x181605C40
	private void CleanUp() { }

	// RVA: 0x1605E00 Offset: 0x1605200 VA: 0x181605E00 Slot: 1
	protected override void Finalize() { }

}

