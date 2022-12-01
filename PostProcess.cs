public class PostProcessVolumeLOD : MonoBehaviour, ILOD, IClientComponent // TypeDefIndex: 12030
{
	public float distance;
	private LODCell cell;
	private PostProcessVolume postProcessVolume;
	private LODEnvironmentMode environmentMode;


	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private float GetDistance() { }

	public void ChangeLOD() { }

	public void RefreshLOD() { }

	public void .ctor() { }

}

public class PostProcessLayer : MonoBehaviour // TypeDefIndex: 13542
{
	private const float updateRate = 0,1;
	private RenderTexture colorBuffer;
	private RenderTexture depthBuffer;
	private RenderTexture motionBuffer;
	private RenderTexture colorOutput;
	private Camera renderingCamera;
	private Material renderScaleMaterial;
	private HashSet<Shader> mipmapShaders;
	private Nullable<PostProcessLayer.ScalingMode> scalingMode;
	private float prevRenderScale;
	private NVSDK_NGX_PerfQuality_Value prevPerfQuality;
	private uint prevScreenWidth;
	private uint prevScreenHeight;
	private float prevUpdateTime;
	private bool screenshotMode;
	private bool firstDLSSPass;
	private DlSSRecommendedSettings dlssRecommendedSettings;
	private GCHandle dlssDataHandle;
	private CommandBuffer afterEverythingCommandBuffer;
	public Transform volumeTrigger;
	public LayerMask volumeLayer;
	public bool stopNaNPropagation;
	public bool finalBlitToCameraTarget;
	public PostProcessLayer.Antialiasing antialiasingMode;
	public TemporalAntialiasing temporalAntialiasing;
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing;
	public FastApproximateAntialiasing fastApproximateAntialiasing;
	public Fog fog;
	private Dithering dithering;
	public PostProcessDebugLayer debugLayer;
	public RenderTextureFormat intermediateFormat;
	private RenderTextureFormat prevIntermediateFormat;
	private bool supportsIntermediateFormat;
	[SerializeField]
	private PostProcessResources m_Resources;
	[PreserveAttribute]
	[SerializeField]
	private bool m_ShowToolkit;
	[PreserveAttribute]
	[SerializeField]
	private bool m_ShowCustomSorter;
	public bool breakBeforeColorGrading;
	[SerializeField]
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeTransparentBundles;
	[SerializeField]
	private List<PostProcessLayer.SerializedBundleRef> m_BeforeStackBundles;
	[SerializeField]
	private List<PostProcessLayer.SerializedBundleRef> m_AfterStackBundles;
	[CompilerGeneratedAttribute]
	private Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> <sortedBundles>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <haveBundlesBeenInited>k__BackingField;
	private Dictionary<Type, PostProcessBundle> m_Bundles;
	private PropertySheetFactory m_PropertySheetFactory;
	private CommandBuffer m_LegacyCmdBufferBeforeReflections;
	private CommandBuffer m_LegacyCmdBufferBeforeLighting;
	private CommandBuffer m_LegacyCmdBufferOpaque;
	private CommandBuffer m_LegacyCmdBuffer;
	private Camera m_Camera;
	private PostProcessRenderContext m_CurrentContext;
	private LogHistogram m_LogHistogram;
	private bool m_SettingsUpdateNeeded;
	private bool m_IsRenderingInSceneView;
	private TargetPool m_TargetPool;
	private bool m_NaNKilled;
	private readonly List<PostProcessEffectRenderer> m_ActiveEffects;
	private readonly List<RenderTargetIdentifier> m_Targets;

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

	[CompilerGeneratedAttribute]
	public Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> get_sortedBundles() { }

	[CompilerGeneratedAttribute]
	private void set_sortedBundles(Dictionary<PostProcessEvent, List<PostProcessLayer.SerializedBundleRef>> value) { }

	[CompilerGeneratedAttribute]
	public bool get_haveBundlesBeenInited() { }

	[CompilerGeneratedAttribute]
	private void set_haveBundlesBeenInited(bool value) { }

	private void OnEnable() { }

	private void InitLegacy() { }

