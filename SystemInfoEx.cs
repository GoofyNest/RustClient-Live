public static class SystemInfoEx // TypeDefIndex: 9290
{	// Fields
	private static bool[] supportedRenderTextureFormats; // 0x180C

	// Properties
	public static int systemMemoryUsed { get; }

	// Methods

	// RVA: 0x7A52C0 Offset: 0x7A46C0 VA: 0x1807A52C0
	private static extern ulong System_GetMemoryUsage() { }

	// RVA: 0x7A5330 Offset: 0x7A4730 VA: 0x1807A5330
	public static int get_systemMemoryUsed() { }

	// RVA: 0x7A4FE0 Offset: 0x7A43E0 VA: 0x1807A4FE0
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

