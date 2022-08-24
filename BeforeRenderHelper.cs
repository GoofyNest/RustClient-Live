internal static class BeforeRenderHelper // TypeDefIndex: 3381
{
	private static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks; 


	public static void Invoke() { }

	private static void .cctor() { }

}

private struct BeforeRenderHelper.OrderBlock // TypeDefIndex: 3382
{
	internal int order; 
	internal UnityAction callback; 

}