	[ImageEffectUsesCommandBuffer]
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

private enum PostProcessLayer.ScalingMode // TypeDefIndex: 13543
{
	public int value__;
	public const PostProcessLayer.ScalingMode NATIVE = 0;
	public const PostProcessLayer.ScalingMode BILINEAR = 1;
	public const PostProcessLayer.ScalingMode DLSS = 2;

}

public enum PostProcessLayer.Antialiasing // TypeDefIndex: 13544
{
	public int value__;
	public const PostProcessLayer.Antialiasing None = 0;
	public const PostProcessLayer.Antialiasing FastApproximateAntialiasing = 1;
	public const PostProcessLayer.Antialiasing SubpixelMorphologicalAntialiasing = 2;
	public const PostProcessLayer.Antialiasing TemporalAntialiasing = 3;

}

public sealed class PostProcessLayer.SerializedBundleRef // TypeDefIndex: 13545
{
	public string assemblyQualifiedName;
	public PostProcessBundle bundle;


	public void .ctor() { }

}

private sealed class PostProcessLayer.<>c // TypeDefIndex: 13546
{
	public static readonly PostProcessLayer.<>c <>9;
	public static Predicate<Shader> <>9__31_0;
	public static Predicate<Shader> <>9__31_1;
	public static Predicate<Shader> <>9__31_2;
	public static Predicate<Shader> <>9__31_3;
	public static Predicate<Shader> <>9__31_4;
	public static Predicate<Shader> <>9__31_5;
	public static Predicate<Shader> <>9__31_6;
	public static Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle> <>9__97_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OnEnableRenderScale>

	internal bool <OnEnableRenderScale>

	internal bool <OnEnableRenderScale>

	internal bool <OnEnableRenderScale>

	internal bool <OnEnableRenderScale>

	internal bool <OnEnableRenderScale>

	internal bool <OnEnableRenderScale>

	internal PostProcessBundle <UpdateBundleSortList>

}

private sealed class PostProcessLayer.<>c__DisplayClass97_0 // TypeDefIndex: 13547
{
	public PostProcessEvent evt;
	public List<PostProcessBundle> effects;


	public void .ctor() { }

	internal bool <UpdateBundleSortList>

	internal bool <UpdateBundleSortList>

}

private sealed class PostProcessLayer.<>c__DisplayClass97_1 // TypeDefIndex: 13548
{
	public string searchStr;


	public void .ctor() { }

	internal bool <UpdateBundleSortList>

}

private sealed class PostProcessLayer.<>c__DisplayClass97_2 // TypeDefIndex: 13549
{
	public string typeName;


	public void .ctor() { }

	internal bool <UpdateBundleSortList>

}

private sealed class PostProcessLayer.<>c__DisplayClass97_3 // TypeDefIndex: 13550
{
	public string typeName;


	public void .ctor() { }

	internal bool <UpdateBundleSortList>

}

public class PostProcessRenderContext // TypeDefIndex: 13551
{
	public bool dlssEnabled;
	private Camera m_Camera;
	[CompilerGeneratedAttribute]
	private CommandBuffer <command>k__BackingField;
	[CompilerGeneratedAttribute]
	private RenderTargetIdentifier <source>k__BackingField;
	[CompilerGeneratedAttribute]
	private RenderTargetIdentifier <destination>k__BackingField;
	[CompilerGeneratedAttribute]
	private RenderTextureFormat <sourceFormat>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <flip>k__BackingField;
	[CompilerGeneratedAttribute]
	private PostProcessResources <resources>k__BackingField;
	[CompilerGeneratedAttribute]
	private PropertySheetFactory <propertySheets>k__BackingField;
	[CompilerGeneratedAttribute]
	private Dictionary<string, object> <userData>k__BackingField;
	[CompilerGeneratedAttribute]
	private PostProcessDebugLayer <debugLayer>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <width>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <height>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <stereoActive>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <xrActiveEye>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <numberOfEyes>k__BackingField;
	[CompilerGeneratedAttribute]
	private PostProcessRenderContext.StereoRenderingMode <stereoRenderingMode>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <screenWidth>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <screenHeight>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <isSceneView>k__BackingField;
	[CompilerGeneratedAttribute]
	private PostProcessLayer.Antialiasing <antialiasing>k__BackingField;
	[CompilerGeneratedAttribute]
	private TemporalAntialiasing <temporalAntialiasing>k__BackingField;
	internal PropertySheet uberSheet;
	internal Texture autoExposureTexture;
	internal LogHistogram logHistogram;
	internal Texture logLut;
	internal AutoExposure autoExposure;
	internal int bloomBufferNameID;
	internal bool physicalCamera;
	private RenderTextureDescriptor m_sourceDescriptor;

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

