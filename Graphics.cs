public class Graphics // TypeDefIndex: 3389
{	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x13A22

	// Properties
	public static RenderBuffer activeColorBuffer { get; }
	public static RenderBuffer activeDepthBuffer { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x844B0 Offset: 0x838B0 VA: 0x1800844B0
	// RVA: 0x1829D30 Offset: 0x1829130 VA: 0x181829D30
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunctionAttribute] // RVA: 0x84610 Offset: 0x83A10 VA: 0x180084610
	// RVA: 0x1829680 Offset: 0x1828A80 VA: 0x181829680
	private static RenderBuffer GetActiveColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x846B0 Offset: 0x83AB0 VA: 0x1800846B0
	// RVA: 0x1829740 Offset: 0x1828B40 VA: 0x181829740
	private static RenderBuffer GetActiveDepthBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x84760 Offset: 0x83B60 VA: 0x180084760
	// RVA: 0x1829D60 Offset: 0x1829160 VA: 0x181829D60
	private static void Internal_SetNullRT() { }

	[NativeMethodAttribute] // RVA: 0x84920 Offset: 0x83D20 VA: 0x180084920
	// RVA: 0x1829E00 Offset: 0x1829200 VA: 0x181829E00
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunctionAttribute] // RVA: 0x849B0 Offset: 0x83DB0 VA: 0x1800849B0
	// RVA: 0x1829EB0 Offset: 0x18292B0 VA: 0x181829EB0
	private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[StaticAccessorAttribute] // RVA: 0x84C10 Offset: 0x84010 VA: 0x180084C10
	// RVA: 0x1827D30 Offset: 0x1827130 VA: 0x181827D30
	public static void ClearRandomWriteTargets() { }

	[FreeFunctionAttribute] // RVA: 0x84DA0 Offset: 0x841A0 VA: 0x180084DA0
	// RVA: 0x1829A80 Offset: 0x1828E80 VA: 0x181829A80
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[FreeFunctionAttribute] // RVA: 0x84EC0 Offset: 0x842C0 VA: 0x180084EC0
	[VisibleToOtherModulesAttribute] // RVA: 0x84EC0 Offset: 0x842C0 VA: 0x180084EC0
	// RVA: 0x1829CF0 Offset: 0x18290F0 VA: 0x181829CF0
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunctionAttribute] // RVA: 0x852C0 Offset: 0x846C0 VA: 0x1800852C0
	// RVA: 0x1829B90 Offset: 0x1828F90 VA: 0x181829B90
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x854A0 Offset: 0x848A0 VA: 0x1800854A0
	// RVA: 0x1829920 Offset: 0x1828D20 VA: 0x181829920
	private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] // RVA: 0x855D0 Offset: 0x849D0 VA: 0x1800855D0
	// RVA: 0x1829CA0 Offset: 0x18290A0 VA: 0x181829CA0
	private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[FreeFunctionAttribute] // RVA: 0x856B0 Offset: 0x84AB0 VA: 0x1800856B0
	// RVA: 0x18297C0 Offset: 0x1828BC0 VA: 0x1818297C0
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunctionAttribute] // RVA: 0x85850 Offset: 0x84C50 VA: 0x180085850
	// RVA: 0x1829830 Offset: 0x1828C30 VA: 0x181829830
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[FreeFunctionAttribute] // RVA: 0x85B10 Offset: 0x84F10 VA: 0x180085B10
	// RVA: 0x1827880 Offset: 0x1826C80 VA: 0x181827880
	private static void Blit2(Texture source, RenderTexture dest) { }

	[NativeMethodAttribute] // RVA: 0x85C30 Offset: 0x85030 VA: 0x180085C30
	// RVA: 0x1829600 Offset: 0x1828A00 VA: 0x181829600
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0x182A250 Offset: 0x1829650 VA: 0x18182A250
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182A350 Offset: 0x1829750 VA: 0x18182A350
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182A610 Offset: 0x1829A10 VA: 0x18182A610
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182A7A0 Offset: 0x1829BA0 VA: 0x18182A7A0
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x182AA20 Offset: 0x1829E20 VA: 0x18182AA20
	public static RenderBuffer get_activeColorBuffer() { }

	// RVA: 0x182AAF0 Offset: 0x1829EF0 VA: 0x18182AAF0
	public static RenderBuffer get_activeDepthBuffer() { }

	// RVA: 0x1829F10 Offset: 0x1829310 VA: 0x181829F10
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	// RVA: 0x1828F10 Offset: 0x1828310 VA: 0x181828F10
	private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass) { }

	// RVA: 0x18291A0 Offset: 0x18285A0 VA: 0x1818291A0
	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	// RVA: 0x1829090 Offset: 0x1828490 VA: 0x181829090
	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	// RVA: 0x1829370 Offset: 0x1828770 VA: 0x181829370
	public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass) { }

	// RVA: 0x1828220 Offset: 0x1827620 VA: 0x181828220
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x1828380 Offset: 0x1827780 VA: 0x181828380
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x1828C60 Offset: 0x1828060 VA: 0x181828C60
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x1827E70 Offset: 0x1827270 VA: 0x181827E70
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x1828E50 Offset: 0x1828250 VA: 0x181828E50
	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0) { }

	// RVA: 0x1827BD0 Offset: 0x1826FD0 VA: 0x181827BD0
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x1827B30 Offset: 0x1826F30 VA: 0x181827B30
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x1827C50 Offset: 0x1827050 VA: 0x181827C50
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x1827A90 Offset: 0x1826E90 VA: 0x181827A90
	public static void Blit(Texture source, Material mat, int pass) { }

	// RVA: 0x18279C0 Offset: 0x1826DC0 VA: 0x1818279C0
	public static void Blit(Texture source, Material mat) { }

	// RVA: 0x18278D0 Offset: 0x1826CD0 VA: 0x1818278D0
	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18289D0 Offset: 0x1827DD0 VA: 0x1818289D0
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1828850 Offset: 0x1827C50 VA: 0x181828850
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1828510 Offset: 0x1827910 VA: 0x181828510
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18286A0 Offset: 0x1827AA0 VA: 0x1818286A0
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1827D60 Offset: 0x1827160 VA: 0x181827D60
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18294A0 Offset: 0x18288A0 VA: 0x1818294A0
	public static void DrawTexture(Rect screenRect, Texture texture) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x182A8E0 Offset: 0x1829CE0 VA: 0x18182A8E0
	public static void SetRenderTarget(RenderTexture rt) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x182A950 Offset: 0x1829D50 VA: 0x18182A950
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x182A4B0 Offset: 0x18298B0 VA: 0x18182A4B0
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x182A0A0 Offset: 0x18294A0 VA: 0x18182A0A0
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav) { }

	// RVA: 0x182A9C0 Offset: 0x1829DC0 VA: 0x18182A9C0
	private static void .cctor() { }

	// RVA: 0x1829640 Offset: 0x1828A40 VA: 0x181829640
	private static void GetActiveColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x1829700 Offset: 0x1828B00 VA: 0x181829700
	private static void GetActiveDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x1829D90 Offset: 0x1829190 VA: 0x181829D90
	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x1829A30 Offset: 0x1828E30 VA: 0x181829A30
	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

	// RVA: 0x1829B10 Offset: 0x1828F10 VA: 0x181829B10
	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x18298A0 Offset: 0x1828CA0 VA: 0x1818298A0
	private static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

}

