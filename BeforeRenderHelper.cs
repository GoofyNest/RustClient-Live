internal static class BeforeRenderHelper // TypeDefIndex: 3382
{
	private static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks;


	private static int GetUpdateOrder(UnityAction callback) { }

	public static void RegisterCallback(UnityAction callback) { }

	public static void UnregisterCallback(UnityAction callback) { }

	public static void Invoke() { }

	private static void .cctor() { }

}

private struct BeforeRenderHelper.OrderBlock // TypeDefIndex: 3383
{
	internal int order;
	internal UnityAction callback;

}

