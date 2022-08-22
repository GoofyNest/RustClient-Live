public static class Threading // TypeDefIndex: 6229
{	private static int mainThread; // 0x0
	private static List<Action> actions; // 0x8

	public static bool IsMainThread { get; }


	public static bool get_IsMainThread() { }

	public static void QueueOnMainThread(Action action) { }

	internal static void RunQueuedFunctionsOnMainThread() { }

	private static void .cctor() { }

}

