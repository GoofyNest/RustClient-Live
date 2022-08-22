internal class GAThreading // TypeDefIndex: 5667
{	private static bool endThread; // 0x0
	private static DateTime threadDeadline; // 0x8
	private static readonly GAThreading _instance; // 0x10
	private readonly PriorityQueue<long, TimedBlock> blocks; // 0x10
	private readonly object threadLock; // 0x18
	private TimedBlock scheduledBlock; // 0x20
	private bool hasScheduledBlockRun; // 0x28
	private Thread thread; // 0x30

	private static GAThreading Instance { get; }


	private void .ctor() { }

	protected override void Finalize() { }

	private static GAThreading get_Instance() { }

	private static void RunBlocks() { }

	public static void Run() { }

	public static void PerformTaskOnGAThread(string blockName, Action taskBlock) { }

	public static void PerformTaskOnGAThread(string blockName, Action taskBlock, long delayInSeconds) { }

	public static void ScheduleTimer(double interval, string blockName, Action callback) { }

	private void AddTimedBlock(TimedBlock timedBlock) { }

	private static TimedBlock GetNextBlock() { }

	private static TimedBlock GetScheduledBlock() { }

	public static void StartThread() { }

	public static void StopThread() { }

	public static void WaitForThreadFinish() { }

	public static bool IsThreadFinished() { }

	private static void .cctor() { }

}

