public static class CommandBufferEx // TypeDefIndex: 12454
{

	[ExtensionAttribute]
	public static void BlitArray(CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Material mat, int slice, int pass = 0) { }

	[ExtensionAttribute]
	public static void BlitArray(CommandBuffer cb, Mesh blitMesh, RenderTargetIdentifier source, Texture target, Material mat, int slice, int pass = 0) { }

	[ExtensionAttribute]
	public static void BlitArrayMip(CommandBuffer cb, Mesh blitMesh, Texture source, int sourceMip, int sourceSlice, Texture target, int targetMip, int targetSlice, Material mat, int pass = 0) { }

	[ExtensionAttribute]
	public static void BlitMip(CommandBuffer cb, Mesh blitMesh, Texture source, Texture target, int mip, int slice, Material mat, int pass = 0) { }

}

