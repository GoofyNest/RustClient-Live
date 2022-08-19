public static class CommandBufferEx // TypeDefIndex: 10695
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596A10 Offset: 0x595E10 VA: 0x180596A10
	public static void BlitArray(CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Material mat, int slice, int pass = 0) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596840 Offset: 0x595C40 VA: 0x180596840
	public static void BlitArray(CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Texture target, Material mat, int slice, int pass = 0) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596510 Offset: 0x595910 VA: 0x180596510
	public static void BlitArrayMip(CommandBuffer cb, Mesh blitMesh, Texture source, int sourceMip, int sourceSlice, Texture target, int targetMip, int targetSlice, Material mat, int pass = 0) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x596B70 Offset: 0x595F70 VA: 0x180596B70
	public static void BlitMip(CommandBuffer cb, Mesh blitMesh, Texture source, Texture target, int mip, int slice, Material mat, int pass = 0) { }

}

