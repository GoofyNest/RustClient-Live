public static class Threading // TypeDefIndex: 6233
{
	private static int mainThread; 
	private static List<Action> actions; 

	public static bool IsMainThread { get; }


	public static bool get_IsMainThread() { }

	public static void QueueOnMainThread(Action action) { }

	internal static void RunQueuedFunctionsOnMainThread() { }

	private static void .cctor() { }

}