	[CompilerGeneratedAttribute]
	public CommandBuffer get_command() { }

	[CompilerGeneratedAttribute]
	public void set_command(CommandBuffer value) { }

	[CompilerGeneratedAttribute]
	public RenderTargetIdentifier get_source() { }

	[CompilerGeneratedAttribute]
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute]
	public RenderTargetIdentifier get_destination() { }

	[CompilerGeneratedAttribute]
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute]
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGeneratedAttribute]
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGeneratedAttribute]
	public bool get_flip() { }

	[CompilerGeneratedAttribute]
	public void set_flip(bool value) { }

	[CompilerGeneratedAttribute]
	public PostProcessResources get_resources() { }

	[CompilerGeneratedAttribute]
	internal void set_resources(PostProcessResources value) { }

	[CompilerGeneratedAttribute]
	public PropertySheetFactory get_propertySheets() { }

	[CompilerGeneratedAttribute]
	internal void set_propertySheets(PropertySheetFactory value) { }

	[CompilerGeneratedAttribute]
	public Dictionary<string, object> get_userData() { }

	[CompilerGeneratedAttribute]
	private void set_userData(Dictionary<string, object> value) { }

	[CompilerGeneratedAttribute]
	public PostProcessDebugLayer get_debugLayer() { }

	[CompilerGeneratedAttribute]
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[CompilerGeneratedAttribute]
	public int get_width() { }

	[CompilerGeneratedAttribute]
	public void set_width(int value) { }

	[CompilerGeneratedAttribute]
	public int get_height() { }

	[CompilerGeneratedAttribute]
	public void set_height(int value) { }

	[CompilerGeneratedAttribute]
	public bool get_stereoActive() { }

	[CompilerGeneratedAttribute]
	private void set_stereoActive(bool value) { }

	[CompilerGeneratedAttribute]
	public int get_xrActiveEye() { }

	[CompilerGeneratedAttribute]
	private void set_xrActiveEye(int value) { }

	[CompilerGeneratedAttribute]
	public int get_numberOfEyes() { }

	[CompilerGeneratedAttribute]
	private void set_numberOfEyes(int value) { }

	[CompilerGeneratedAttribute]
	public PostProcessRenderContext.StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGeneratedAttribute]
	private void set_stereoRenderingMode(PostProcessRenderContext.StereoRenderingMode value) { }

	[CompilerGeneratedAttribute]
	public int get_screenWidth() { }

	[CompilerGeneratedAttribute]
	public void set_screenWidth(int value) { }

	[CompilerGeneratedAttribute]
	public int get_screenHeight() { }

	[CompilerGeneratedAttribute]
	public void set_screenHeight(int value) { }

	[CompilerGeneratedAttribute]
	public bool get_isSceneView() { }

	[CompilerGeneratedAttribute]
	internal void set_isSceneView(bool value) { }

	[CompilerGeneratedAttribute]
	public PostProcessLayer.Antialiasing get_antialiasing() { }

	[CompilerGeneratedAttribute]
	internal void set_antialiasing(PostProcessLayer.Antialiasing value) { }

	[CompilerGeneratedAttribute]
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGeneratedAttribute]
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

public enum PostProcessRenderContext.StereoRenderingMode // TypeDefIndex: 13552
{
	public int value__;
	public const PostProcessRenderContext.StereoRenderingMode MultiPass = 0;
	public const PostProcessRenderContext.StereoRenderingMode SinglePass = 1;
	public const PostProcessRenderContext.StereoRenderingMode SinglePassInstanced = 2;
	public const PostProcessRenderContext.StereoRenderingMode SinglePassMultiview = 3;

}

public sealed class PostProcessAttribute : Attribute // TypeDefIndex: 13557
{
	public readonly Type renderer;
	public readonly PostProcessEvent eventType;
	public readonly string menuItem;
	public readonly bool allowInSceneView;
	internal readonly bool builtinEffect;


	public void .ctor(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = True) { }

	internal void .ctor(Type renderer, string menuItem, bool allowInSceneView = True) { }

}

