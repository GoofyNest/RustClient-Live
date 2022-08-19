internal class GAThreading // TypeDefIndex: 5667
{	// Fields
	private static bool endThread; // 0x0
	private static DateTime threadDeadline; // 0x8
	private static readonly GAThreading _instance; // 0x10
	private readonly PriorityQueue<long, TimedBlock> blocks; // 0x10
	private readonly object threadLock; // 0x18
	private TimedBlock scheduledBlock; // 0x20
	private bool hasScheduledBlockRun; // 0x28
	private Thread thread; // 0x30

	// Properties
	private static GAThreading Instance { get; }

	// Methods

	// RVA: 0x13BF850 Offset: 0x13BEC50 VA: 0x1813BF850
	private void .ctor() { }

	// RVA: 0x13BDF20 Offset: 0x13BD320 VA: 0x1813BDF20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x13BF950 Offset: 0x13BED50 VA: 0x1813BF950
	private static GAThreading get_Instance() { }

	// RVA: 0x13BECC0 Offset: 0x13BE0C0 VA: 0x1813BECC0
	private static void RunBlocks() { }

	// RVA: 0x13BED70 Offset: 0x13BE170 VA: 0x1813BED70
	public static void Run() { }

	// RVA: 0x13BEC50 Offset: 0x13BE050 VA: 0x1813BEC50
	public static void PerformTaskOnGAThread(string blockName, Action taskBlock) { }

	// RVA: 0x13BE830 Offset: 0x13BDC30 VA: 0x1813BE830
	public static void PerformTaskOnGAThread(string blockName, Action taskBlock, long delayInSeconds) { }

	// RVA: 0x13BEF00 Offset: 0x13BE300 VA: 0x1813BEF00
	public static void ScheduleTimer(double interval, string blockName, Action callback) { }

	// RVA: 0x13BDEA0 Offset: 0x13BD2A0 VA: 0x1813BDEA0
	private void AddTimedBlock(TimedBlock timedBlock) { }

	// RVA: 0x13BE030 Offset: 0x13BD430 VA: 0x1813BE030
	private static TimedBlock GetNextBlock() { }

	// RVA: 0x13BE3A0 Offset: 0x13BD7A0 VA: 0x1813BE3A0
	private static TimedBlock GetScheduledBlock() { }

	// RVA: 0x13BF340 Offset: 0x13BE740 VA: 0x1813BF340
	public static void StartThread() { }

	// RVA: 0x13BF520 Offset: 0x13BE920 VA: 0x1813BF520
	public static void StopThread() { }

	// RVA: 0x13BF580 Offset: 0x13BE980 VA: 0x1813BF580
	public static void WaitForThreadFinish() { }

	// RVA: 0x13BE6F0 Offset: 0x13BDAF0 VA: 0x1813BE6F0
	public static bool IsThreadFinished() { }

	// RVA: 0x13BF700 Offset: 0x13BEB00 VA: 0x1813BF700
	private static void .cctor() { }

}

