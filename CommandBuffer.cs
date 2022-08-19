public class CommandBuffer : IDisposable // TypeDefIndex: 3841
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string name { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x75170 Offset: 0x74570 VA: 0x180075170
	// RVA: 0x19A2BE0 Offset: 0x19A1FE0 VA: 0x1819A2BE0
	private void Internal_SetSinglePassStereo(SinglePassStereoMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x75330 Offset: 0x74730 VA: 0x180075330
	// RVA: 0x19A2840 Offset: 0x19A1C40 VA: 0x1819A2840
	private static IntPtr InitBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x753F0 Offset: 0x747F0 VA: 0x1800753F0
	// RVA: 0x19A2D80 Offset: 0x19A2180 VA: 0x1819A2D80
	private void ReleaseBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x75520 Offset: 0x74920 VA: 0x180075520
	// RVA: 0x19A30B0 Offset: 0x19A24B0 VA: 0x1819A30B0
	public void SetComputeVectorParam(ComputeShader computeShader, int nameID, Vector4 val) { }

	[FreeFunctionAttribute] // RVA: 0x75850 Offset: 0x74C50 VA: 0x180075850
	// RVA: 0x19A2B00 Offset: 0x19A1F00 VA: 0x1819A2B00
	private void Internal_SetComputeFloats(ComputeShader computeShader, int nameID, float[] values) { }

	[FreeFunctionAttribute] // RVA: 0x75A40 Offset: 0x74E40 VA: 0x180075A40
	// RVA: 0x19A2B70 Offset: 0x19A1F70 VA: 0x1819A2B70
	private void Internal_SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x75DD0 Offset: 0x751D0 VA: 0x180075DD0
	// RVA: 0x19A2E90 Offset: 0x19A2290 VA: 0x1819A2E90
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x75FC0 Offset: 0x753C0 VA: 0x180075FC0
	// RVA: 0x19A0E90 Offset: 0x19A0290 VA: 0x1819A0E90
	private void Internal_DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	[NativeMethodAttribute] // RVA: 0x76120 Offset: 0x75520 VA: 0x180076120
	// RVA: 0x19A2AB0 Offset: 0x19A1EB0 VA: 0x1819A2AB0
	private void Internal_GenerateMips(RenderTexture rt) { }

	// RVA: 0x19A4B40 Offset: 0x19A3F40 VA: 0x1819A4B40
	public string get_name() { }

	// RVA: 0x19A4B80 Offset: 0x19A3F80 VA: 0x1819A4B80
	public void set_name(string value) { }

	[NativeMethodAttribute] // RVA: 0x76210 Offset: 0x75610 VA: 0x180076210
	// RVA: 0x19A0B40 Offset: 0x199FF40 VA: 0x1819A0B40
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x76360 Offset: 0x75760 VA: 0x180076360
	// RVA: 0x19A29C0 Offset: 0x19A1DC0 VA: 0x1819A29C0
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	[NativeMethodAttribute] // RVA: 0x76550 Offset: 0x75950 VA: 0x180076550
	// RVA: 0x19A2A40 Offset: 0x19A1E40 VA: 0x1819A2A40
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	[FreeFunctionAttribute] // RVA: 0x76770 Offset: 0x75B70 VA: 0x180076770
	// RVA: 0x19A28E0 Offset: 0x19A1CE0 VA: 0x1819A28E0
	private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x768D0 Offset: 0x75CD0 VA: 0x1800768D0
	// RVA: 0x19A2870 Offset: 0x19A1C70 VA: 0x1819A2870
	private void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x769B0 Offset: 0x75DB0 VA: 0x1800769B0
	// RVA: 0x19A4A60 Offset: 0x19A3E60 VA: 0x1819A4A60
	public void SetViewport(Rect pixelRect) { }

	[FreeFunctionAttribute] // RVA: 0x76B90 Offset: 0x75F90 VA: 0x180076B90
	// RVA: 0x19A0B80 Offset: 0x199FF80 VA: 0x1819A0B80
	private void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	[FreeFunctionAttribute] // RVA: 0x76CE0 Offset: 0x760E0 VA: 0x180076CE0
	// RVA: 0x19A0240 Offset: 0x199F640 VA: 0x1819A0240
	private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x76DF0 Offset: 0x761F0 VA: 0x180076DF0
	// RVA: 0x19A0130 Offset: 0x199F530 VA: 0x1819A0130
	private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x76FD0 Offset: 0x763D0 VA: 0x180076FD0
	// RVA: 0x19A2350 Offset: 0x19A1750 VA: 0x1819A2350
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x19A2230 Offset: 0x19A1630 VA: 0x1819A2230
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x19A1EF0 Offset: 0x19A12F0 VA: 0x1819A1EF0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	// RVA: 0x19A22B0 Offset: 0x19A16B0 VA: 0x1819A22B0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0x19A2760 Offset: 0x19A1B60 VA: 0x1819A2760
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x19A2160 Offset: 0x19A1560 VA: 0x1819A2160
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x19A2620 Offset: 0x19A1A20 VA: 0x1819A2620
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	// RVA: 0x19A2020 Offset: 0x19A1420 VA: 0x1819A2020
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x19A24E0 Offset: 0x19A18E0 VA: 0x1819A24E0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x19A23E0 Offset: 0x19A17E0 VA: 0x1819A23E0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x19A2450 Offset: 0x19A1850 VA: 0x1819A2450
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter) { }

	// RVA: 0x19A20E0 Offset: 0x19A14E0 VA: 0x1819A20E0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer) { }

	// RVA: 0x19A25A0 Offset: 0x19A19A0 VA: 0x1819A25A0
	public void GetTemporaryRT(int nameID, int width, int height) { }

	[FreeFunctionAttribute] // RVA: 0x770B0 Offset: 0x764B0 VA: 0x1800770B0
	// RVA: 0x19A1E90 Offset: 0x19A1290 VA: 0x1819A1E90
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A1FA0 Offset: 0x19A13A0 VA: 0x1819A1FA0
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A26F0 Offset: 0x19A1AF0 VA: 0x1819A26F0
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0x77240 Offset: 0x76640 VA: 0x180077240
	// RVA: 0x19A2DC0 Offset: 0x19A21C0 VA: 0x1819A2DC0
	public void ReleaseTemporaryRT(int nameID) { }

	[FreeFunctionAttribute] // RVA: 0x77350 Offset: 0x76750 VA: 0x180077350
	// RVA: 0x19A0A10 Offset: 0x199FE10 VA: 0x1819A0A10
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x19A0A90 Offset: 0x199FE90 VA: 0x1819A0A90
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunctionAttribute] // RVA: 0x77400 Offset: 0x76800 VA: 0x180077400
	// RVA: 0x19A33C0 Offset: 0x19A27C0 VA: 0x1819A33C0
	public void SetGlobalFloat(int nameID, float value) { }

	[FreeFunctionAttribute] // RVA: 0x77550 Offset: 0x76950 VA: 0x180077550
	// RVA: 0x19A3490 Offset: 0x19A2890 VA: 0x1819A3490
	public void SetGlobalInt(int nameID, int value) { }

	[FreeFunctionAttribute] // RVA: 0x776D0 Offset: 0x76AD0 VA: 0x1800776D0
	// RVA: 0x19A3AE0 Offset: 0x19A2EE0 VA: 0x1819A3AE0
	public void SetGlobalVector(int nameID, Vector4 value) { }

	[FreeFunctionAttribute] // RVA: 0x777D0 Offset: 0x76BD0 VA: 0x1800777D0
	// RVA: 0x19A3370 Offset: 0x19A2770 VA: 0x1819A3370
	public void SetGlobalColor(int nameID, Color value) { }

	[FreeFunctionAttribute] // RVA: 0x778D0 Offset: 0x76CD0 VA: 0x1800778D0
	// RVA: 0x19A3720 Offset: 0x19A2B20 VA: 0x1819A3720
	public void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	[FreeFunctionAttribute] // RVA: 0x779E0 Offset: 0x76DE0 VA: 0x1800779E0
	// RVA: 0x19A1BD0 Offset: 0x19A0FD0 VA: 0x1819A1BD0
	public void EnableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77AE0 Offset: 0x76EE0 VA: 0x180077AE0
	// RVA: 0x19A0E40 Offset: 0x19A0240 VA: 0x1819A0E40
	public void DisableShaderKeyword(string keyword) { }

	[FreeFunctionAttribute] // RVA: 0x77BB0 Offset: 0x76FB0 VA: 0x180077BB0
	// RVA: 0x19A49B0 Offset: 0x19A3DB0 VA: 0x1819A49B0
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	[FreeFunctionAttribute] // RVA: 0x77D10 Offset: 0x77110 VA: 0x180077D10
	// RVA: 0x19A4AB0 Offset: 0x19A3EB0 VA: 0x1819A4AB0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	[FreeFunctionAttribute] // RVA: 0x77EC0 Offset: 0x772C0 VA: 0x180077EC0
	// RVA: 0x19A39B0 Offset: 0x19A2DB0 VA: 0x1819A39B0
	public void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x78040 Offset: 0x77440 VA: 0x180078040
	// RVA: 0x19A3560 Offset: 0x19A2960 VA: 0x1819A3560
	public void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	[FreeFunctionAttribute] // RVA: 0x78110 Offset: 0x77510 VA: 0x180078110
	// RVA: 0x19A3770 Offset: 0x19A2B70 VA: 0x1819A3770
	private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	[FreeFunctionAttribute] // RVA: 0x782E0 Offset: 0x776E0 VA: 0x1800782E0
	// RVA: 0x19A31C0 Offset: 0x19A25C0 VA: 0x1819A31C0
	public void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x783B0 Offset: 0x777B0 VA: 0x1800783B0
	// RVA: 0x19A4870 Offset: 0x19A3C70 VA: 0x1819A4870
	private void SetShadowSamplingMode_Impl(ref RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	[FreeFunctionAttribute] // RVA: 0x78540 Offset: 0x77940 VA: 0x180078540
	// RVA: 0x19A0070 Offset: 0x199F470 VA: 0x1819A0070
	public void BeginSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x78650 Offset: 0x77A50 VA: 0x180078650
	// RVA: 0x19A1C20 Offset: 0x19A1020 VA: 0x1819A1C20
	public void EndSample(string name) { }

	[FreeFunctionAttribute] // RVA: 0x79AD0 Offset: 0x78ED0 VA: 0x180079AD0
	// RVA: 0x19A2C20 Offset: 0x19A2020 VA: 0x1819A2C20
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x19A3E10 Offset: 0x19A3210 VA: 0x1819A3E10
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x19A40D0 Offset: 0x19A34D0 VA: 0x1819A40D0
	public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	// RVA: 0x19A3EB0 Offset: 0x19A32B0 VA: 0x1819A3EB0
	public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x19A41E0 Offset: 0x19A35E0 VA: 0x1819A41E0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x19A42C0 Offset: 0x19A36C0 VA: 0x1819A42C0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x19A4500 Offset: 0x19A3900 VA: 0x1819A4500
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A4670 Offset: 0x19A3A70 VA: 0x1819A4670
	public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth) { }

	// RVA: 0x19A3D90 Offset: 0x19A3190 VA: 0x1819A3D90
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A3BA0 Offset: 0x19A2FA0 VA: 0x1819A3BA0
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A3C90 Offset: 0x19A3090 VA: 0x1819A3C90
	private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A1C70 Offset: 0x19A1070 VA: 0x1819A1C70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19A0F00 Offset: 0x19A0300 VA: 0x1819A0F00 Slot: 4
	public void Dispose() { }

	// RVA: 0x19A0FA0 Offset: 0x19A03A0 VA: 0x1819A0FA0
	private void Dispose(bool disposing) { }

	// RVA: 0x19A4B00 Offset: 0x19A3F00 VA: 0x1819A4B00
	public void .ctor() { }

	// RVA: 0x19A3120 Offset: 0x19A2520 VA: 0x1819A3120
	public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val) { }

	// RVA: 0x19A2F00 Offset: 0x19A2300 VA: 0x1819A2F00
	public void SetComputeFloatParams(ComputeShader computeShader, string name, float[] values) { }

	// RVA: 0x19A2F90 Offset: 0x19A2390 VA: 0x1819A2F90
	public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt) { }

	// RVA: 0x19A2E00 Offset: 0x19A2200 VA: 0x1819A2E00
	public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer) { }

	// RVA: 0x19A0E90 Offset: 0x19A0290 VA: 0x1819A0E90
	public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ) { }

	// RVA: 0x19A1D40 Offset: 0x19A1140 VA: 0x1819A1D40
	public void GenerateMips(RenderTexture rt) { }

	// RVA: 0x19A16F0 Offset: 0x19A0AF0 VA: 0x1819A16F0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x19A1620 Offset: 0x19A0A20 VA: 0x1819A1620
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x19A1690 Offset: 0x19A0A90 VA: 0x1819A1690
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x19A19B0 Offset: 0x19A0DB0 VA: 0x1819A19B0
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x19A1990 Offset: 0x19A0D90 VA: 0x1819A1990
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x19A1BA0 Offset: 0x19A0FA0 VA: 0x1819A1BA0
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x19A1250 Offset: 0x19A0650 VA: 0x1819A1250
	public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties) { }

	// RVA: 0x19A1000 Offset: 0x19A0400 VA: 0x1819A1000
	public void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, int shaderPass, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties) { }

	// RVA: 0x19A0CD0 Offset: 0x19A00D0 VA: 0x1819A0CD0
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x19A0D80 Offset: 0x19A0180 VA: 0x1819A0D80
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip) { }

	// RVA: 0x19A0BF0 Offset: 0x199FFF0 VA: 0x1819A0BF0
	public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY) { }

	// RVA: 0x19A0400 Offset: 0x199F800 VA: 0x1819A0400
	public void Blit(Texture source, RenderTargetIdentifier dest) { }

	// RVA: 0x19A02E0 Offset: 0x199F6E0 VA: 0x1819A02E0
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x19A0520 Offset: 0x199F920 VA: 0x1819A0520
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x19A0760 Offset: 0x199FB60 VA: 0x1819A0760
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x19A0880 Offset: 0x199FC80 VA: 0x1819A0880
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x19A0640 Offset: 0x199FA40 VA: 0x1819A0640
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x19A3410 Offset: 0x19A2810 VA: 0x1819A3410
	public void SetGlobalFloat(string name, float value) { }

	// RVA: 0x19A34E0 Offset: 0x19A28E0 VA: 0x1819A34E0
	public void SetGlobalInt(string name, int value) { }

	// RVA: 0x19A3A50 Offset: 0x19A2E50 VA: 0x1819A3A50
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x19A32E0 Offset: 0x19A26E0 VA: 0x1819A32E0
	public void SetGlobalColor(string name, Color value) { }

	// RVA: 0x19A3680 Offset: 0x19A2A80 VA: 0x1819A3680
	public void SetGlobalMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x19A3930 Offset: 0x19A2D30 VA: 0x1819A3930
	public void SetGlobalVectorArray(string propertyName, Vector4[] values) { }

	// RVA: 0x19A35B0 Offset: 0x19A29B0 VA: 0x1819A35B0
	public void SetGlobalMatrixArray(string propertyName, Matrix4x4[] values) { }

	// RVA: 0x19A3830 Offset: 0x19A2C30 VA: 0x1819A3830
	public void SetGlobalTexture(string name, RenderTargetIdentifier value) { }

	// RVA: 0x19A37D0 Offset: 0x19A2BD0 VA: 0x1819A37D0
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x19A38D0 Offset: 0x19A2CD0 VA: 0x1819A38D0
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element) { }

	// RVA: 0x19A3210 Offset: 0x19A2610 VA: 0x1819A3210
	public void SetGlobalBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x19A48D0 Offset: 0x19A3CD0 VA: 0x1819A48D0
	public void SetShadowSamplingMode(RenderTargetIdentifier shadowmap, ShadowSamplingMode mode) { }

	// RVA: 0x19A2BE0 Offset: 0x19A1FE0 VA: 0x1819A2BE0
	public void SetSinglePassStereo(SinglePassStereoMode mode) { }

	// RVA: 0x19A2C90 Offset: 0x19A2090 VA: 0x1819A2C90
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x19A3040 Offset: 0x19A2440 VA: 0x1819A3040
	private void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val) { }

	// RVA: 0x19A2950 Offset: 0x19A1D50 VA: 0x1819A2950
	private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x19A4A10 Offset: 0x19A3E10 VA: 0x1819A4A10
	private void SetViewport_Injected(ref Rect pixelRect) { }

	// RVA: 0x19A01D0 Offset: 0x199F5D0 VA: 0x1819A01D0
	private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x19A00C0 Offset: 0x199F4C0 VA: 0x1819A00C0
	private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x19A1E30 Offset: 0x19A1230 VA: 0x1819A1E30
	private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x19A09A0 Offset: 0x199FDA0 VA: 0x1819A09A0
	private void ClearRenderTarget_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x19A3A00 Offset: 0x19A2E00 VA: 0x1819A3A00
	private void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	// RVA: 0x19A3290 Offset: 0x19A2690 VA: 0x1819A3290
	private void SetGlobalColor_Injected(int nameID, ref Color value) { }

	// RVA: 0x19A3630 Offset: 0x19A2A30 VA: 0x1819A3630
	private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value) { }

	// RVA: 0x19A4950 Offset: 0x19A3D50 VA: 0x1819A4950
	private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	// RVA: 0x19A3D20 Offset: 0x19A3120 VA: 0x1819A3D20
	private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A3B30 Offset: 0x19A2F30 VA: 0x1819A3B30
	private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x19A3C20 Offset: 0x19A3020 VA: 0x1819A3C20
	private void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

}

