internal class GAThreading // TypeDefIndex: 5672
{
	private static bool endThread; 
	private static DateTime threadDeadline; 
	private static readonly GAThreading _instance; 
	private readonly PriorityQueue<long, TimedBlock> blocks; 
	private readonly object threadLock; 
	private TimedBlock scheduledBlock; 
	private bool hasScheduledBlockRun; 
	private Thread thread; 

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

