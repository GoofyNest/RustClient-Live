public class PostProcessVolumeLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 10276
{	public float distance; // 0x18
	private LODCell cell; // 0x20
	private PostProcessVolume postProcessVolume; // 0x28
	private LODEnvironmentMode environmentMode; // 0x30


	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private float GetDistance() { }

	public void ChangeLOD() { }

	public void RefreshLOD() { }

	public void .ctor() { }

}

public class PostProcessLayer : MonoBehaviour // TypeDefIndex: 11734
{	private const float updateRate = 0,1;
	private RenderTexture colorBuffer; // 0x18
	private RenderTexture depthBuffer; // 0x20
	private RenderTexture motionBuffer; // 0x28
	private RenderTexture colorOutput; // 0x30
	private Camera renderingCamera; // 0x38
	private Material renderScaleMaterial; // 0x40
	private HashSet<Shader> mipmapShaders; // 0x48
	private Nullable<PostProcessLayer.ScalingMode> scalingMode; // 0x50
	private float prevRenderScale; // 0x58
	private NVSDK_NGX_PerfQuality_Value prevPerfQuality; // 0x5C
	private uint prevScreenWidth; // 0x60
	private uint prevScreenHeight; // 0x64
	private float prevUpdateTime; // 0x68
	private bool screenshotMode; // 0x6C
	private bool firstDLSSPass; // 0x6D
	private DlSSRecommendedSettings dlssRecommendedSettings; // 0x70
	private GCHandle dlssDataHandle; // 0x8C
	private CommandBuffer afterEverythingCommandBuffer; // 0x90
	public Transform volumeTrigger; // 0x98
	public LayerMask volumeLayer; // 0xA0
	public bool stopNaNPropagation; // 0xA4
	public bool finalBlitToCameraTarget; // 0xA5
	public PostProcessLayer.Antialiasing antialiasingMode; // 0xA8
	public TemporalAntialiasing temporalAntialiasing; // 0xB0
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing; // 0xB8
	public FastApproximateAntialiasing fastApproximateAntialiasing; // 0xC0
	public Fog fog; // 0xC8
	private Dithering dithering; // 0xD0
	public PostProcessDebugLayer debugLayer; // 0xD8
	public RenderTextureFormat intermediateFormat; // 0xE0
	private RenderTextureFormat prevIntermediateFormat; // 0xE4
	private bool supportsIntermediateFormat; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PostProcessResources m_Resources; // 0xF0
	[PreserveAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private bool m_ShowToolkit; // 0xF8
	[PreserveAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private bool m_ShowCustomSorter; // 0xF9
	public bool breakBeforeColorGrading; // 0xFA
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeTransparentBundles; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeStackBundles; // 0x108
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<PostProcessLayer.SerializedBundleRef> m_AfterStackBundles; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> <sortedBundles>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <haveBundlesBeenInited>k__BackingField; // 0x120
	private Dictionary<Type, PostProcessBundle> m_Bundles; // 0x128
	private PropertySheetFactory m_PropertySheetFactory; // 0x130
	private CommandBuffer m_LegacyCmdBufferBeforeReflections; // 0x138
	private CommandBuffer m_LegacyCmdBufferBeforeLighting; // 0x140
	private CommandBuffer m_LegacyCmdBufferOpaque; // 0x148
	private CommandBuffer m_LegacyCmdBuffer; // 0x150
	private Camera m_Camera; // 0x158
	private PostProcessRenderContext m_CurrentContext; // 0x160
	private LogHistogram m_LogHistogram; // 0x168
	private bool m_SettingsUpdateNeeded; // 0x170
	private bool m_IsRenderingInSceneView; // 0x171
	private TargetPool m_TargetPool; // 0x178
	private bool m_NaNKilled; // 0x180
	private readonly List<PostProcessEffectRenderer> m_ActiveEffects; // 0x188
	private readonly List<RenderTargetIdentifier> m_Targets; // 0x190

	public bool ScreenshotMode { get; set; }
	public uint ScreenWidth { get; }
	public uint ScreenHeight { get; }
	public uint ScaledScreenWidth { get; }
	public uint ScaledScreenHeight { get; }
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> sortedBundles { get; set; }
	public bool haveBundlesBeenInited { get; set; }


	public bool get_ScreenshotMode() { }

	public void set_ScreenshotMode(bool value) { }

	public uint get_ScreenWidth() { }

	public uint get_ScreenHeight() { }

	public uint get_ScaledScreenWidth() { }

	public uint get_ScaledScreenHeight() { }

	private void OnEnableRenderScale() { }

	private void OnDisableRenderScale() { }

	private void Update() { }

	private PostProcessLayer.ScalingMode GetDesiredScalingMode(NVSDK_NGX_PerfQuality_Value dlssMode) { }

	private bool NeedsRebuild(PostProcessLayer.ScalingMode desiredScalingMode, NVSDK_NGX_PerfQuality_Value dlssMode) { }

	public void SetMipMapBias(float bias) { }

	private float CalculateMipMapBias() { }

	private void BuildPostEffectsNew(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	private void RebuildRenderTargets() { }

	private void FreeRenderTargets() { }

	private void RebuildColorOutput() { }

	private void FreeRenderColorOutput() { }

	private bool StartDLSS() { }

	private bool UpdateDLSSQualitySettings(NVSDK_NGX_PerfQuality_Value perfQuality) { }

	private void StopDLSS() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> get_sortedBundles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_sortedBundles(Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_haveBundlesBeenInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_haveBundlesBeenInited(bool value) { }

	private void OnEnable() { }

	private void InitLegacy() { }

	[ImageEffectUsesCommandBuffer] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	public void Init(PostProcessResources resources) { }

	public void InitBundles() { }

	private void UpdateBundleSortList(List<PostProcessLayer.SerializedBundleRef> sortedList, PostProcessEvent evt) { }

	private void OnDisable() { }

	private void Reset() { }

	private void OnPreCull() { }

	private void OnPreRender() { }

	private RenderTextureFormat GetIntermediateFormat() { }

	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	private void BuildCommandBuffers() { }

	private void BuildPostEffectsOld(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	private void OnPostRender() { }

	public PostProcessBundle GetBundle<T>() { }
	/* GenericInstMethod :
	|
	|-PostProcessLayer.GetBundle<object>
	|-PostProcessLayer.GetBundle<AmbientOcclusion>
	|-PostProcessLayer.GetBundle<AutoExposure>
	|-PostProcessLayer.GetBundle<ScreenSpaceReflections>
	*/

	public PostProcessBundle GetBundle(Type settingsType) { }

	public T GetSettings<T>() { }
	/* GenericInstMethod :
	|
	|-PostProcessLayer.GetSettings<object>
	*/

	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = False) { }

	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) { }

	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	public void ResetHistory() { }

	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	private void SetupContext(PostProcessRenderContext context) { }

	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	public void Render(PostProcessRenderContext context) { }

	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	private void RenderList(List<PostProcessLayer.SerializedBundleRef> list, PostProcessRenderContext context, string marker) { }

	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = False) { }
	/* GenericInstMethod :
	|
	|-PostProcessLayer.RenderEffect<DepthOfFieldEffect>
	|-PostProcessLayer.RenderEffect<object>
	|-PostProcessLayer.RenderEffect<AutoExposure>
	|-PostProcessLayer.RenderEffect<Bloom>
	|-PostProcessLayer.RenderEffect<ChromaticAberration>
	|-PostProcessLayer.RenderEffect<ColorGrading>
	|-PostProcessLayer.RenderEffect<Grain>
	|-PostProcessLayer.RenderEffect<LensDistortion>
	|-PostProcessLayer.RenderEffect<MotionBlur>
	|-PostProcessLayer.RenderEffect<Vignette>
	*/

	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	public void .ctor() { }

}

private enum PostProcessLayer.ScalingMode // TypeDefIndex: 11735
{	public int value__; // 0x0
	public const PostProcessLayer.ScalingMode NATIVE = 0;
	public const PostProcessLayer.ScalingMode BILINEAR = 1;
	public const PostProcessLayer.ScalingMode DLSS = 2;

}

public enum PostProcessLayer.Antialiasing // TypeDefIndex: 11736
{	public int value__; // 0x0
	public const PostProcessLayer.Antialiasing None = 0;
	public const PostProcessLayer.Antialiasing FastApproximateAntialiasing = 1;
	public const PostProcessLayer.Antialiasing SubpixelMorphologicalAntialiasing = 2;
	public const PostProcessLayer.Antialiasing TemporalAntialiasing = 3;

}

public sealed class PostProcessLayer.SerializedBundleRef // TypeDefIndex: 11737
{	public string assemblyQualifiedName; // 0x10
	public PostProcessBundle bundle; // 0x18


	public void .ctor() { }

}

private sealed class PostProcessLayer.<>c // TypeDefIndex: 11738
{	public static readonly PostProcessLayer.<>c <>9; // 0x0
	public static Predicate<Shader> <>9__31_0; // 0x8
	public static Predicate<Shader> <>9__31_1; // 0x10
	public static Predicate<Shader> <>9__31_2; // 0x18
	public static Predicate<Shader> <>9__31_3; // 0x20
	public static Predicate<Shader> <>9__31_4; // 0x28
	public static Predicate<Shader> <>9__31_5; // 0x30
	public static Predicate<Shader> <>9__31_6; // 0x38
	public static Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle> <>9__97_1; // 0x40


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OnEnableRenderScale>b__31_0(Shader x) { }

	internal bool <OnEnableRenderScale>b__31_1(Shader x) { }

	internal bool <OnEnableRenderScale>b__31_2(Shader x) { }

	internal bool <OnEnableRenderScale>b__31_3(Shader x) { }

	internal bool <OnEnableRenderScale>b__31_4(Shader x) { }

	internal bool <OnEnableRenderScale>b__31_5(Shader x) { }

	internal bool <OnEnableRenderScale>b__31_6(Shader x) { }

	internal PostProcessBundle <UpdateBundleSortList>b__97_1(KeyValuePair<Type, PostProcessBundle> kvp) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_0 // TypeDefIndex: 11739
{	public PostProcessEvent evt; // 0x10
	public List<PostProcessBundle> effects; // 0x18


	public void .ctor() { }

	internal bool <UpdateBundleSortList>b__0(KeyValuePair<Type, PostProcessBundle> kvp) { }

	internal bool <UpdateBundleSortList>b__2(PostProcessLayer.SerializedBundleRef x) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_1 // TypeDefIndex: 11740
{	public string searchStr; // 0x10


	public void .ctor() { }

	internal bool <UpdateBundleSortList>b__3(PostProcessBundle b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_2 // TypeDefIndex: 11741
{	public string typeName; // 0x10


	public void .ctor() { }

	internal bool <UpdateBundleSortList>b__4(PostProcessLayer.SerializedBundleRef b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_3 // TypeDefIndex: 11742
{	public string typeName; // 0x10


	public void .ctor() { }

	internal bool <UpdateBundleSortList>b__5(PostProcessBundle b) { }

}

public class PostProcessRenderContext // TypeDefIndex: 11743
{	public bool dlssEnabled; // 0x10
	private Camera m_Camera; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CommandBuffer <command>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RenderTargetIdentifier <source>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RenderTargetIdentifier <destination>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RenderTextureFormat <sourceFormat>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <flip>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PostProcessResources <resources>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PropertySheetFactory <propertySheets>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Dictionary<string, object> <userData>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PostProcessDebugLayer <debugLayer>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <width>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <height>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <stereoActive>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <xrActiveEye>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <numberOfEyes>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PostProcessRenderContext.StereoRenderingMode <stereoRenderingMode>k__BackingField; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <screenWidth>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <screenHeight>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <isSceneView>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PostProcessLayer.Antialiasing <antialiasing>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TemporalAntialiasing <temporalAntialiasing>k__BackingField; // 0xC8
	internal PropertySheet uberSheet; // 0xD0
	internal Texture autoExposureTexture; // 0xD8
	internal LogHistogram logHistogram; // 0xE0
	internal Texture logLut; // 0xE8
	internal AutoExposure autoExposure; // 0xF0
	internal int bloomBufferNameID; // 0xF8
	internal bool physicalCamera; // 0xFC
	private RenderTextureDescriptor m_sourceDescriptor; // 0x100

	public Camera camera { get; set; }
	public CommandBuffer command { get; set; }
	public RenderTargetIdentifier source { get; set; }
	public RenderTargetIdentifier destination { get; set; }
	public RenderTextureFormat sourceFormat { get; set; }
	public bool flip { get; set; }
	public PostProcessResources resources { get; set; }
	public PropertySheetFactory propertySheets { get; set; }
	public Dictionary<string, object> userData { get; set; }
	public PostProcessDebugLayer debugLayer { get; set; }
	public int width { get; set; }
	public int height { get; set; }
	public bool stereoActive { get; set; }
	public int xrActiveEye { get; set; }
	public int numberOfEyes { get; set; }
	public PostProcessRenderContext.StereoRenderingMode stereoRenderingMode { get; set; }
	public int screenWidth { get; set; }
	public int screenHeight { get; set; }
	public bool isSceneView { get; set; }
	public PostProcessLayer.Antialiasing antialiasing { get; set; }
	public TemporalAntialiasing temporalAntialiasing { get; set; }


	public void Resize(int width, int height, bool dlssEnabled) { }

	public Camera get_camera() { }

	public void set_camera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public CommandBuffer get_command() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_command(CommandBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public RenderTargetIdentifier get_source() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public RenderTargetIdentifier get_destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_flip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_flip(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PostProcessResources get_resources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_resources(PostProcessResources value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PropertySheetFactory get_propertySheets() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_propertySheets(PropertySheetFactory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Dictionary<string, object> get_userData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_userData(Dictionary<string, object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PostProcessDebugLayer get_debugLayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_stereoActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_stereoActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_xrActiveEye() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_xrActiveEye(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_numberOfEyes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_numberOfEyes(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PostProcessRenderContext.StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_stereoRenderingMode(PostProcessRenderContext.StereoRenderingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_screenWidth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_screenWidth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_screenHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_screenHeight(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_isSceneView() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_isSceneView(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PostProcessLayer.Antialiasing get_antialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_antialiasing(PostProcessLayer.Antialiasing value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	public void Reset() { }

	public bool IsTemporalAntialiasingActive() { }

	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	private RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, int widthOverride = 0, int heightOverride = 0) { }

	public void .ctor() { }

}

public enum PostProcessRenderContext.StereoRenderingMode // TypeDefIndex: 11744
{	public int value__; // 0x0
	public const PostProcessRenderContext.StereoRenderingMode MultiPass = 0;
	public const PostProcessRenderContext.StereoRenderingMode SinglePass = 1;
	public const PostProcessRenderContext.StereoRenderingMode SinglePassInstanced = 2;
	public const PostProcessRenderContext.StereoRenderingMode SinglePassMultiview = 3;

}

public sealed class PostProcessAttribute : Attribute // TypeDefIndex: 11749
{	public readonly Type renderer; // 0x10
	public readonly PostProcessEvent eventType; // 0x18
	public readonly string menuItem; // 0x20
	public readonly bool allowInSceneView; // 0x28
	internal readonly bool builtinEffect; // 0x29


	public void .ctor(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = True) { }

	internal void .ctor(Type renderer, string menuItem, bool allowInSceneView = True) { }

}

public sealed class PostProcessBundle // TypeDefIndex: 11832
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PostProcessAttribute <attribute>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PostProcessEffectSettings <settings>k__BackingField; // 0x18
	private PostProcessEffectRenderer m_Renderer; // 0x20

	public PostProcessAttribute attribute { get; set; }
	public PostProcessEffectSettings settings { get; set; }
	internal PostProcessEffectRenderer renderer { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PostProcessAttribute get_attribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_attribute(PostProcessAttribute value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public PostProcessEffectSettings get_settings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_settings(PostProcessEffectSettings value) { }

	internal PostProcessEffectRenderer get_renderer() { }

	internal void .ctor(PostProcessEffectSettings settings) { }

	internal void Release() { }

	internal void ResetHistory() { }

	internal T CastSettings<T>() { }
	/* GenericInstMethod :
	|
	|-PostProcessBundle.CastSettings<object>
	|-PostProcessBundle.CastSettings<AmbientOcclusion>
	*/

	internal T CastRenderer<T>() { }
	/* GenericInstMethod :
	|
	|-PostProcessBundle.CastRenderer<object>
	|-PostProcessBundle.CastRenderer<AmbientOcclusionRenderer>
	*/

}

public sealed class PostProcessDebug : MonoBehaviour // TypeDefIndex: 11833
{	public PostProcessLayer postProcessLayer; // 0x18
	private PostProcessLayer m_PreviousPostProcessLayer; // 0x20
	public bool lightMeter; // 0x28
	public bool histogram; // 0x29
	public bool waveform; // 0x2A
	public bool vectorscope; // 0x2B
	public DebugOverlay debugOverlay; // 0x2C
	private Camera m_CurrentCamera; // 0x30
	private CommandBuffer m_CmdAfterEverything; // 0x38


	private void OnEnable() { }

	private void OnDisable() { }

	private void Update() { }

	private void Reset() { }

	private void UpdateStates() { }

	private void OnPostRender() { }

	private void OnGUI() { }

	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled) { }

	public void .ctor() { }

}

public sealed class PostProcessDebugLayer // TypeDefIndex: 11836
{	public LightMeterMonitor lightMeter; // 0x10
	public HistogramMonitor histogram; // 0x18
	public WaveformMonitor waveform; // 0x20
	public VectorscopeMonitor vectorscope; // 0x28
	private Dictionary<MonitorType, Monitor> m_Monitors; // 0x30
	private int frameWidth; // 0x38
	private int frameHeight; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RenderTexture <debugOverlayTarget>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <debugOverlayActive>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DebugOverlay <debugOverlay>k__BackingField; // 0x4C
	public PostProcessDebugLayer.OverlaySettings overlaySettings; // 0x50

	public RenderTexture debugOverlayTarget { get; set; }
	public bool debugOverlayActive { get; set; }
	public DebugOverlay debugOverlay { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public RenderTexture get_debugOverlayTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_debugOverlayTarget(RenderTexture value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_debugOverlayActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_debugOverlayActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public DebugOverlay get_debugOverlay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_debugOverlay(DebugOverlay value) { }

	internal void OnEnable() { }

	internal void OnDisable() { }

	private void DestroyDebugOverlayTarget() { }

	public void RequestMonitorPass(MonitorType monitor) { }

	public void RequestDebugOverlay(DebugOverlay mode) { }

	internal void SetFrameSize(int width, int height) { }

	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	internal DepthTextureMode GetCameraFlags() { }

	internal void RenderMonitors(PostProcessRenderContext context) { }

	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	internal void EndFrame() { }

	public void .ctor() { }

}

public class PostProcessDebugLayer.OverlaySettings // TypeDefIndex: 11837
{	public bool linearDepth; // 0x10
	[RangeAttribute] // RVA: 0x7B330 Offset: 0x7A730 VA: 0x18007B330
	public float motionColorIntensity; // 0x14
	[RangeAttribute] // RVA: 0x7B510 Offset: 0x7A910 VA: 0x18007B510
	public int motionGridSize; // 0x18
	public ColorBlindnessType colorBlindnessType; // 0x1C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float colorBlindnessStrength; // 0x20


	public void .ctor() { }

}

public abstract class PostProcessEffectRenderer // TypeDefIndex: 11838
{	protected bool m_ResetHistory; // 0x10


	public virtual void Init() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual void ResetHistory() { }

	public virtual void Release() { }

	public abstract void Render(PostProcessRenderContext context);

	internal abstract void SetSettings(PostProcessEffectSettings settings);

	protected void .ctor() { }

}

public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer // TypeDefIndex: 11839
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private T <settings>k__BackingField; // 0x0

	public T settings { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public T get_settings() { }
	/* GenericInstMethod :
	|
	|-PostProcessEffectRenderer<BlurOptimized>.get_settings
	|-PostProcessEffectRenderer<DepthOfFieldEffect>.get_settings
	|-PostProcessEffectRenderer<DoubleVision>.get_settings
	|-PostProcessEffectRenderer<FlashbangEffect>.get_settings
	|-PostProcessEffectRenderer<Frost>.get_settings
	|-PostProcessEffectRenderer<GodRays>.get_settings
	|-PostProcessEffectRenderer<GreyScale>.get_settings
	|-PostProcessEffectRenderer<LensDirtinessEffect>.get_settings
	|-PostProcessEffectRenderer<PhotoFilter>.get_settings
	|-PostProcessEffectRenderer<ScreenOverlay>.get_settings
	|-PostProcessEffectRenderer<SharpenAndVignette>.get_settings
	|-PostProcessEffectRenderer<object>.get_settings
	|-PostProcessEffectRenderer<AmbientOcclusion>.get_settings
	|-PostProcessEffectRenderer<AutoExposure>.get_settings
	|-PostProcessEffectRenderer<Bloom>.get_settings
	|-PostProcessEffectRenderer<ChromaticAberration>.get_settings
	|-PostProcessEffectRenderer<ColorGrading>.get_settings
	|-PostProcessEffectRenderer<DepthOfField>.get_settings
	|-PostProcessEffectRenderer<Grain>.get_settings
	|-PostProcessEffectRenderer<LensDistortion>.get_settings
	|-PostProcessEffectRenderer<MotionBlur>.get_settings
	|-PostProcessEffectRenderer<ScreenSpaceReflections>.get_settings
	|-PostProcessEffectRenderer<Vignette>.get_settings
	|-PostProcessEffectRenderer<Wiggle>.get_settings
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void set_settings(T value) { }
	/* GenericInstMethod :
	|
	|-PostProcessEffectRenderer<object>.set_settings
	*/

	internal override void SetSettings(PostProcessEffectSettings settings) { }
	/* GenericInstMethod :
	|
	|-PostProcessEffectRenderer<BlurOptimized>.SetSettings
	|-PostProcessEffectRenderer<DepthOfFieldEffect>.SetSettings
	|-PostProcessEffectRenderer<DoubleVision>.SetSettings
	|-PostProcessEffectRenderer<FlashbangEffect>.SetSettings
	|-PostProcessEffectRenderer<Frost>.SetSettings
	|-PostProcessEffectRenderer<GodRays>.SetSettings
	|-PostProcessEffectRenderer<GreyScale>.SetSettings
	|-PostProcessEffectRenderer<LensDirtinessEffect>.SetSettings
	|-PostProcessEffectRenderer<PhotoFilter>.SetSettings
	|-PostProcessEffectRenderer<ScreenOverlay>.SetSettings
	|-PostProcessEffectRenderer<SharpenAndVignette>.SetSettings
	|-PostProcessEffectRenderer<object>.SetSettings
	|-PostProcessEffectRenderer<AmbientOcclusion>.SetSettings
	|-PostProcessEffectRenderer<AutoExposure>.SetSettings
	|-PostProcessEffectRenderer<Bloom>.SetSettings
	|-PostProcessEffectRenderer<ChromaticAberration>.SetSettings
	|-PostProcessEffectRenderer<ColorGrading>.SetSettings
	|-PostProcessEffectRenderer<DepthOfField>.SetSettings
	|-PostProcessEffectRenderer<Grain>.SetSettings
	|-PostProcessEffectRenderer<LensDistortion>.SetSettings
	|-PostProcessEffectRenderer<MotionBlur>.SetSettings
	|-PostProcessEffectRenderer<ScreenSpaceReflections>.SetSettings
	|-PostProcessEffectRenderer<Vignette>.SetSettings
	|-PostProcessEffectRenderer<Wiggle>.SetSettings
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-PostProcessEffectRenderer<BlurOptimized>..ctor
	|-PostProcessEffectRenderer<DepthOfFieldEffect>..ctor
	|-PostProcessEffectRenderer<DoubleVision>..ctor
	|-PostProcessEffectRenderer<FlashbangEffect>..ctor
	|-PostProcessEffectRenderer<Frost>..ctor
	|-PostProcessEffectRenderer<GodRays>..ctor
	|-PostProcessEffectRenderer<GreyScale>..ctor
	|-PostProcessEffectRenderer<LensDirtinessEffect>..ctor
	|-PostProcessEffectRenderer<PhotoFilter>..ctor
	|-PostProcessEffectRenderer<ScreenOverlay>..ctor
	|-PostProcessEffectRenderer<SharpenAndVignette>..ctor
	|-PostProcessEffectRenderer<object>..ctor
	|-PostProcessEffectRenderer<AmbientOcclusion>..ctor
	|-PostProcessEffectRenderer<AutoExposure>..ctor
	|-PostProcessEffectRenderer<Bloom>..ctor
	|-PostProcessEffectRenderer<ChromaticAberration>..ctor
	|-PostProcessEffectRenderer<ColorGrading>..ctor
	|-PostProcessEffectRenderer<DepthOfField>..ctor
	|-PostProcessEffectRenderer<Grain>..ctor
	|-PostProcessEffectRenderer<LensDistortion>..ctor
	|-PostProcessEffectRenderer<MotionBlur>..ctor
	|-PostProcessEffectRenderer<ScreenSpaceReflections>..ctor
	|-PostProcessEffectRenderer<Vignette>..ctor
	|-PostProcessEffectRenderer<Wiggle>..ctor
	*/

}

public class PostProcessEffectSettings : ScriptableObject // TypeDefIndex: 11840
{	public bool active; // 0x18
	public BoolParameter enabled; // 0x20
	internal ReadOnlyCollection<ParameterOverride> parameters; // 0x28


	private void OnEnable() { }

	private void OnDisable() { }

	public void SetAllOverridesTo(bool state, bool excludeEnabled = True) { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public int GetHash() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }

}

private sealed class PostProcessEffectSettings.<>c // TypeDefIndex: 11841
{	public static readonly PostProcessEffectSettings.<>c <>9; // 0x0
	public static Func<FieldInfo, bool> <>9__3_0; // 0x8
	public static Func<FieldInfo, int> <>9__3_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OnEnable>b__3_0(FieldInfo t) { }

	internal int <OnEnable>b__3_1(FieldInfo t) { }

}

public enum PostProcessEvent // TypeDefIndex: 11842
{	public int value__; // 0x0
	public const PostProcessEvent BeforeTransparent = 0;
	public const PostProcessEvent BeforeStack = 1;
	public const PostProcessEvent AfterStack = 2;

}

internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent> // TypeDefIndex: 11843
{
	public bool Equals(PostProcessEvent x, PostProcessEvent y) { }

	public int GetHashCode(PostProcessEvent obj) { }

}

public sealed class PostProcessManager // TypeDefIndex: 11844
{	private static PostProcessManager s_Instance; // 0x0
	private const int k_MaxLayerCount = 32;
	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes; // 0x10
	private readonly List<PostProcessVolume> m_Volumes; // 0x18
	private readonly Dictionary<int, bool> m_SortNeeded; // 0x20
	private readonly List<PostProcessEffectSettings> m_BaseSettings; // 0x28
	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes; // 0x30

	public static PostProcessManager instance { get; }


	public static PostProcessManager get_instance() { }

	private void .ctor() { }

	private void CleanBaseTypes() { }

	private void ReloadBaseTypes() { }

	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = True, bool skipZeroWeight = True) { }

	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) { }

	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) { }

	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings) { }

	internal void SetLayerDirty(int layer) { }

	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) { }

	private void Register(PostProcessVolume volume, int layer) { }

	internal void Register(PostProcessVolume volume) { }

	private void Unregister(PostProcessVolume volume, int layer) { }

	internal void Unregister(PostProcessVolume volume) { }

	private void ReplaceData(PostProcessLayer postProcessLayer) { }

	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera) { }

	private List<PostProcessVolume> GrabVolumes(LayerMask mask) { }

	private static void SortByPriority(List<PostProcessVolume> volumes) { }

	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera) { }

}

private sealed class PostProcessManager.<>c // TypeDefIndex: 11845
{	public static readonly PostProcessManager.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__11_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <ReloadBaseTypes>b__11_0(Type t) { }

}

public sealed class PostProcessProfile : ScriptableObject // TypeDefIndex: 11846
{	[TooltipAttribute] // RVA: 0x7BD00 Offset: 0x7B100 VA: 0x18007BD00
	public List<PostProcessEffectSettings> settings; // 0x18
	public bool isDirty; // 0x20


	private void OnEnable() { }

	public T AddSettings<T>() { }
	/* GenericInstMethod :
	|
	|-PostProcessProfile.AddSettings<object>
	*/

	public PostProcessEffectSettings AddSettings(Type type) { }

	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect) { }

	public void RemoveSettings<T>() { }
	/* GenericInstMethod :
	|
	|-PostProcessProfile.RemoveSettings<object>
	*/

	public void RemoveSettings(Type type) { }

	public bool HasSettings<T>() { }
	/* GenericInstMethod :
	|
	|-PostProcessProfile.HasSettings<object>
	*/

	public bool HasSettings(Type type) { }

	public T GetSetting<T>() { }
	/* GenericInstMethod :
	|
	|-PostProcessProfile.GetSetting<BlurOptimized>
	|-PostProcessProfile.GetSetting<DepthOfFieldEffect>
	|-PostProcessProfile.GetSetting<FlashbangEffect>
	|-PostProcessProfile.GetSetting<GodRays>
	|-PostProcessProfile.GetSetting<SharpenAndVignette>
	|-PostProcessProfile.GetSetting<object>
	|-PostProcessProfile.GetSetting<ChromaticAberration>
	|-PostProcessProfile.GetSetting<ColorGrading>
	|-PostProcessProfile.GetSetting<MotionBlur>
	|-PostProcessProfile.GetSetting<Wiggle>
	*/

	public bool TryGetSettings<T>(out T outSetting) { }
	/* GenericInstMethod :
	|
	|-PostProcessProfile.TryGetSettings<object>
	*/

	public void .ctor() { }

}

private sealed class PostProcessProfile.<>c // TypeDefIndex: 11847
{	public static readonly PostProcessProfile.<>c <>9; // 0x0
	public static Predicate<PostProcessEffectSettings> <>9__2_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OnEnable>b__2_0(PostProcessEffectSettings x) { }

}

public sealed class PostProcessResources : ScriptableObject // TypeDefIndex: 11848
{	public Texture2D[] blueNoise64; // 0x18
	public Texture2D[] blueNoise256; // 0x20
	public PostProcessResources.SMAALuts smaaLuts; // 0x28
	public PostProcessResources.Shaders shaders; // 0x30
	public PostProcessResources.ComputeShaders computeShaders; // 0x38


	public void .ctor() { }

}

public sealed class PostProcessResources.Shaders // TypeDefIndex: 11849
{	public Shader bloom; // 0x10
	public Shader copy; // 0x18
	public Shader copyStd; // 0x20
	public Shader copyStdFromTexArray; // 0x28
	public Shader copyStdFromDoubleWide; // 0x30
	public Shader discardAlpha; // 0x38
	public Shader depthOfField; // 0x40
	public Shader finalPass; // 0x48
	public Shader grainBaker; // 0x50
	public Shader motionBlur; // 0x58
	public Shader temporalAntialiasing; // 0x60
	public Shader subpixelMorphologicalAntialiasing; // 0x68
	public Shader texture2dLerp; // 0x70
	public Shader uber; // 0x78
	public Shader lut2DBaker; // 0x80
	public Shader lightMeter; // 0x88
	public Shader gammaHistogram; // 0x90
	public Shader waveform; // 0x98
	public Shader vectorscope; // 0xA0
	public Shader debugOverlays; // 0xA8
	public Shader deferredFog; // 0xB0
	public Shader scalableAO; // 0xB8
	public Shader multiScaleAO; // 0xC0
	public Shader screenSpaceReflections; // 0xC8


	public PostProcessResources.Shaders Clone() { }

	public void .ctor() { }

}

public sealed class PostProcessResources.ComputeShaders // TypeDefIndex: 11850
{	public ComputeShader autoExposure; // 0x10
	public ComputeShader exposureHistogram; // 0x18
	public ComputeShader lut3DBaker; // 0x20
	public ComputeShader texture3dLerp; // 0x28
	public ComputeShader gammaHistogram; // 0x30
	public ComputeShader waveform; // 0x38
	public ComputeShader vectorscope; // 0x40
	public ComputeShader multiScaleAODownsample1; // 0x48
	public ComputeShader multiScaleAODownsample2; // 0x50
	public ComputeShader multiScaleAORender; // 0x58
	public ComputeShader multiScaleAOUpsample; // 0x60
	public ComputeShader gaussianDownsample; // 0x68


	public PostProcessResources.ComputeShaders Clone() { }

	public void .ctor() { }

}

public sealed class PostProcessResources.SMAALuts // TypeDefIndex: 11851
{	public Texture2D area; // 0x10
	public Texture2D search; // 0x18


	public void .ctor() { }

}

public sealed class PostProcessVolume : MonoBehaviour // TypeDefIndex: 11852
{	public PostProcessProfile sharedProfile; // 0x18
	[TooltipAttribute] // RVA: 0x7BFB0 Offset: 0x7B3B0 VA: 0x18007BFB0
	public bool isGlobal; // 0x20
	public Bounds bounds; // 0x24
	[MinAttribute] // RVA: 0x7C1B0 Offset: 0x7B5B0 VA: 0x18007C1B0
	[TooltipAttribute] // RVA: 0x7C1B0 Offset: 0x7B5B0 VA: 0x18007C1B0
	public float blendDistance; // 0x3C
	[RangeAttribute] // RVA: 0x7C2A0 Offset: 0x7B6A0 VA: 0x18007C2A0
	[TooltipAttribute] // RVA: 0x7C2A0 Offset: 0x7B6A0 VA: 0x18007C2A0
	public float weight; // 0x40
	[TooltipAttribute] // RVA: 0x7C4C0 Offset: 0x7B8C0 VA: 0x18007C4C0
	public float priority; // 0x44
	private int m_PreviousLayer; // 0x48
	private float m_PreviousPriority; // 0x4C
	private PostProcessProfile m_InternalProfile; // 0x50

	public PostProcessProfile profile { get; set; }
	internal PostProcessProfile profileRef { get; }


	public PostProcessProfile get_profile() { }

	public void set_profile(PostProcessProfile value) { }

	internal PostProcessProfile get_profileRef() { }

	public bool HasInstantiatedProfile() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void Update() { }

	private void OnDrawGizmos() { }

	public void .ctor() { }

}