public sealed class PostProcessBundle // TypeDefIndex: 13640
{
	[CompilerGeneratedAttribute]
	private PostProcessAttribute <attribute>k__BackingField;
	[CompilerGeneratedAttribute]
	private PostProcessEffectSettings <settings>k__BackingField;
	private PostProcessEffectRenderer m_Renderer;

	public PostProcessAttribute attribute { get; set; }
	public PostProcessEffectSettings settings { get; set; }
	internal PostProcessEffectRenderer renderer { get; }


	[CompilerGeneratedAttribute]
	public PostProcessAttribute get_attribute() { }

	[CompilerGeneratedAttribute]
	private void set_attribute(PostProcessAttribute value) { }

	[CompilerGeneratedAttribute]
	public PostProcessEffectSettings get_settings() { }

	[CompilerGeneratedAttribute]
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

public sealed class PostProcessDebug : MonoBehaviour // TypeDefIndex: 13641
{
	public PostProcessLayer postProcessLayer;
	private PostProcessLayer m_PreviousPostProcessLayer;
	public bool lightMeter;
	public bool histogram;
	public bool waveform;
	public bool vectorscope;
	public DebugOverlay debugOverlay;
	private Camera m_CurrentCamera;
	private CommandBuffer m_CmdAfterEverything;


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

public sealed class PostProcessDebugLayer // TypeDefIndex: 13644
{
	public LightMeterMonitor lightMeter;
	public HistogramMonitor histogram;
	public WaveformMonitor waveform;
	public VectorscopeMonitor vectorscope;
	private Dictionary<MonitorType, Monitor> m_Monitors;
	private int frameWidth;
	private int frameHeight;
	[CompilerGeneratedAttribute]
	private RenderTexture <debugOverlayTarget>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <debugOverlayActive>k__BackingField;
	[CompilerGeneratedAttribute]
	private DebugOverlay <debugOverlay>k__BackingField;
	public PostProcessDebugLayer.OverlaySettings overlaySettings;

	public RenderTexture debugOverlayTarget { get; set; }
	public bool debugOverlayActive { get; set; }
	public DebugOverlay debugOverlay { get; set; }


	[CompilerGeneratedAttribute]
	public RenderTexture get_debugOverlayTarget() { }

	[CompilerGeneratedAttribute]
	private void set_debugOverlayTarget(RenderTexture value) { }

	[CompilerGeneratedAttribute]
	public bool get_debugOverlayActive() { }

	[CompilerGeneratedAttribute]
	private void set_debugOverlayActive(bool value) { }

	[CompilerGeneratedAttribute]
	public DebugOverlay get_debugOverlay() { }

	[CompilerGeneratedAttribute]
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

public class PostProcessDebugLayer.OverlaySettings // TypeDefIndex: 13645
{
	public bool linearDepth;
	[RangeAttribute]
	public float motionColorIntensity;
	[RangeAttribute]
	public int motionGridSize;
	public ColorBlindnessType colorBlindnessType;
	[RangeAttribute]
	public float colorBlindnessStrength;


	public void .ctor() { }

}

public abstract class PostProcessEffectRenderer // TypeDefIndex: 13646
{
	protected bool m_ResetHistory;


	public virtual void Init() { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual void ResetHistory() { }

	public virtual void Release() { }

	public abstract void Render(PostProcessRenderContext context);

	internal abstract void SetSettings(PostProcessEffectSettings settings);

	protected void .ctor() { }

}

public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer // TypeDefIndex: 13647
{
	[CompilerGeneratedAttribute]
	private T <settings>k__BackingField;

	public T settings { get; set; }


	[CompilerGeneratedAttribute]
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

	[CompilerGeneratedAttribute]
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

public class PostProcessEffectSettings : ScriptableObject // TypeDefIndex: 13648
{
	public bool active;
	public BoolParameter enabled;
	internal ReadOnlyCollection<ParameterOverride> parameters;


	private void OnEnable() { }

	private void OnDisable() { }

	public void SetAllOverridesTo(bool state, bool excludeEnabled = True) { }

	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public int GetHash() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute]
	private ParameterOverride <OnEnable>

}

private sealed class PostProcessEffectSettings.<>c // TypeDefIndex: 13649
{
	public static readonly PostProcessEffectSettings.<>c <>9;
	public static Func<FieldInfo, bool> <>9__3_0;
	public static Func<FieldInfo, int> <>9__3_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OnEnable>

