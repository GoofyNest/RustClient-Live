internal class SendMouseEvents // TypeDefIndex: 4076
{	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2310400 Offset: 0x230F800 VA: 0x182310400
	private static void SetMouseMoved() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x230EC40 Offset: 0x230E040 VA: 0x18230EC40
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x230F940 Offset: 0x230ED40 VA: 0x18230F940
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x2310460 Offset: 0x230F860 VA: 0x182310460
	private static void .cctor() { }

}

private struct SendMouseEvents.HitInfo // TypeDefIndex: 4077
{	// Fields
	public GameObject target; // 0x0
	public Camera camera; // 0x8

	// Methods

	// RVA: 0x240900 Offset: 0x23FD00 VA: 0x180240900
	public void SendMessage(string name) { }

	// RVA: 0x230E400 Offset: 0x230D800 VA: 0x18230E400
	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	// RVA: 0x230E340 Offset: 0x230D740 VA: 0x18230E340
	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }

}

