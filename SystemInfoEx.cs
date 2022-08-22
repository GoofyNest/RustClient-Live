public static class SystemInfoEx // TypeDefIndex: 9290
{	private static bool[] supportedRenderTextureFormats; // 0x180C

	public static int systemMemoryUsed { get; }


	private static extern ulong System_GetMemoryUsage() { }

	public static int get_systemMemoryUsed() { }

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	private static void .cctor() { }

}

