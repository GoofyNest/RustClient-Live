internal class SendMouseEvents // TypeDefIndex: 4081
{
	private static bool s_MouseUsed;
	private static readonly SendMouseEvents.HitInfo[] m_LastHit;
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit;
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit;
	private static Camera[] m_Cameras;


	[RequiredByNativeCodeAttribute]
	private static void SetMouseMoved() { }

	[RequiredByNativeCodeAttribute]
	private static void DoSendMouseEvents(int skipRTCameras) { }

	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	private static void .cctor() { }

}

private struct SendMouseEvents.HitInfo // TypeDefIndex: 4082
{
	public GameObject target;
	public Camera camera;


	public void SendMessage(string name) { }

	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }

}