public static class Graphics // TypeDefIndex: 8219
{	// Methods

	// RVA: 0x10676B0 Offset: 0x1066AB0 VA: 0x1810676B0
	public static extern IntPtr GetRenderEventFunc() { }

}

public static class Graphics.BufferReadback // TypeDefIndex: 8220
{	// Methods

	// RVA: 0x1063090 Offset: 0x1062490 VA: 0x181063090
	public static extern IntPtr CreateForTexture(IntPtr tex, uint width, uint height, uint format) { }

	// RVA: 0x1063000 Offset: 0x1062400 VA: 0x181063000
	public static extern IntPtr CreateForBuffer(IntPtr buf, uint size) { }

	// RVA: 0x1063130 Offset: 0x1062530 VA: 0x181063130
	public static extern void Destroy(IntPtr inst) { }

	// RVA: 0x1063460 Offset: 0x1062860 VA: 0x181063460
	public static extern void IssueRead(IntPtr inst) { }

	// RVA: 0x10631B0 Offset: 0x10625B0 VA: 0x1810631B0
	public static extern uint GetDataSize(IntPtr inst) { }

	// RVA: 0x1063230 Offset: 0x1062630 VA: 0x181063230
	public static extern uint GetDataStride(IntPtr inst) { }

	// RVA: 0x10633D0 Offset: 0x10627D0 VA: 0x1810633D0
	public static extern void GetData(IntPtr inst, ref byte data) { }