	internal int <OnEnable>

}

public enum PostProcessEvent // TypeDefIndex: 13650
{
	public int value__;
	public const PostProcessEvent BeforeTransparent = 0;
	public const PostProcessEvent BeforeStack = 1;
	public const PostProcessEvent AfterStack = 2;

}

internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent> // TypeDefIndex: 13651
{

	public bool Equals(PostProcessEvent x, PostProcessEvent y) { }

	public int GetHashCode(PostProcessEvent obj) { }

}

public sealed class PostProcessManager // TypeDefIndex: 13652
{
	private static PostProcessManager s_Instance;
	private const int k_MaxLayerCount = 32;
	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes;
	private readonly List<PostProcessVolume> m_Volumes;
	private readonly Dictionary<int, bool> m_SortNeeded;
	private readonly List<PostProcessEffectSettings> m_BaseSettings;
	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes;

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

private sealed class PostProcessManager.<>c // TypeDefIndex: 13653
{
	public static readonly PostProcessManager.<>c <>9;
	public static Func<Type, bool> <>9__11_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <ReloadBaseTypes>

}

public sealed class PostProcessProfile : ScriptableObject // TypeDefIndex: 13654
{
	[TooltipAttribute]
	public List<PostProcessEffectSettings> settings;
	public bool isDirty;


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

private sealed class PostProcessProfile.<>c // TypeDefIndex: 13655
{
	public static readonly PostProcessProfile.<>c <>9;
	public static Predicate<PostProcessEffectSettings> <>9__2_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <OnEnable>

}

public sealed class PostProcessResources : ScriptableObject // TypeDefIndex: 13656
{
	public Texture2D[] blueNoise64;
	public Texture2D[] blueNoise256;
	public PostProcessResources.SMAALuts smaaLuts;
	public PostProcessResources.Shaders shaders;
	public PostProcessResources.ComputeShaders computeShaders;


	public void .ctor() { }

}

public sealed class PostProcessResources.Shaders // TypeDefIndex: 13657
{
	public Shader bloom;
	public Shader copy;
	public Shader copyStd;
	public Shader copyStdFromTexArray;
	public Shader copyStdFromDoubleWide;
	public Shader discardAlpha;
	public Shader depthOfField;
	public Shader finalPass;
	public Shader grainBaker;
	public Shader motionBlur;
	public Shader temporalAntialiasing;
	public Shader subpixelMorphologicalAntialiasing;
	public Shader texture2dLerp;
	public Shader uber;
	public Shader lut2DBaker;
	public Shader lightMeter;
	public Shader gammaHistogram;
	public Shader waveform;
	public Shader vectorscope;
	public Shader debugOverlays;
	public Shader deferredFog;
	public Shader scalableAO;
	public Shader multiScaleAO;
	public Shader screenSpaceReflections;


	public PostProcessResources.Shaders Clone() { }

	public void .ctor() { }

}

public sealed class PostProcessResources.ComputeShaders // TypeDefIndex: 13658
{
	public ComputeShader autoExposure;
	public ComputeShader exposureHistogram;
	public ComputeShader lut3DBaker;
	public ComputeShader texture3dLerp;
	public ComputeShader gammaHistogram;
	public ComputeShader waveform;
	public ComputeShader vectorscope;
	public ComputeShader multiScaleAODownsample1;
	public ComputeShader multiScaleAODownsample2;
	public ComputeShader multiScaleAORender;
	public ComputeShader multiScaleAOUpsample;
	public ComputeShader gaussianDownsample;


	public PostProcessResources.ComputeShaders Clone() { }

	public void .ctor() { }

}

public sealed class PostProcessResources.SMAALuts // TypeDefIndex: 13659
{
	public Texture2D area;
	public Texture2D search;


	public void .ctor() { }

}

public sealed class PostProcessVolume : MonoBehaviour // TypeDefIndex: 13660
{
	public PostProcessProfile sharedProfile;
	[TooltipAttribute]
	public bool isGlobal;
	public Bounds bounds;
	[MinAttribute]
	[TooltipAttribute]
	public float blendDistance;
	[RangeAttribute]
	[TooltipAttribute]
	public float weight;
	[TooltipAttribute]
	public float priority;
	private int m_PreviousLayer;
	private float m_PreviousPriority;
	private PostProcessProfile m_InternalProfile;

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

