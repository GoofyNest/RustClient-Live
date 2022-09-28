public class Graphics // TypeDefIndex: 3389
{
	internal static readonly int kMaxDrawMeshInstanceCount; 

	public static RenderBuffer activeColorBuffer { get; }
	public static RenderBuffer activeDepthBuffer { get; }


	[FreeFunctionAttribute] 
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunctionAttribute] 
	private static RenderBuffer GetActiveColorBuffer() { }

	[FreeFunctionAttribute] 
	private static RenderBuffer GetActiveDepthBuffer() { }

	[FreeFunctionAttribute] 
	private static void Internal_SetNullRT() { }

	[NativeMethodAttribute] 
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	[FreeFunctionAttribute] 
	private static void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	[StaticAccessorAttribute] 
	public static void ClearRandomWriteTargets() { }

	[FreeFunctionAttribute] 
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[FreeFunctionAttribute] 
	[VisibleToOtherModulesAttribute] 
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunctionAttribute] 
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] 
	private static void Internal_DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunctionAttribute] 
	private static void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset) { }

	[FreeFunctionAttribute] 
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunctionAttribute] 
	private static void Internal_BlitMultiTap4(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[FreeFunctionAttribute] 
	private static void Blit2(Texture source, RenderTexture dest) { }

	[NativeMethodAttribute] 
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	public static RenderBuffer get_activeColorBuffer() { }

	public static RenderBuffer get_activeDepthBuffer() { }

	public static void SetRandomWriteTarget(int index, ComputeBuffer uav, bool preserveCounterValue) { }

	private static void DrawTextureImpl(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Color color, Material mat, int pass) { }

	public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	public static void DrawTexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material mat, int pass) { }

	public static void DrawTexture(Rect screenRect, Texture texture, Material mat, int pass) { }

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0) { }

	public static void Blit(Texture source, RenderTexture dest) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	public static void Blit(Texture source, Material mat, int pass) { }

	public static void Blit(Texture source, Material mat) { }

	public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, Vector2[] offsets) { }

	[ExcludeFromDocsAttribute] 
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] 
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) { }

	[ExcludeFromDocsAttribute] 
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	[ExcludeFromDocsAttribute] 
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, bool castShadows, bool receiveShadows) { }

	[ExcludeFromDocsAttribute] 
	public static void DrawMeshInstancedIndirect(Mesh mesh, int submeshIndex, Material material, Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) { }

	[ExcludeFromDocsAttribute] 
	public static void DrawTexture(Rect screenRect, Texture texture) { }

	[ExcludeFromDocsAttribute] 
	public static void SetRenderTarget(RenderTexture rt) { }

	[ExcludeFromDocsAttribute] 
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	[ExcludeFromDocsAttribute] 
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	[ExcludeFromDocsAttribute] 
	public static void SetRandomWriteTarget(int index, ComputeBuffer uav) { }

	private static void .cctor() { }

	private static void GetActiveColorBuffer_Injected(out RenderBuffer ret) { }

	private static void GetActiveDepthBuffer_Injected(out RenderBuffer ret) { }

	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	private static void Internal_DrawMeshInstancedIndirect_Injected(Mesh mesh, int submeshIndex, Material material, ref Bounds bounds, ComputeBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

}

public static class Graphics // TypeDefIndex: 8193
{

	public static extern IntPtr GetRenderEventFunc() { }

}

public static class Graphics.BufferReadback // TypeDefIndex: 8194
{

	public static extern IntPtr CreateForTexture(IntPtr tex, uint width, uint height, uint format) { }

	public static extern IntPtr CreateForBuffer(IntPtr buf, uint size) { }

	public static extern void Destroy(IntPtr inst) { }

	public static extern void IssueRead(IntPtr inst) { }

	public static extern uint GetDataSize(IntPtr inst) { }

	public static extern uint GetDataStride(IntPtr inst) { }

	public static extern void GetData(IntPtr inst, ref byte data) { }

	public static extern void GetData(IntPtr inst, ref Color32 data) { }

	public static extern void GetData(IntPtr inst, ref float data) { }

}

public class Graphics : ConsoleSystem // TypeDefIndex: 13620
{
	private const float MinShadowDistance = 100;
	private const float MaxShadowDistance2Split = 600;
	private const float MaxShadowDistance4Split = 1000;
	private static float _shadowdistance; 
	[ClientVar] 
	public static int shadowmode; 
	[ClientVar] 
	public static int shadowlights; 
	private static int _shadowquality; 
	[ClientVar] 
	public static bool grassshadows; 
	[ClientVar] 
	public static bool contactshadows; 
	[ClientVar] 
	public static float drawdistance; 
	private static float _fov; 
	[ClientVar] 
	public static bool hud; 
	[ClientVar] 
	public static bool chat; 
	[ClientVar] 
	public static bool branding; 
	[ClientVar] 
	public static int compass; 
	[ClientVar] 
	public static bool dof; 
	[ClientVar] 
	public static float dof_aper; 
	[ClientVar] 
	public static float dof_blur; 
	[ClientVar] 
	public static int dof_mode; 
	[ClientVar] 
	public static float dof_focus_dist; 
	[ClientVar] 
	public static float dof_focus_time; 
	[ClientVar] 
	public static bool dof_debug; 
	public static BaseEntity dof_focus_target_entity; 
	[ClientVar] 
	public static bool vm_fov_scale; 
	[ClientVar] 
	public static bool vm_horizontal_flip; 
	private static int _resolution; 
	private static List<Resolution> uniqueResolutions; 
	private static bool firstResolutionSet; 
	private static int _screenmode; 
	private static float _uiscale; 
	private static int _anisotropic; 
	private static int _parallax; 
	private static bool _impostorshadows; 
	private static int _showtexeldensity; 
	private static bool _waves; 
	[ClientVar] 
	public static bool viewModelCamera; 
	[ClientVar] 
	public static bool viewModelDepth; 
	[ClientVar] 
	public static int reflexMode; 
	[ClientVar] 
	public static int reflexIntervalUs; 
	[ClientVar] 
	public static bool reflexLatencyMarker; 
	[ClientVar] 
	public static bool useMarkersToOptimize; 
	[ClientVar] 
	public static int dlss; 
	private static float _renderScale; 
	[ClientVar] 
	public static float jitterSpread; 
	[ClientVar] 
	public static bool disableLightLod; 
	[ClientVar] 
	public static bool aggressiveShadowLod; 
	private static bool _aggressiveShadowLodWearable; 