	// RVA: 0x1063340 Offset: 0x1062740 VA: 0x181063340
	public static extern void GetData(IntPtr inst, ref Color32 data) { }

	// RVA: 0x10632B0 Offset: 0x10626B0 VA: 0x1810632B0
	public static extern void GetData(IntPtr inst, ref float data) { }

}

public class Graphics : ConsoleSystem // TypeDefIndex: 11924
{	// Fields
	private const float MinShadowDistance = 100;
	private const float MaxShadowDistance2Split = 600;
	private const float MaxShadowDistance4Split = 1000;
	private static float _shadowdistance; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int shadowmode; // 0x4
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int shadowlights; // 0x8
	private static int _shadowquality; // 0xC
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool grassshadows; // 0x10
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool contactshadows; // 0x11
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float drawdistance; // 0x14
	private static float _fov; // 0x18
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool hud; // 0x1C
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool chat; // 0x1D
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool branding; // 0x1E
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int compass; // 0x20
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool dof; // 0x24
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float dof_aper; // 0x28
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float dof_blur; // 0x2C
	[ClientVar] // RVA: 0xA25B0 Offset: 0xA19B0 VA: 0x1800A25B0
	public static int dof_mode; // 0x30
	[ClientVar] // RVA: 0xA2640 Offset: 0xA1A40 VA: 0x1800A2640
	public static float dof_focus_dist; // 0x34
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float dof_focus_time; // 0x38
	[ClientVar] // RVA: 0xA2780 Offset: 0xA1B80 VA: 0x1800A2780
	public static bool dof_debug; // 0x3C
	public static BaseEntity dof_focus_target_entity; // 0x40
	[ClientVar] // RVA: 0xA27E0 Offset: 0xA1BE0 VA: 0x1800A27E0
	public static bool vm_fov_scale; // 0x48
	[ClientVar] // RVA: 0xA2850 Offset: 0xA1C50 VA: 0x1800A2850
	public static bool vm_horizontal_flip; // 0x49
	private static int _resolution; // 0x4C
	private static List<Resolution> uniqueResolutions; // 0x50
	private static bool firstResolutionSet; // 0x58
	private static int _screenmode; // 0x5C
	private static float _uiscale; // 0x60
	private static int _anisotropic; // 0x64
	private static int _parallax; // 0x68
	private static bool _impostorshadows; // 0x6C
	private static int _showtexeldensity; // 0x70
	private static bool _waves; // 0x74
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool viewModelCamera; // 0x75
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool viewModelDepth; // 0x76
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int reflexMode; // 0x78
	[ClientVar] // RVA: 0xA2A60 Offset: 0xA1E60 VA: 0x1800A2A60
	public static int reflexIntervalUs; // 0x7C
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static bool reflexLatencyMarker; // 0x80
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static bool useMarkersToOptimize; // 0x81
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int dlss; // 0x84
	private static float _renderScale; // 0x88
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float jitterSpread; // 0x8C
	[ClientVar] // RVA: 0xA2CF0 Offset: 0xA20F0 VA: 0x1800A2CF0
	public static bool disableLightLod; // 0x90
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool aggressiveShadowLod; // 0x91
	private static bool _aggressiveShadowLodWearable; // 0x92

