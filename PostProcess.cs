public class PostProcessVolumeLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 10276
{	// Fields
	public float distance; // 0x18
	private LODCell cell; // 0x20
	private PostProcessVolume postProcessVolume; // 0x28
	private LODEnvironmentMode environmentMode; // 0x30

	// Methods

	// RVA: 0x97C1F0 Offset: 0x97B5F0 VA: 0x18097C1F0
	private void Awake() { }

	// RVA: 0x97C410 Offset: 0x97B810 VA: 0x18097C410
	private void OnEnable() { }

	// RVA: 0x97C360 Offset: 0x97B760 VA: 0x18097C360
	private void OnDisable() { }

	// RVA: 0x97C2E0 Offset: 0x97B6E0 VA: 0x18097C2E0
	private float GetDistance() { }

	// RVA: 0x97C240 Offset: 0x97B640 VA: 0x18097C240 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x97C4B0 Offset: 0x97B8B0 VA: 0x18097C4B0 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class PostProcessLayer : MonoBehaviour // TypeDefIndex: 11734
{	// Fields
	private const float updateRate = 0,1;
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

	// Properties
	public bool ScreenshotMode { get; set; }
	public uint ScreenWidth { get; }
	public uint ScreenHeight { get; }
	public uint ScaledScreenWidth { get; }
	public uint ScaledScreenHeight { get; }
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> sortedBundles { get; set; }
	public bool haveBundlesBeenInited { get; set; }

	// Methods

	// RVA: 0x1025360 Offset: 0x1024760 VA: 0x181025360
	public bool get_ScreenshotMode() { }

	// RVA: 0x1025380 Offset: 0x1024780 VA: 0x181025380
	public void set_ScreenshotMode(bool value) { }

	// RVA: 0x1025300 Offset: 0x1024700 VA: 0x181025300
	public uint get_ScreenWidth() { }

	// RVA: 0x10252A0 Offset: 0x10246A0 VA: 0x1810252A0
	public uint get_ScreenHeight() { }

	// RVA: 0x10251E0 Offset: 0x10245E0 VA: 0x1810251E0
	public uint get_ScaledScreenWidth() { }

	// RVA: 0x1025120 Offset: 0x1024520 VA: 0x181025120
	public uint get_ScaledScreenHeight() { }

	// RVA: 0x101F7E0 Offset: 0x101EBE0 VA: 0x18101F7E0
	private void OnEnableRenderScale() { }

	// RVA: 0x101F0E0 Offset: 0x101E4E0 VA: 0x18101F0E0
	private void OnDisableRenderScale() { }

	// RVA: 0x10249C0 Offset: 0x1023DC0 VA: 0x1810249C0
	private void Update() { }

	// RVA: 0x101E2D0 Offset: 0x101D6D0 VA: 0x18101E2D0
	private PostProcessLayer.ScalingMode GetDesiredScalingMode(NVSDK_NGX_PerfQuality_Value dlssMode) { }

	// RVA: 0x101EDD0 Offset: 0x101E1D0 VA: 0x18101EDD0
	private bool NeedsRebuild(PostProcessLayer.ScalingMode desiredScalingMode, NVSDK_NGX_PerfQuality_Value dlssMode) { }

	// RVA: 0x1023660 Offset: 0x1022A60 VA: 0x181023660
	public void SetMipMapBias(float bias) { }

	// RVA: 0x101DFE0 Offset: 0x101D3E0 VA: 0x18101DFE0
	private float CalculateMipMapBias() { }

	// RVA: 0x101D120 Offset: 0x101C520 VA: 0x18101D120
	private void BuildPostEffectsNew(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	// RVA: 0x1020B50 Offset: 0x101FF50 VA: 0x181020B50
	private void RebuildRenderTargets() { }

	// RVA: 0x101E160 Offset: 0x101D560 VA: 0x18101E160
	private void FreeRenderTargets() { }

	// RVA: 0x10209F0 Offset: 0x101FDF0 VA: 0x1810209F0
	private void RebuildColorOutput() { }

	// RVA: 0x101E0E0 Offset: 0x101D4E0 VA: 0x18101E0E0
	private void FreeRenderColorOutput() { }

	// RVA: 0x1023E40 Offset: 0x1023240 VA: 0x181023E40
	private bool StartDLSS() { }

	// RVA: 0x1024480 Offset: 0x1023880 VA: 0x181024480
	private bool UpdateDLSSQualitySettings(NVSDK_NGX_PerfQuality_Value perfQuality) { }

	// RVA: 0x1023EF0 Offset: 0x10232F0 VA: 0x181023EF0
	private void StopDLSS() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE610C0 Offset: 0xE604C0 VA: 0x180E610C0
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> get_sortedBundles() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE60780 Offset: 0xE5FB80 VA: 0x180E60780
	private void set_sortedBundles(Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1025370 Offset: 0x1024770 VA: 0x181025370
	public bool get_haveBundlesBeenInited() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1025390 Offset: 0x1024790 VA: 0x181025390
	private void set_haveBundlesBeenInited(bool value) { }

	// RVA: 0x101FF30 Offset: 0x101F330 VA: 0x18101FF30
	private void OnEnable() { }

	// RVA: 0x101EA70 Offset: 0x101DE70 VA: 0x18101EA70
	private void InitLegacy() { }

	[ImageEffectUsesCommandBuffer] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1020710 Offset: 0x101FB10 VA: 0x181020710
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x101ECC0 Offset: 0x101E0C0 VA: 0x18101ECC0
	public void Init(PostProcessResources resources) { }

	// RVA: 0x101E630 Offset: 0x101DA30 VA: 0x18101E630
	public void InitBundles() { }

	// RVA: 0x1023F30 Offset: 0x1023330 VA: 0x181023F30
	private void UpdateBundleSortList(List<PostProcessLayer.SerializedBundleRef> sortedList, PostProcessEvent evt) { }

	// RVA: 0x101F260 Offset: 0x101E660 VA: 0x18101F260
	private void OnDisable() { }

	// RVA: 0x10233B0 Offset: 0x10227B0 VA: 0x1810233B0
	private void Reset() { }

	// RVA: 0x1020370 Offset: 0x101F770 VA: 0x181020370
	private void OnPreCull() { }

	// RVA: 0x1020690 Offset: 0x101FA90 VA: 0x181020690
	private void OnPreRender() { }

	// RVA: 0x101E3A0 Offset: 0x101D7A0 VA: 0x18101E3A0
	private RenderTextureFormat GetIntermediateFormat() { }

	// RVA: 0x10231E0 Offset: 0x10225E0 VA: 0x1810231E0
	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	// RVA: 0x1024750 Offset: 0x1023B50 VA: 0x181024750
	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	// RVA: 0x101C6B0 Offset: 0x101BAB0 VA: 0x18101C6B0
	private void BuildCommandBuffers() { }

	// RVA: 0x101DB70 Offset: 0x101CF70 VA: 0x18101DB70
	private void BuildPostEffectsOld(RenderTextureFormat sourceFormat, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget) { }

	// RVA: 0x1020150 Offset: 0x101F550 VA: 0x181020150
	private void OnPostRender() { }

	// RVA: -1 Offset: -1
	public PostProcessBundle GetBundle<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2A30 Offset: 0x1AA1E30 VA: 0x181AA2A30
	|-PostProcessLayer.GetBundle<object>
	|-PostProcessLayer.GetBundle<AmbientOcclusion>
	|-PostProcessLayer.GetBundle<AutoExposure>
	|-PostProcessLayer.GetBundle<ScreenSpaceReflections>
	*/

	// RVA: 0x101E220 Offset: 0x101D620 VA: 0x18101E220
	public PostProcessBundle GetBundle(Type settingsType) { }

	// RVA: -1 Offset: -1
	public T GetSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFF00 Offset: 0x14BF300 VA: 0x1814BFF00
	|-PostProcessLayer.GetSettings<object>
	*/

	// RVA: 0x101C560 Offset: 0x101B960 VA: 0x18101C560
	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA = False) { }

	// RVA: 0x10207A0 Offset: 0x101FBA0 VA: 0x1810207A0
	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor) { }

	// RVA: 0x10233E0 Offset: 0x10227E0 VA: 0x1810233E0
	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	// RVA: 0x1023260 Offset: 0x1022660 VA: 0x181023260
	public void ResetHistory() { }

	// RVA: 0x101E620 Offset: 0x101DA20 VA: 0x18101E620
	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	// RVA: 0x101E3F0 Offset: 0x101D7F0 VA: 0x18101E3F0
	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	// RVA: 0x1023C10 Offset: 0x1023010 VA: 0x181023C10
	private void SetupContext(PostProcessRenderContext context) { }

	// RVA: 0x1024890 Offset: 0x1023C90 VA: 0x181024890
	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

	// RVA: 0x1022570 Offset: 0x1021970 VA: 0x181022570
	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	// RVA: 0x1022650 Offset: 0x1021A50 VA: 0x181022650
	public void Render(PostProcessRenderContext context) { }

	// RVA: 0x1021E90 Offset: 0x1021290 VA: 0x181021E90
	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	// RVA: 0x1022050 Offset: 0x1021450 VA: 0x181022050
	private void RenderList(List<PostProcessLayer.SerializedBundleRef> list, PostProcessRenderContext context, string marker) { }

	// RVA: 0x101C440 Offset: 0x101B840 VA: 0x18101C440
	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	// RVA: 0x101C360 Offset: 0x101B760 VA: 0x18101C360
	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	// RVA: 0x1020DF0 Offset: 0x10201F0 VA: 0x181020DF0
	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: 0x1021610 Offset: 0x1020A10 VA: 0x181021610
	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	// RVA: -1 Offset: -1
	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82980 Offset: 0xE81D80 VA: 0x180E82980
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

	// RVA: 0x1023DA0 Offset: 0x10231A0 VA: 0x181023DA0
	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	// RVA: 0x1025050 Offset: 0x1024450 VA: 0x181025050
	public void .ctor() { }

}

private enum PostProcessLayer.ScalingMode // TypeDefIndex: 11735
{	// Fields
	public int value__; // 0x0
	public const PostProcessLayer.ScalingMode NATIVE = 0;
	public const PostProcessLayer.ScalingMode BILINEAR = 1;
	public const PostProcessLayer.ScalingMode DLSS = 2;

}

public enum PostProcessLayer.Antialiasing // TypeDefIndex: 11736
{	// Fields
	public int value__; // 0x0
	public const PostProcessLayer.Antialiasing None = 0;
	public const PostProcessLayer.Antialiasing FastApproximateAntialiasing = 1;
	public const PostProcessLayer.Antialiasing SubpixelMorphologicalAntialiasing = 2;
	public const PostProcessLayer.Antialiasing TemporalAntialiasing = 3;

}

public sealed class PostProcessLayer.SerializedBundleRef // TypeDefIndex: 11737
{	// Fields
	public string assemblyQualifiedName; // 0x10
	public PostProcessBundle bundle; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class PostProcessLayer.<>c // TypeDefIndex: 11738
{	// Fields
	public static readonly PostProcessLayer.<>c <>9; // 0x0
	public static Predicate<Shader> <>9__31_0; // 0x8
	public static Predicate<Shader> <>9__31_1; // 0x10
	public static Predicate<Shader> <>9__31_2; // 0x18
	public static Predicate<Shader> <>9__31_3; // 0x20
	public static Predicate<Shader> <>9__31_4; // 0x28
	public static Predicate<Shader> <>9__31_5; // 0x30
	public static Predicate<Shader> <>9__31_6; // 0x38
	public static Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle> <>9__97_1; // 0x40

	// Methods

	// RVA: 0x10283F0 Offset: 0x10277F0 VA: 0x1810283F0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1027CD0 Offset: 0x10270D0 VA: 0x181027CD0
	internal bool <OnEnableRenderScale>b__31_0(Shader x) { }

	// RVA: 0x1027D40 Offset: 0x1027140 VA: 0x181027D40
	internal bool <OnEnableRenderScale>b__31_1(Shader x) { }

	// RVA: 0x1027DB0 Offset: 0x10271B0 VA: 0x181027DB0
	internal bool <OnEnableRenderScale>b__31_2(Shader x) { }

	// RVA: 0x1027E20 Offset: 0x1027220 VA: 0x181027E20
	internal bool <OnEnableRenderScale>b__31_3(Shader x) { }

	// RVA: 0x1027E90 Offset: 0x1027290 VA: 0x181027E90
	internal bool <OnEnableRenderScale>b__31_4(Shader x) { }

	// RVA: 0x1027F00 Offset: 0x1027300 VA: 0x181027F00
	internal bool <OnEnableRenderScale>b__31_5(Shader x) { }

	// RVA: 0x1027F70 Offset: 0x1027370 VA: 0x181027F70
	internal bool <OnEnableRenderScale>b__31_6(Shader x) { }

	// RVA: 0x10281B0 Offset: 0x10275B0 VA: 0x1810281B0
	internal PostProcessBundle <UpdateBundleSortList>b__97_1(KeyValuePair<Type, PostProcessBundle> kvp) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_0 // TypeDefIndex: 11739
{	// Fields
	public PostProcessEvent evt; // 0x10
	public List<PostProcessBundle> effects; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10281F0 Offset: 0x10275F0 VA: 0x1810281F0
	internal bool <UpdateBundleSortList>b__0(KeyValuePair<Type, PostProcessBundle> kvp) { }

	// RVA: 0x1028260 Offset: 0x1027660 VA: 0x181028260
	internal bool <UpdateBundleSortList>b__2(PostProcessLayer.SerializedBundleRef x) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_1 // TypeDefIndex: 11740
{	// Fields
	public string searchStr; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1028330 Offset: 0x1027730 VA: 0x181028330
	internal bool <UpdateBundleSortList>b__3(PostProcessBundle b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_2 // TypeDefIndex: 11741
{	// Fields
	public string typeName; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9CA6D0 Offset: 0x9C9AD0 VA: 0x1809CA6D0
	internal bool <UpdateBundleSortList>b__4(PostProcessLayer.SerializedBundleRef b) { }

}

private sealed class PostProcessLayer.<>c__DisplayClass97_3 // TypeDefIndex: 11742
{	// Fields
	public string typeName; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1028330 Offset: 0x1027730 VA: 0x181028330
	internal bool <UpdateBundleSortList>b__5(PostProcessBundle b) { }

}

public class PostProcessRenderContext // TypeDefIndex: 11743
{	// Fields
	public bool dlssEnabled; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0x11D0910 Offset: 0x11CFD10 VA: 0x1811D0910
	public void Resize(int width, int height, bool dlssEnabled) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Camera get_camera() { }

	// RVA: 0x11D0980 Offset: 0x11CFD80 VA: 0x1811D0980
	public void set_camera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public CommandBuffer get_command() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_command(CommandBuffer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D0960 Offset: 0x11CFD60 VA: 0x1811D0960
	public RenderTargetIdentifier get_source() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D0A40 Offset: 0x11CFE40 VA: 0x1811D0A40
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D0940 Offset: 0x11CFD40 VA: 0x1811D0940
	public RenderTargetIdentifier get_destination() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11D0A20 Offset: 0x11CFE20 VA: 0x1811D0A20
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAF14F0 Offset: 0xAF08F0 VA: 0x180AF14F0
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB24460 Offset: 0xB23860 VA: 0x180B24460
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9619E0 Offset: 0x960DE0 VA: 0x1809619E0
	public bool get_flip() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9619F0 Offset: 0x960DF0 VA: 0x1809619F0
	public void set_flip(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public PostProcessResources get_resources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	internal void set_resources(PostProcessResources value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public PropertySheetFactory get_propertySheets() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	internal void set_propertySheets(PropertySheetFactory value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public Dictionary<string, object> get_userData() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E0A00 Offset: 0x4DFE00 VA: 0x1804E0A00
	private void set_userData(Dictionary<string, object> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public PostProcessDebugLayer get_debugLayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104C610 Offset: 0x104BA10 VA: 0x18104C610
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E30 Offset: 0x1074230 VA: 0x181074E30
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104C620 Offset: 0x104BA20 VA: 0x18104C620
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E40 Offset: 0x1074240 VA: 0x181074E40
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E83F0 Offset: 0x7E77F0 VA: 0x1807E83F0
	public bool get_stereoActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8400 Offset: 0x7E7800 VA: 0x1807E8400
	private void set_stereoActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BC00 Offset: 0xA2B000 VA: 0x180A2BC00
	public int get_xrActiveEye() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074EF0 Offset: 0x10742F0 VA: 0x181074EF0
	private void set_xrActiveEye(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F95B0 Offset: 0x2F89B0 VA: 0x1802F95B0
	public int get_numberOfEyes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F95C0 Offset: 0x2F89C0 VA: 0x1802F95C0
	private void set_numberOfEyes(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074CE0 Offset: 0x10740E0 VA: 0x181074CE0
	public PostProcessRenderContext.StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E50 Offset: 0x1074250 VA: 0x181074E50
	private void set_stereoRenderingMode(PostProcessRenderContext.StereoRenderingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D10 Offset: 0x1074110 VA: 0x181074D10
	public int get_screenWidth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E80 Offset: 0x1074280 VA: 0x181074E80
	public void set_screenWidth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D00 Offset: 0x1074100 VA: 0x181074D00
	public int get_screenHeight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E70 Offset: 0x1074270 VA: 0x181074E70
	public void set_screenHeight(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x588350 Offset: 0x587750 VA: 0x180588350
	public bool get_isSceneView() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x588360 Offset: 0x587760 VA: 0x180588360
	internal void set_isSceneView(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xADE1B0 Offset: 0xADD5B0 VA: 0x180ADE1B0
	public PostProcessLayer.Antialiasing get_antialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E20 Offset: 0x1074220 VA: 0x181074E20
	internal void set_antialiasing(PostProcessLayer.Antialiasing value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9B0A0 Offset: 0xD9A4A0 VA: 0x180D9B0A0
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9B480 Offset: 0xD9A880 VA: 0x180D9B480
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	// RVA: 0x11D06E0 Offset: 0x11CFAE0 VA: 0x1811D06E0
	public void Reset() { }

	// RVA: 0x11D0620 Offset: 0x11CFA20 VA: 0x1811D0620
	public bool IsTemporalAntialiasingActive() { }

	// RVA: 0x11D05F0 Offset: 0x11CF9F0 VA: 0x1811D05F0
	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	// RVA: 0x11D0680 Offset: 0x11CFA80 VA: 0x1811D0680
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x11D02E0 Offset: 0x11CF6E0 VA: 0x1811D02E0
	private RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	// RVA: 0x11D0450 Offset: 0x11CF850 VA: 0x1811D0450
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x11D0560 Offset: 0x11CF960 VA: 0x1811D0560
	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, int widthOverride = 0, int heightOverride = 0) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum PostProcessRenderContext.StereoRenderingMode // TypeDefIndex: 11744
{	// Fields
	public int value__; // 0x0
	public const PostProcessRenderContext.StereoRenderingMode MultiPass = 0;
	public const PostProcessRenderContext.StereoRenderingMode SinglePass = 1;
	public const PostProcessRenderContext.StereoRenderingMode SinglePassInstanced = 2;
	public const PostProcessRenderContext.StereoRenderingMode SinglePassMultiview = 3;

}

public sealed class PostProcessAttribute : Attribute // TypeDefIndex: 11749
{	// Fields
	public readonly Type renderer; // 0x10
	public readonly PostProcessEvent eventType; // 0x18
	public readonly string menuItem; // 0x20
	public readonly bool allowInSceneView; // 0x28
	internal readonly bool builtinEffect; // 0x29

	// Methods

	// RVA: 0x1019A80 Offset: 0x1018E80 VA: 0x181019A80
	public void .ctor(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = True) { }

	// RVA: 0x1019AF0 Offset: 0x1018EF0 VA: 0x181019AF0
	internal void .ctor(Type renderer, string menuItem, bool allowInSceneView = True) { }

}

public sealed class PostProcessBundle // TypeDefIndex: 11832
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PostProcessAttribute <attribute>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PostProcessEffectSettings <settings>k__BackingField; // 0x18
	private PostProcessEffectRenderer m_Renderer; // 0x20

	// Properties
	public PostProcessAttribute attribute { get; set; }
	public PostProcessEffectSettings settings { get; set; }
	internal PostProcessEffectRenderer renderer { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public PostProcessAttribute get_attribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_attribute(PostProcessAttribute value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public PostProcessEffectSettings get_settings() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_settings(PostProcessEffectSettings value) { }

	// RVA: 0x1019CC0 Offset: 0x10190C0 VA: 0x181019CC0
	internal PostProcessEffectRenderer get_renderer() { }

	// RVA: 0x1019BF0 Offset: 0x1018FF0 VA: 0x181019BF0
	internal void .ctor(PostProcessEffectSettings settings) { }

	// RVA: 0x1019B60 Offset: 0x1018F60 VA: 0x181019B60
	internal void Release() { }

	// RVA: 0x1019BD0 Offset: 0x1018FD0 VA: 0x181019BD0
	internal void ResetHistory() { }

	// RVA: -1 Offset: -1
	internal T CastSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFE90 Offset: 0x14BF290 VA: 0x1814BFE90
	|-PostProcessBundle.CastSettings<object>
	|-PostProcessBundle.CastSettings<AmbientOcclusion>
	*/

	// RVA: -1 Offset: -1
	internal T CastRenderer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFE20 Offset: 0x14BF220 VA: 0x1814BFE20
	|-PostProcessBundle.CastRenderer<object>
	|-PostProcessBundle.CastRenderer<AmbientOcclusionRenderer>
	*/

}

public sealed class PostProcessDebug : MonoBehaviour // TypeDefIndex: 11833
{	// Fields
	public PostProcessLayer postProcessLayer; // 0x18
	private PostProcessLayer m_PreviousPostProcessLayer; // 0x20
	public bool lightMeter; // 0x28
	public bool histogram; // 0x29
	public bool waveform; // 0x2A
	public bool vectorscope; // 0x2B
	public DebugOverlay debugOverlay; // 0x2C
	private Camera m_CurrentCamera; // 0x30
	private CommandBuffer m_CmdAfterEverything; // 0x38

	// Methods

	// RVA: 0x101B330 Offset: 0x101A730 VA: 0x18101B330
	private void OnEnable() { }

	// RVA: 0x101B280 Offset: 0x101A680 VA: 0x18101B280
	private void OnDisable() { }

	// RVA: 0x101B910 Offset: 0x101AD10 VA: 0x18101B910
	private void Update() { }

	// RVA: 0x101B630 Offset: 0x101AA30 VA: 0x18101B630
	private void Reset() { }

	// RVA: 0x101B680 Offset: 0x101AA80 VA: 0x18101B680
	private void UpdateStates() { }

	// RVA: 0x101B510 Offset: 0x101A910 VA: 0x18101B510
	private void OnPostRender() { }

	// RVA: 0x101B3B0 Offset: 0x101A7B0 VA: 0x18101B3B0
	private void OnGUI() { }

	// RVA: 0x101B100 Offset: 0x101A500 VA: 0x18101B100
	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public sealed class PostProcessDebugLayer // TypeDefIndex: 11836
{	// Fields
	public LightMeterMonitor lightMeter; // 0x10
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

	// Properties
	public RenderTexture debugOverlayTarget { get; set; }
	public bool debugOverlayActive { get; set; }
	public DebugOverlay debugOverlay { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public RenderTexture get_debugOverlayTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	private void set_debugOverlayTarget(RenderTexture value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	public bool get_debugOverlayActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9470 Offset: 0x4B8870 VA: 0x1804B9470
	private void set_debugOverlayActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B35A0 Offset: 0x5B29A0 VA: 0x1805B35A0
	public DebugOverlay get_debugOverlay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B3950 Offset: 0x5B2D50 VA: 0x1805B3950
	private void set_debugOverlay(DebugOverlay value) { }

	// RVA: 0x101A1D0 Offset: 0x10195D0 VA: 0x18101A1D0
	internal void OnEnable() { }

	// RVA: 0x101A040 Offset: 0x1019440 VA: 0x18101A040
	internal void OnDisable() { }

	// RVA: 0x1019E00 Offset: 0x1019200 VA: 0x181019E00
	private void DestroyDebugOverlayTarget() { }

	// RVA: 0x101B090 Offset: 0x101A490 VA: 0x18101B090
	public void RequestMonitorPass(MonitorType monitor) { }

	// RVA: 0x5B3950 Offset: 0x5B2D50 VA: 0x1805B3950
	public void RequestDebugOverlay(DebugOverlay mode) { }

	// RVA: 0x101B0F0 Offset: 0x101A4F0 VA: 0x18101B0F0
	internal void SetFrameSize(int width, int height) { }

	// RVA: 0x101A420 Offset: 0x1019820 VA: 0x18101A420
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	// RVA: 0x101A010 Offset: 0x1019410 VA: 0x18101A010
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x101A6F0 Offset: 0x1019AF0 VA: 0x18101A6F0
	internal void RenderMonitors(PostProcessRenderContext context) { }

	// RVA: 0x101AB60 Offset: 0x1019F60 VA: 0x18101AB60
	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	// RVA: 0x1019E80 Offset: 0x1019280 VA: 0x181019E80
	internal void EndFrame() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class PostProcessDebugLayer.OverlaySettings // TypeDefIndex: 11837
{	// Fields
	public bool linearDepth; // 0x10
	[RangeAttribute] // RVA: 0x7B330 Offset: 0x7A730 VA: 0x18007B330
	public float motionColorIntensity; // 0x14
	[RangeAttribute] // RVA: 0x7B510 Offset: 0x7A910 VA: 0x18007B510
	public int motionGridSize; // 0x18
	public ColorBlindnessType colorBlindnessType; // 0x1C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float colorBlindnessStrength; // 0x20

	// Methods

	// RVA: 0x1019A60 Offset: 0x1018E60 VA: 0x181019A60
	public void .ctor() { }

}

public abstract class PostProcessEffectRenderer // TypeDefIndex: 11838
{	// Fields
	protected bool m_ResetHistory; // 0x10

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public virtual void Init() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public virtual DepthTextureMode GetCameraFlags() { }

	// RVA: 0x101B920 Offset: 0x101AD20 VA: 0x18101B920 Slot: 6
	public virtual void ResetHistory() { }

	// RVA: 0x95B210 Offset: 0x95A610 VA: 0x18095B210 Slot: 7
	public virtual void Release() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Render(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	protected void .ctor() { }

}

public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer // TypeDefIndex: 11839
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private T <settings>k__BackingField; // 0x0

	// Properties
	public T settings { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public T get_settings() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
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
	// RVA: -1 Offset: -1
	internal void set_settings(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	|-PostProcessEffectRenderer<object>.set_settings
	*/

	// RVA: -1 Offset: -1 Slot: 9
	internal override void SetSettings(PostProcessEffectSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C0700 Offset: 0x19BFB00 VA: 0x1819C0700
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

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C07A0 Offset: 0x19BFBA0 VA: 0x1819C07A0
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
{	// Fields
	public bool active; // 0x18
	public BoolParameter enabled; // 0x20
	internal ReadOnlyCollection<ParameterOverride> parameters; // 0x28

	// Methods

	// RVA: 0x101BCB0 Offset: 0x101B0B0 VA: 0x18101BCB0
	private void OnEnable() { }

	// RVA: 0x101BB20 Offset: 0x101AF20 VA: 0x18101BB20
	private void OnDisable() { }

	// RVA: 0x101C080 Offset: 0x101B480 VA: 0x18101C080
	public void SetAllOverridesTo(bool state, bool excludeEnabled = True) { }

	// RVA: 0x101BB00 Offset: 0x101AF00 VA: 0x18101BB00 Slot: 4
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x101B940 Offset: 0x101AD40 VA: 0x18101B940
	public int GetHash() { }

	// RVA: 0x101C2E0 Offset: 0x101B6E0 VA: 0x18101C2E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x101C230 Offset: 0x101B630 VA: 0x18101C230
	private ParameterOverride <OnEnable>b__3_2(FieldInfo t) { }

}

private sealed class PostProcessEffectSettings.<>c // TypeDefIndex: 11841
{	// Fields
	public static readonly PostProcessEffectSettings.<>c <>9; // 0x0
	public static Func<FieldInfo, bool> <>9__3_0; // 0x8
	public static Func<FieldInfo, int> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x1028390 Offset: 0x1027790 VA: 0x181028390
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1027FE0 Offset: 0x10273E0 VA: 0x181027FE0
	internal bool <OnEnable>b__3_0(FieldInfo t) { }

	// RVA: 0x1028080 Offset: 0x1027480 VA: 0x181028080
	internal int <OnEnable>b__3_1(FieldInfo t) { }

}

public enum PostProcessEvent // TypeDefIndex: 11842
{	// Fields
	public int value__; // 0x0
	public const PostProcessEvent BeforeTransparent = 0;
	public const PostProcessEvent BeforeStack = 1;
	public const PostProcessEvent AfterStack = 2;

}

internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent> // TypeDefIndex: 11843
{	// Methods

	// RVA: 0x16B3A0 Offset: 0x16A7A0 VA: 0x18016B3A0 Slot: 4
	public bool Equals(PostProcessEvent x, PostProcessEvent y) { }

	// RVA: 0x16B3B0 Offset: 0x16A7B0 VA: 0x18016B3B0 Slot: 5
	public int GetHashCode(PostProcessEvent obj) { }

}

public sealed class PostProcessManager // TypeDefIndex: 11844
{	// Fields
	private static PostProcessManager s_Instance; // 0x0
	private const int k_MaxLayerCount = 32;
	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes; // 0x10
	private readonly List<PostProcessVolume> m_Volumes; // 0x18
	private readonly Dictionary<int, bool> m_SortNeeded; // 0x20
	private readonly List<PostProcessEffectSettings> m_BaseSettings; // 0x28
	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes; // 0x30

	// Properties
	public static PostProcessManager instance { get; }

	// Methods

	// RVA: 0x1027430 Offset: 0x1026830 VA: 0x181027430
	public static PostProcessManager get_instance() { }

	// RVA: 0x1027300 Offset: 0x1026700 VA: 0x181027300
	private void .ctor() { }

	// RVA: 0x10253A0 Offset: 0x10247A0 VA: 0x1810253A0
	private void CleanBaseTypes() { }

	// RVA: 0x10262E0 Offset: 0x10256E0 VA: 0x1810262E0
	private void ReloadBaseTypes() { }

	// RVA: 0x1025500 Offset: 0x1024900 VA: 0x181025500
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = True, bool skipZeroWeight = True) { }

	// RVA: 0x1025B00 Offset: 0x1024F00 VA: 0x181025B00
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer) { }

	// RVA: 0x1025960 Offset: 0x1024D60 VA: 0x181025960
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask) { }

	// RVA: 0x1025F90 Offset: 0x1025390 VA: 0x181025F90
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings) { }

	// RVA: 0x10268D0 Offset: 0x1025CD0 VA: 0x1810268D0
	internal void SetLayerDirty(int layer) { }

	// RVA: 0x1027240 Offset: 0x1026640 VA: 0x181027240
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer) { }

	// RVA: 0x1026100 Offset: 0x1025500 VA: 0x181026100
	private void Register(PostProcessVolume volume, int layer) { }

	// RVA: 0x1026290 Offset: 0x1025690 VA: 0x181026290
	internal void Register(PostProcessVolume volume) { }

	// RVA: 0x1026C00 Offset: 0x1026000 VA: 0x181026C00
	private void Unregister(PostProcessVolume volume, int layer) { }

	// RVA: 0x1026BB0 Offset: 0x1025FB0 VA: 0x181026BB0
	internal void Unregister(PostProcessVolume volume) { }

	// RVA: 0x10266B0 Offset: 0x1025AB0 VA: 0x1810266B0
	private void ReplaceData(PostProcessLayer postProcessLayer) { }

	// RVA: 0x1026D60 Offset: 0x1026160 VA: 0x181026D60
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera) { }

	// RVA: 0x1025BC0 Offset: 0x1024FC0 VA: 0x181025BC0
	private List<PostProcessVolume> GrabVolumes(LayerMask mask) { }

	// RVA: 0x1026A60 Offset: 0x1025E60 VA: 0x181026A60
	private static void SortByPriority(List<PostProcessVolume> volumes) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera) { }

}

private sealed class PostProcessManager.<>c // TypeDefIndex: 11845
{	// Fields
	public static readonly PostProcessManager.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x1028450 Offset: 0x1027850 VA: 0x181028450
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10280B0 Offset: 0x10274B0 VA: 0x1810280B0
	internal bool <ReloadBaseTypes>b__11_0(Type t) { }

}

public sealed class PostProcessProfile : ScriptableObject // TypeDefIndex: 11846
{	// Fields
	[TooltipAttribute] // RVA: 0x7BD00 Offset: 0x7B100 VA: 0x18007BD00
	public List<PostProcessEffectSettings> settings; // 0x18
	public bool isDirty; // 0x20

	// Methods

	// RVA: 0x1027960 Offset: 0x1026D60 VA: 0x181027960
	private void OnEnable() { }

	// RVA: -1 Offset: -1
	public T AddSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFF40 Offset: 0x14BF340 VA: 0x1814BFF40
	|-PostProcessProfile.AddSettings<object>
	*/

	// RVA: 0x10275D0 Offset: 0x10269D0 VA: 0x1810275D0
	public PostProcessEffectSettings AddSettings(Type type) { }

	// RVA: 0x1027720 Offset: 0x1026B20 VA: 0x181027720
	public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect) { }

	// RVA: -1 Offset: -1
	public void RemoveSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED260 Offset: 0x5EC660 VA: 0x1805ED260
	|-PostProcessProfile.RemoveSettings<object>
	*/

	// RVA: 0x1027A60 Offset: 0x1026E60 VA: 0x181027A60
	public void RemoveSettings(Type type) { }

	// RVA: -1 Offset: -1
	public bool HasSettings<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEE1F0 Offset: 0xBED5F0 VA: 0x180BEE1F0
	|-PostProcessProfile.HasSettings<object>
	*/

	// RVA: 0x10277D0 Offset: 0x1026BD0 VA: 0x1810277D0
	public bool HasSettings(Type type) { }

	// RVA: -1 Offset: -1
	public T GetSetting<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0010 Offset: 0x14BF410 VA: 0x1814C0010
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

	// RVA: -1 Offset: -1
	public bool TryGetSettings<T>(out T outSetting) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEE270 Offset: 0xBED670 VA: 0x180BEE270
	|-PostProcessProfile.TryGetSettings<object>
	*/

	// RVA: 0x1027BB0 Offset: 0x1026FB0 VA: 0x181027BB0
	public void .ctor() { }

}

private sealed class PostProcessProfile.<>c // TypeDefIndex: 11847
{	// Fields
	public static readonly PostProcessProfile.<>c <>9; // 0x0
	public static Predicate<PostProcessEffectSettings> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x11E2290 Offset: 0x11E1690 VA: 0x1811E2290
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x11E2200 Offset: 0x11E1600 VA: 0x1811E2200
	internal bool <OnEnable>b__2_0(PostProcessEffectSettings x) { }

}

public sealed class PostProcessResources : ScriptableObject // TypeDefIndex: 11848
{	// Fields
	public Texture2D[] blueNoise64; // 0x18
	public Texture2D[] blueNoise256; // 0x20
	public PostProcessResources.SMAALuts smaaLuts; // 0x28
	public PostProcessResources.Shaders shaders; // 0x30
	public PostProcessResources.ComputeShaders computeShaders; // 0x38

	// Methods

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public sealed class PostProcessResources.Shaders // TypeDefIndex: 11849
{	// Fields
	public Shader bloom; // 0x10
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

	// Methods

	// RVA: 0x11DA850 Offset: 0x11D9C50 VA: 0x1811DA850
	public PostProcessResources.Shaders Clone() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public sealed class PostProcessResources.ComputeShaders // TypeDefIndex: 11850
{	// Fields
	public ComputeShader autoExposure; // 0x10
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

	// Methods

	// RVA: 0x11CFE00 Offset: 0x11CF200 VA: 0x1811CFE00
	public PostProcessResources.ComputeShaders Clone() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public sealed class PostProcessResources.SMAALuts // TypeDefIndex: 11851
{	// Fields
	public Texture2D area; // 0x10
	public Texture2D search; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public sealed class PostProcessVolume : MonoBehaviour // TypeDefIndex: 11852
{	// Fields
	public PostProcessProfile sharedProfile; // 0x18
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

	// Properties
	public PostProcessProfile profile { get; set; }
	internal PostProcessProfile profileRef { get; }

	// Methods

	// RVA: 0x11D1020 Offset: 0x11D0420 VA: 0x1811D1020
	public PostProcessProfile get_profile() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_profile(PostProcessProfile value) { }

	// RVA: 0x11D0FA0 Offset: 0x11D03A0 VA: 0x1811D0FA0
	internal PostProcessProfile get_profileRef() { }

	// RVA: 0x11D0A60 Offset: 0x11CFE60 VA: 0x1811D0A60
	public bool HasInstantiatedProfile() { }

	// RVA: 0x11D0EB0 Offset: 0x11D02B0 VA: 0x1811D0EB0
	private void OnEnable() { }

	// RVA: 0x11D0AC0 Offset: 0x11CFEC0 VA: 0x1811D0AC0
	private void OnDisable() { }

	// RVA: 0x11D0F00 Offset: 0x11D0300 VA: 0x1811D0F00
	private void Update() { }

	// RVA: 0x11D0AF0 Offset: 0x11CFEF0 VA: 0x1811D0AF0
	private void OnDrawGizmos() { }

	// RVA: 0x9EA970 Offset: 0x9E9D70 VA: 0x1809EA970
	public void .ctor() { }

}

