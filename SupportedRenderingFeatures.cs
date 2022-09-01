public class SupportedRenderingFeatures // TypeDefIndex: 3854
{
	private static SupportedRenderingFeatures s_Active; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private LightmapsMode <lightmapsModes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <enlighten>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <lightProbeProxyVolumes>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <motionVectors>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <receiveShadows>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <reflectionProbes>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <rendererPriority>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <terrainDetailUnsupported>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <overridesEnvironmentLighting>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <overridesFog>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <overridesOtherLightingSettings>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <editableMaterialRenderQueue>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <overridesLODBias>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private bool <overridesMaximumLODLevel>k__BackingField; 

	public static SupportedRenderingFeatures active { get; set; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes { get; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes { get; }
	public LightmapBakeType lightmapBakeTypes { get; }
	public LightmapsMode lightmapsModes { get; }
	public bool enlighten { get; }


	public static SupportedRenderingFeatures get_active() { }

	public static void set_active(SupportedRenderingFeatures value) { }

	[CompilerGeneratedAttribute] 
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CompilerGeneratedAttribute] 
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes() { }

	[CompilerGeneratedAttribute] 
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CompilerGeneratedAttribute] 
	public LightmapsMode get_lightmapsModes() { }

	[CompilerGeneratedAttribute] 
	public bool get_enlighten() { }

	[RequiredByNativeCodeAttribute] 
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[RequiredByNativeCodeAttribute] 
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[RequiredByNativeCodeAttribute] 
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[RequiredByNativeCodeAttribute] 
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[RequiredByNativeCodeAttribute] 
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[RequiredByNativeCodeAttribute] 
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum SupportedRenderingFeatures.ReflectionProbeModes // TypeDefIndex: 3855
{
	public int value__; 
	public const SupportedRenderingFeatures.ReflectionProbeModes None = 0;
	public const SupportedRenderingFeatures.ReflectionProbeModes Rotation = 1;

}

public enum SupportedRenderingFeatures.LightmapMixedBakeModes // TypeDefIndex: 3856
{
	public int value__; 
	public const SupportedRenderingFeatures.LightmapMixedBakeModes None = 0;
	public const SupportedRenderingFeatures.LightmapMixedBakeModes IndirectOnly = 1;
	public const SupportedRenderingFeatures.LightmapMixedBakeModes Subtractive = 2;
	public const SupportedRenderingFeatures.LightmapMixedBakeModes Shadowmask = 4;

}

