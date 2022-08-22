internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 813
{	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20


	public void .ctor(ThreadPoolWorkQueue tpq) { }

	private void CleanUp() { }

	protected override void Finalize() { }

}

