internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 813
{
	[ThreadStaticAttribute] 
	public static ThreadPoolWorkQueueThreadLocals threadLocals; 
	public readonly ThreadPoolWorkQueue workQueue; 
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; 
	public readonly Random random; 


	public void .ctor(ThreadPoolWorkQueue tpq) { }

	private void CleanUp() { }

	protected override void Finalize() { }

}

