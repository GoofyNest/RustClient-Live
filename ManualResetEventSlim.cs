public class ManualResetEventSlim : IDisposable // TypeDefIndex: 758
{	// Fields
	private const int DEFAULT_SPIN_SP = 1;
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

	// Properties
	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }

	// Methods

	// RVA: 0x1491620 Offset: 0x1490A20 VA: 0x181491620
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x1491560 Offset: 0x1490960 VA: 0x181491560
	public bool get_IsSet() { }

	// RVA: 0x14916D0 Offset: 0x1490AD0 VA: 0x1814916D0
	private void set_IsSet(bool value) { }

	// RVA: 0x14915C0 Offset: 0x14909C0 VA: 0x1814915C0
	public int get_SpinCount() { }

	// RVA: 0x1491700 Offset: 0x1490B00 VA: 0x181491700
	private void set_SpinCount(int value) { }

	// RVA: 0x1491670 Offset: 0x1490A70 VA: 0x181491670
	private int get_Waiters() { }

	// RVA: 0x1491740 Offset: 0x1490B40 VA: 0x181491740
	private void set_Waiters(int value) { }

	// RVA: 0x1491390 Offset: 0x1490790 VA: 0x181491390
	public void .ctor(bool initialState) { }

	// RVA: 0x1491410 Offset: 0x1490810 VA: 0x181491410
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x14903F0 Offset: 0x148F7F0 VA: 0x1814903F0
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x1490360 Offset: 0x148F760 VA: 0x181490360
	private void EnsureLockObjectCreated() { }

	// RVA: 0x1490470 Offset: 0x148F870 VA: 0x181490470
	private bool LazyInitializeEvent() { }

	// RVA: 0x14906C0 Offset: 0x148FAC0 VA: 0x1814906C0
	public void Set() { }

	// RVA: 0x14906D0 Offset: 0x148FAD0 VA: 0x1814906D0
	private void Set(bool duringCancellation) { }

	// RVA: 0x1491290 Offset: 0x1490690 VA: 0x181491290
	public bool Wait(TimeSpan timeout) { }

	// RVA: 0x1490C00 Offset: 0x1490000 VA: 0x181490C00
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x14902F0 Offset: 0x148F6F0 VA: 0x1814902F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14901B0 Offset: 0x148F5B0 VA: 0x1814901B0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1490A50 Offset: 0x148FE50 VA: 0x181490A50
	private void ThrowIfDisposed() { }

	// RVA: 0x148FF70 Offset: 0x148F370 VA: 0x18148FF70
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x1490AD0 Offset: 0x148FED0 VA: 0x181490AD0
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x14903D0 Offset: 0x148F7D0 VA: 0x1814903D0
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x14903E0 Offset: 0x148F7E0 VA: 0x1814903E0
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x1491320 Offset: 0x1490720 VA: 0x181491320
	private static void .cctor() { }

}

