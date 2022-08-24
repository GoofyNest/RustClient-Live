internal class EtwSession // TypeDefIndex: 1618
{
	public readonly int m_etwSessionId; 
	public ActivityFilter m_activityFilter; 
	private static List<WeakReference<EtwSession>> s_etwSessions; 


public static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = False) { }

public static void RemoveEtwSession(EtwSession etwSession) { }

private static void TrimGlobalList() { }

private void .ctor(int etwSessionId) { }

private static void .cctor() { }

}

private sealed class EtwSession.<>c__DisplayClass1_0 // TypeDefIndex: 1619
{
	public EtwSession etwSession; 


public void .ctor() { }

internal bool <RemoveEtwSession>b__0(WeakReference<EtwSession> wrEtwSession) { }

}

private sealed class EtwSession.<>c // TypeDefIndex: 1620
{
	public static readonly EtwSession.<>c <>9; 
	public static Predicate<WeakReference<EtwSession>> <>9__2_0; 


private static void .cctor() { }

public void .ctor() { }

internal bool <TrimGlobalList>b__2_0(WeakReference<EtwSession> wrEtwSession) { }

}

