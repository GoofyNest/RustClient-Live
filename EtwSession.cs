internal class EtwSession // TypeDefIndex: 1618
{	public readonly int m_etwSessionId; // 0x10
	public ActivityFilter m_activityFilter; // 0x18
	private static List<WeakReference<EtwSession>> s_etwSessions; // 0x0


	public static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = False) { }

	public static void RemoveEtwSession(EtwSession etwSession) { }

	private static void TrimGlobalList() { }

	private void .ctor(int etwSessionId) { }

	private static void .cctor() { }

}

private sealed class EtwSession.<>c__DisplayClass1_0 // TypeDefIndex: 1619
{	public EtwSession etwSession; // 0x10


	public void .ctor() { }

	internal bool <RemoveEtwSession>b__0(WeakReference<EtwSession> wrEtwSession) { }

}

private sealed class EtwSession.<>c // TypeDefIndex: 1620
{	public static readonly EtwSession.<>c <>9; // 0x0
	public static Predicate<WeakReference<EtwSession>> <>9__2_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <TrimGlobalList>b__2_0(WeakReference<EtwSession> wrEtwSession) { }

}

