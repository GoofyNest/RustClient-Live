internal class EtwSession // TypeDefIndex: 1618
{	// Fields
	public readonly int m_etwSessionId; // 0x10
	public ActivityFilter m_activityFilter; // 0x18
	private static List<WeakReference<EtwSession>> s_etwSessions; // 0x0

	// Methods

	// RVA: 0xD6E6D0 Offset: 0xD6DAD0 VA: 0x180D6E6D0
	public static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = False) { }

	// RVA: 0xD6EA20 Offset: 0xD6DE20 VA: 0x180D6EA20
	public static void RemoveEtwSession(EtwSession etwSession) { }

	// RVA: 0xD6EB80 Offset: 0xD6DF80 VA: 0x180D6EB80
	private static void TrimGlobalList() { }

	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	private void .ctor(int etwSessionId) { }

	// RVA: 0xD6ECE0 Offset: 0xD6E0E0 VA: 0x180D6ECE0
	private static void .cctor() { }

}

private sealed class EtwSession.<>c__DisplayClass1_0 // TypeDefIndex: 1619
{	// Fields
	public EtwSession etwSession; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xD826F0 Offset: 0xD81AF0 VA: 0x180D826F0
	internal bool <RemoveEtwSession>b__0(WeakReference<EtwSession> wrEtwSession) { }

}

private sealed class EtwSession.<>c // TypeDefIndex: 1620
{	// Fields
	public static readonly EtwSession.<>c <>9; // 0x0
	public static Predicate<WeakReference<EtwSession>> <>9__2_0; // 0x8

	// Methods

	// RVA: 0xD82850 Offset: 0xD81C50 VA: 0x180D82850
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xD82580 Offset: 0xD81980 VA: 0x180D82580
	internal bool <TrimGlobalList>b__2_0(WeakReference<EtwSession> wrEtwSession) { }

}

