public class ManualResetEventSlim : IDisposable // TypeDefIndex: 758
{	private const int DEFAULT_SPIN_SP = 1;
	private const int DEFAULT_SPIN_MP = 10;
	private object m_lock; // 0x10
	private ManualResetEvent m_eventObj; // 0x18
	private int m_combinedState; // 0x20
	private const int SignalledState_BitMask = -2147483648;
	private const int SignalledState_ShiftCount = 31;
	private const int Dispose_BitMask = 1073741824;
	private const int SpinCountState_BitMask = 1073217536;
	private const int SpinCountState_ShiftCount = 19;
	private const int SpinCountState_MaxValue = 2047;
	private const int NumWaitersState_BitMask = 524287;
	private const int NumWaitersState_ShiftCount = 0;
	private const int NumWaitersState_MaxValue = 524287;
	private static Action<object> s_cancellationTokenCallback; // 0x0

	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }


	public WaitHandle get_WaitHandle() { }

	public bool get_IsSet() { }

	private void set_IsSet(bool value) { }

	public int get_SpinCount() { }

	private void set_SpinCount(int value) { }

	private int get_Waiters() { }

	private void set_Waiters(int value) { }

	public void .ctor(bool initialState) { }

	public void .ctor(bool initialState, int spinCount) { }

	private void Initialize(bool initialState, int spinCount) { }

	private void EnsureLockObjectCreated() { }

	private bool LazyInitializeEvent() { }

	public void Set() { }

	private void Set(bool duringCancellation) { }

	public bool Wait(TimeSpan timeout) { }

	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	private void ThrowIfDisposed() { }

	private static void CancellationTokenCallback(object obj) { }

	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	private static int ExtractStatePortion(int state, int mask) { }

	private static void .cctor() { }

}

