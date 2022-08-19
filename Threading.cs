public static class Threading // TypeDefIndex: 6229
{	// Fields
	private static int mainThread; // 0x0
	private static List<Action> actions; // 0x8

	// Properties
	public static bool IsMainThread { get; }

	// Methods

	// RVA: 0x14F0FD0 Offset: 0x14F03D0 VA: 0x1814F0FD0
	public static bool get_IsMainThread() { }

	// RVA: 0x14F0AE0 Offset: 0x14EFEE0 VA: 0x1814F0AE0
	public static void QueueOnMainThread(Action action) { }

	// RVA: 0x14F0CC0 Offset: 0x14F00C0 VA: 0x1814F0CC0
	internal static void RunQueuedFunctionsOnMainThread() { }

	// RVA: 0x14F0F60 Offset: 0x14F0360 VA: 0x1814F0F60
	private static void .cctor() { }

}