	// Properties
	[ClientVar] // RVA: 0xA3290 Offset: 0xA2690 VA: 0x1800A3290
	public static int quality { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float shadowdistance { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int shadowcascades { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int shadowquality { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float fov { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float lodbias { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int shaderlod { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int vsync { get; set; }
	[ClientVar] // RVA: 0xA3700 Offset: 0xA2B00 VA: 0x1800A3700
	public static int resolution { get; set; }
	[ClientVar] // RVA: 0xA3840 Offset: 0xA2C40 VA: 0x1800A3840
	public static int screenmode { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float uiscale { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int af { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int parallax { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool itemskins { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool itemskinunload { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float itemskintimeout { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool impostorshadows { get; set; }
	[ClientVar] // RVA: 0xA3ED0 Offset: 0xA32D0 VA: 0x1800A3ED0
	public static int showtexeldensity { get; set; }
	[ClientVar] // RVA: 0xA4030 Offset: 0xA3430 VA: 0x1800A4030
	public static bool waves { get; set; }
	[ClientVar] // RVA: 0xA4140 Offset: 0xA3540 VA: 0x1800A4140
	public static int maxQueuedFrames { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float renderScale { get; set; }
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool aggressiveShadowLodWearable { get; set; }

	// Methods

	// RVA: 0x6E2F50 Offset: 0x6E2350 VA: 0x1806E2F50
	public static int get_quality() { }

	// RVA: 0x6E3C70 Offset: 0x6E3070 VA: 0x1806E3C70
	public static void set_quality(int value) { }

	// RVA: 0x6E1960 Offset: 0x6E0D60 VA: 0x1806E1960
	public static float EnforceShadowDistanceBounds(float distance) { }

	// RVA: 0x6E30A0 Offset: 0x6E24A0 VA: 0x1806E30A0
	public static float get_shadowdistance() { }

	// RVA: 0x6E42A0 Offset: 0x6E36A0 VA: 0x1806E42A0
	public static void set_shadowdistance(float value) { }

	// RVA: 0x6E3090 Offset: 0x6E2490 VA: 0x1806E3090
	public static int get_shadowcascades() { }

	// RVA: 0x6E41E0 Offset: 0x6E35E0 VA: 0x1806E41E0
	public static void set_shadowcascades(int value) { }

	// RVA: 0x6E3100 Offset: 0x6E2500 VA: 0x1806E3100
	public static int get_shadowquality() { }

	// RVA: 0x6E4320 Offset: 0x6E3720 VA: 0x1806E4320
	public static void set_shadowquality(int value) { }

	// RVA: 0x6E2CF0 Offset: 0x6E20F0 VA: 0x1806E2CF0
	public static float get_fov() { }

	// RVA: 0x6E38E0 Offset: 0x6E2CE0 VA: 0x1806E38E0
	public static void set_fov(float value) { }

	// RVA: 0x6E2ED0 Offset: 0x6E22D0 VA: 0x1806E2ED0
	public static float get_lodbias() { }

	// RVA: 0x6E3B50 Offset: 0x6E2F50 VA: 0x1806E3B50
	public static void set_lodbias(float value) { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	// RVA: 0x6E2960 Offset: 0x6E1D60 VA: 0x1806E2960
	public static void dof_focus_target(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6E2B50 Offset: 0x6E1F50 VA: 0x1806E2B50
	public static void dof_nudge(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E3080 Offset: 0x6E2480 VA: 0x1806E3080
	public static int get_shaderlod() { }

	// RVA: 0x6E4170 Offset: 0x6E3570 VA: 0x1806E4170
	public static void set_shaderlod(int value) { }

	// RVA: 0x6E3360 Offset: 0x6E2760 VA: 0x1806E3360
	public static int get_vsync() { }

	// RVA: 0x6E45F0 Offset: 0x6E39F0 VA: 0x1806E45F0
	public static void set_vsync(int value) { }

	[ClientVar] // RVA: 0xA2E30 Offset: 0xA2230 VA: 0x1800A2E30
	// RVA: 0x6E33D0 Offset: 0x6E27D0 VA: 0x1806E33D0
	public static void resolutions(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E2FC0 Offset: 0x6E23C0 VA: 0x1806E2FC0
	public static int get_resolution() { }

	// RVA: 0x6E3E40 Offset: 0x6E3240 VA: 0x1806E3E40
	public static void set_resolution(int value) { }

	// RVA: 0x6E1AB0 Offset: 0x6E0EB0 VA: 0x1806E1AB0
	public static List<Resolution> GetUniqueResolutions() { }

	// RVA: 0x6E15E0 Offset: 0x6E09E0 VA: 0x1806E15E0
	private static void CacheResolutions() { }

	// RVA: 0x6E3020 Offset: 0x6E2420 VA: 0x1806E3020
	public static int get_screenmode() { }

	// RVA: 0x6E40E0 Offset: 0x6E34E0 VA: 0x1806E40E0
	public static void set_screenmode(int value) { }

	// RVA: 0x6E1430 Offset: 0x6E0830 VA: 0x1806E1430
	private static void ApplyScreenSettings() { }

	// RVA: 0x6E1A30 Offset: 0x6E0E30 VA: 0x1806E1A30
	private static FullScreenMode GetScreenMode() { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	// RVA: 0x6E28C0 Offset: 0x6E1CC0 VA: 0x1806E28C0
	public static void dof_focus_lookingat(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E3300 Offset: 0x6E2700 VA: 0x1806E3300
	public static float get_uiscale() { }

	// RVA: 0x6E4530 Offset: 0x6E3930 VA: 0x1806E4530
	public static void set_uiscale(float value) { }

	// RVA: 0x6E2C30 Offset: 0x6E2030 VA: 0x1806E2C30
	public static int get_af() { }

	// RVA: 0x6E35C0 Offset: 0x6E29C0 VA: 0x1806E35C0
	public static void set_af(int value) { }

	// RVA: 0x6E2EF0 Offset: 0x6E22F0 VA: 0x1806E2EF0
	public static int get_parallax() { }

	// RVA: 0x6E3BD0 Offset: 0x6E2FD0 VA: 0x1806E3BD0
	public static void set_parallax(int value) { }

	// RVA: 0x6E2DB0 Offset: 0x6E21B0 VA: 0x1806E2DB0
	public static bool get_itemskins() { }

	// RVA: 0x6E3A20 Offset: 0x6E2E20 VA: 0x1806E3A20
	public static void set_itemskins(bool value) { }

	// RVA: 0x6E2E70 Offset: 0x6E2270 VA: 0x1806E2E70
	public static bool get_itemskinunload() { }

	// RVA: 0x6E3AF0 Offset: 0x6E2EF0 VA: 0x1806E3AF0
	public static void set_itemskinunload(bool value) { }

	// RVA: 0x6E2E10 Offset: 0x6E2210 VA: 0x1806E2E10
	public static float get_itemskintimeout() { }

	// RVA: 0x6E3A80 Offset: 0x6E2E80 VA: 0x1806E3A80
	public static void set_itemskintimeout(float value) { }

	// RVA: 0x6E2D50 Offset: 0x6E2150 VA: 0x1806E2D50
	public static bool get_impostorshadows() { }

	// RVA: 0x6E39A0 Offset: 0x6E2DA0 VA: 0x1806E39A0
	public static void set_impostorshadows(bool value) { }

	// RVA: 0x6E3160 Offset: 0x6E2560 VA: 0x1806E3160
	public static int get_showtexeldensity() { }

	// RVA: 0x6E4490 Offset: 0x6E3890 VA: 0x1806E4490
	public static void set_showtexeldensity(int value) { }

	// RVA: 0x6E3370 Offset: 0x6E2770 VA: 0x1806E3370
	public static bool get_waves() { }

	// RVA: 0x6E4600 Offset: 0x6E3A00 VA: 0x1806E4600
	public static void set_waves(bool value) { }

	// RVA: 0x6E2EE0 Offset: 0x6E22E0 VA: 0x1806E2EE0
	public static int get_maxQueuedFrames() { }

	// RVA: 0x6E3BC0 Offset: 0x6E2FC0 VA: 0x1806E3BC0
	public static void set_maxQueuedFrames(int value) { }

	// RVA: 0x6E2F60 Offset: 0x6E2360 VA: 0x1806E2F60
	public static float get_renderScale() { }

	// RVA: 0x6E3D80 Offset: 0x6E3180 VA: 0x1806E3D80
	public static void set_renderScale(float value) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6E2400 Offset: 0x6E1800 VA: 0x1806E2400
	public static void SetMipMapBias(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6E2370 Offset: 0x6E1770 VA: 0x1806E2370
	public static void ResetMipMapBias() { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	// RVA: 0x6E1EE0 Offset: 0x6E12E0 VA: 0x1806E1EE0
	public static void ReportShadowCasters(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	// RVA: 0x6E1B70 Offset: 0x6E0F70 VA: 0x1806E1B70
	public static void ReportParticleSystems(ConsoleSystem.Arg arg) { }

	// RVA: 0x6E2C90 Offset: 0x6E2090 VA: 0x1806E2C90
	public static bool get_aggressiveShadowLodWearable() { }

	// RVA: 0x6E36E0 Offset: 0x6E2AE0 VA: 0x1806E36E0
	public static void set_aggressiveShadowLodWearable(bool value) { }

	// RVA: 0x6E2860 Offset: 0x6E1C60 VA: 0x1806E2860
	public void .ctor() { }

	// RVA: 0x6E24F0 Offset: 0x6E18F0 VA: 0x1806E24F0
	private static void .cctor() { }

}

private sealed class Graphics.<>c // TypeDefIndex: 11925
{	// Fields
	public static readonly Graphics.<>c <>9; // 0x0
	public static Func<Resolution, Vector2Int> <>9__60_0; // 0x8
	public static Func<Resolution, int> <>9__60_4; // 0x10
	public static Func<IGrouping<Vector2Int, Resolution>, Resolution> <>9__60_1; // 0x18
	public static Func<Resolution, int> <>9__60_2; // 0x20
	public static Func<Resolution, int> <>9__60_3; // 0x28

	// Methods

	// RVA: 0x36C100 Offset: 0x36B500 VA: 0x18036C100
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x36BC60 Offset: 0x36B060 VA: 0x18036BC60
	internal Vector2Int <CacheResolutions>b__60_0(Resolution r) { }

	// RVA: 0x36BCB0 Offset: 0x36B0B0 VA: 0x18036BCB0
	internal Resolution <CacheResolutions>b__60_1(IGrouping<Vector2Int, Resolution> g) { }

	// RVA: 0x36BE20 Offset: 0x36B220 VA: 0x18036BE20
	internal int <CacheResolutions>b__60_4(Resolution r) { }

	// RVA: 0x36BDE0 Offset: 0x36B1E0 VA: 0x18036BDE0
	internal int <CacheResolutions>b__60_2(Resolution r) { }

	// RVA: 0x36BE00 Offset: 0x36B200 VA: 0x18036BE00
	internal int <CacheResolutions>b__60_3(Resolution r) { }

}