	[ClientVar] 
	public static int quality { get; set; }
	[ClientVar] 
	public static float shadowdistance { get; set; }
	[ClientVar] 
	public static int shadowcascades { get; set; }
	[ClientVar] 
	public static int shadowquality { get; set; }
	[ClientVar] 
	public static float fov { get; set; }
	[ClientVar] 
	public static float lodbias { get; set; }
	[ClientVar] 
	public static int shaderlod { get; set; }
	[ClientVar] 
	public static int vsync { get; set; }
	[ClientVar] 
	public static int resolution { get; set; }
	[ClientVar] 
	public static int screenmode { get; set; }
	[ClientVar] 
	public static float uiscale { get; set; }
	[ClientVar] 
	public static int af { get; set; }
	[ClientVar] 
	public static int parallax { get; set; }
	[ClientVar] 
	public static bool itemskins { get; set; }
	[ClientVar] 
	public static bool itemskinunload { get; set; }
	[ClientVar] 
	public static float itemskintimeout { get; set; }
	[ClientVar] 
	public static bool impostorshadows { get; set; }
	[ClientVar] 
	public static int showtexeldensity { get; set; }
	[ClientVar] 
	public static bool waves { get; set; }
	[ClientVar] 
	public static int maxQueuedFrames { get; set; }
	[ClientVar] 
	public static float renderScale { get; set; }
	[ClientVar] 
	public static bool aggressiveShadowLodWearable { get; set; }


	public static int get_quality() { }

	public static void set_quality(int value) { }

	public static float EnforceShadowDistanceBounds(float distance) { }

	public static float get_shadowdistance() { }

	public static void set_shadowdistance(float value) { }

	public static int get_shadowcascades() { }

	public static void set_shadowcascades(int value) { }

	public static int get_shadowquality() { }

	public static void set_shadowquality(int value) { }

	public static float get_fov() { }

	public static void set_fov(float value) { }

	public static float get_lodbias() { }

	public static void set_lodbias(float value) { }

	[ClientVar] 
	public static void dof_focus_target(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void dof_nudge(ConsoleSystem.Arg arg) { }

	public static int get_shaderlod() { }

	public static void set_shaderlod(int value) { }

	public static int get_vsync() { }

	public static void set_vsync(int value) { }

	[ClientVar] 
	public static void resolutions(ConsoleSystem.Arg arg) { }

	public static int get_resolution() { }

	public static void set_resolution(int value) { }

	public static List<Resolution> GetUniqueResolutions() { }

	private static void CacheResolutions() { }

	public static int get_screenmode() { }

	public static void set_screenmode(int value) { }

	private static void ApplyScreenSettings() { }

	private static FullScreenMode GetScreenMode() { }

	[ClientVar] 
	public static void dof_focus_lookingat(ConsoleSystem.Arg arg) { }

	public static float get_uiscale() { }

	public static void set_uiscale(float value) { }

	public static int get_af() { }

	public static void set_af(int value) { }

	public static int get_parallax() { }

	public static void set_parallax(int value) { }

	public static bool get_itemskins() { }

	public static void set_itemskins(bool value) { }

	public static bool get_itemskinunload() { }

	public static void set_itemskinunload(bool value) { }

	public static float get_itemskintimeout() { }

	public static void set_itemskintimeout(float value) { }

	public static bool get_impostorshadows() { }

	public static void set_impostorshadows(bool value) { }

	public static int get_showtexeldensity() { }

	public static void set_showtexeldensity(int value) { }

	public static bool get_waves() { }

	public static void set_waves(bool value) { }

	public static int get_maxQueuedFrames() { }

	public static void set_maxQueuedFrames(int value) { }

	public static float get_renderScale() { }

	public static void set_renderScale(float value) { }

	[ClientVar] 
	public static void SetMipMapBias(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void ResetMipMapBias() { }

	[ClientVar] 
	public static void ReportShadowCasters(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void ReportParticleSystems(ConsoleSystem.Arg arg) { }

	public static bool get_aggressiveShadowLodWearable() { }

	public static void set_aggressiveShadowLodWearable(bool value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Graphics.<>c // TypeDefIndex: 13621
{
	public static readonly Graphics.<>c <>9; 
	public static Func<Resolution, Vector2Int> <>9__60_0; 
	public static Func<Resolution, int> <>9__60_4; 
	public static Func<IGrouping<Vector2Int, Resolution>, Resolution> <>9__60_1; 
	public static Func<Resolution, int> <>9__60_2; 
	public static Func<Resolution, int> <>9__60_3; 


	private static void .cctor() { }

	public void .ctor() { }

	internal Vector2Int <CacheResolutions>b__60_0(Resolution r) { }

	internal Resolution <CacheResolutions>b__60_1(IGrouping<Vector2Int, Resolution> g) { }

	internal int <CacheResolutions>b__60_4(Resolution r) { }

	internal int <CacheResolutions>b__60_2(Resolution r) { }

	internal int <CacheResolutions>b__60_3(Resolution r) { }

}

