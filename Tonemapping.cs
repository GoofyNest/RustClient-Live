public class Tonemapping : PostEffectsBase // TypeDefIndex: 8211
{
	public Tonemapping.TonemapperType type; 
	public Tonemapping.AdaptiveTexSize adaptiveTextureSize; 
	public AnimationCurve remapCurve; 
	private Texture2D curveTex; 
	public float exposureAdjustment; 
	public float middleGrey; 
	public float white; 
	public float adaptionSpeed; 
	public Shader tonemapper; 
	public bool validRenderTextureFormat; 
	private Material tonemapMaterial; 
	private RenderTexture rt; 
	private RenderTextureFormat rtFormat; 


public override bool CheckResources() { }

public float UpdateCurve() { }

private void OnDisable() { }

private bool CreateInternalRenderTexture() { }

	[ImageEffectTransformsToLDR] 
private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

public void .ctor() { }

}

public enum Tonemapping.TonemapperType // TypeDefIndex: 8212
{
	public int value__; 
public const Tonemapping.TonemapperType SimpleReinhard = 0;
public const Tonemapping.TonemapperType UserCurve = 1;
public const Tonemapping.TonemapperType Hable = 2;
public const Tonemapping.TonemapperType Photographic = 3;
public const Tonemapping.TonemapperType OptimizedHejiDawson = 4;
public const Tonemapping.TonemapperType AdaptiveReinhard = 5;
public const Tonemapping.TonemapperType AdaptiveReinhardAutoWhite = 6;

}

public enum Tonemapping.AdaptiveTexSize // TypeDefIndex: 8213
{
	public int value__; 
public const Tonemapping.AdaptiveTexSize Square16 = 16;
public const Tonemapping.AdaptiveTexSize Square32 = 32;
public const Tonemapping.AdaptiveTexSize Square64 = 64;
public const Tonemapping.AdaptiveTexSize Square128 = 128;
public const Tonemapping.AdaptiveTexSize Square256 = 256;
public const Tonemapping.AdaptiveTexSize Square512 = 512;
public const Tonemapping.AdaptiveTexSize Square1024 = 1024;

}

public class TonemappingOverlay : ImageEffectLayer // TypeDefIndex: 9136
{
	public TonemappingColorGrading tonemapping; 
	private int screenWidth; 
	private int screenHeight; 


public void Awake() { }

public override void Start() { }

private void ResetColorGrading() { }

protected void Update() { }

public void .ctor() { }

}

public class TonemappingColorGrading : MonoBehaviour // TypeDefIndex: 11651
{
	[SerializeField] 
	[TonemappingColorGrading.SettingsGroup] 
	private TonemappingColorGrading.EyeAdaptationSettings m_EyeAdaptation; 
	[SerializeField] 
	[TonemappingColorGrading.SettingsGroup] 
	private TonemappingColorGrading.TonemappingSettings m_Tonemapping; 
	[SerializeField] 
	[TonemappingColorGrading.SettingsGroup] 
	private TonemappingColorGrading.ColorGradingSettings m_ColorGrading; 
	[SerializeField] 
	[TonemappingColorGrading.SettingsGroup] 
	private TonemappingColorGrading.LUTSettings m_Lut; 
	private Texture2D m_IdentityLut; 
	private RenderTexture m_InternalLut; 
	private Texture2D m_CurveTexture; 
	private Texture2D m_TonemapperCurve; 
	private float m_TonemapperCurveRange; 
	[SerializeField] 
	private Shader m_Shader; 
	private Material m_Material; 
	[CompilerGeneratedAttribute] 
	private bool <validRenderTextureFormat>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <validUserLutSize>k__BackingField; 
	private bool m_Dirty; 
	private bool m_TonemapperDirty; 
	private RenderTexture m_SmallAdaptiveRt; 
	private RenderTextureFormat m_AdaptiveRtFormat; 
	private RenderTexture[] rts; 

public TonemappingColorGrading.EyeAdaptationSettings eyeAdaptation { get; set; }
public TonemappingColorGrading.TonemappingSettings tonemapping { get; set; }
public TonemappingColorGrading.ColorGradingSettings colorGrading { get; set; }
public TonemappingColorGrading.LUTSettings lut { get; set; }
private Texture2D identityLut { get; }
private RenderTexture internalLutRt { get; }
private Texture2D curveTexture { get; }
private Texture2D tonemapperCurve { get; }
public Shader shader { get; }
public Material material { get; }
public bool isGammaColorSpace { get; }
public int lutSize { get; }
public bool validRenderTextureFormat { get; set; }
public bool validUserLutSize { get; set; }


public TonemappingColorGrading.EyeAdaptationSettings get_eyeAdaptation() { }

public void set_eyeAdaptation(TonemappingColorGrading.EyeAdaptationSettings value) { }

public TonemappingColorGrading.TonemappingSettings get_tonemapping() { }

public void set_tonemapping(TonemappingColorGrading.TonemappingSettings value) { }

public TonemappingColorGrading.ColorGradingSettings get_colorGrading() { }

public void set_colorGrading(TonemappingColorGrading.ColorGradingSettings value) { }

public TonemappingColorGrading.LUTSettings get_lut() { }

public void set_lut(TonemappingColorGrading.LUTSettings value) { }

private Texture2D get_identityLut() { }

private RenderTexture get_internalLutRt() { }

private Texture2D get_curveTexture() { }

private Texture2D get_tonemapperCurve() { }

public Shader get_shader() { }

public Material get_material() { }

public bool get_isGammaColorSpace() { }

public int get_lutSize() { }

	[CompilerGeneratedAttribute] 
public bool get_validRenderTextureFormat() { }

	[CompilerGeneratedAttribute] 
private void set_validRenderTextureFormat(bool value) { }

	[CompilerGeneratedAttribute] 
public bool get_validUserLutSize() { }

	[CompilerGeneratedAttribute] 
private void set_validUserLutSize(bool value) { }

public void SetDirty() { }

public void SetTonemapperDirty() { }

private void OnEnable() { }

private void OnDisable() { }

private void OnValidate() { }

private static Texture2D GenerateIdentityLut(int dim) { }

private float StandardIlluminantY(float x) { }

private Vector3 CIExyToLMS(float x, float y) { }

private Vector3 GetWhiteBalance() { }

private static Color NormalizeColor(Color c) { }

private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain) { }

private void GenCurveTexture() { }

private bool CheckUserLut() { }

private bool CheckSmallAdaptiveRt() { }

	[ImageEffectTransformsToLDR] 
public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

public Texture2D BakeLUT() { }

public void .ctor() { }

}

public class TonemappingColorGrading.SettingsGroup : Attribute // TypeDefIndex: 11652
{

public void .ctor() { }

}

public class TonemappingColorGrading.IndentedGroup : PropertyAttribute // TypeDefIndex: 11653
{

public void .ctor() { }

}

public class TonemappingColorGrading.ChannelMixer : PropertyAttribute // TypeDefIndex: 11654
{

public void .ctor() { }

}

public class TonemappingColorGrading.ColorWheelGroup : PropertyAttribute // TypeDefIndex: 11655
{
	public int minSizePerWheel; 
	public int maxSizePerWheel; 


public void .ctor() { }

public void .ctor(int minSizePerWheel, int maxSizePerWheel) { }

}

public class TonemappingColorGrading.Curve : PropertyAttribute // TypeDefIndex: 11656
{
	public Color color; 


public void .ctor() { }

public void .ctor(float r, float g, float b, float a) { }

}

public struct TonemappingColorGrading.EyeAdaptationSettings // TypeDefIndex: 11657
{
	public bool enabled; 
	[MinAttribute] 
	[TooltipAttribute] 
	public float middleGrey; 
	[TooltipAttribute] 
	public float min; 
	[TooltipAttribute] 
	public float max; 
	[MinAttribute] 
	[TooltipAttribute] 
	public float speed; 
	[TooltipAttribute] 
	public bool showDebug; 

public static TonemappingColorGrading.EyeAdaptationSettings defaultSettings { get; }


public static TonemappingColorGrading.EyeAdaptationSettings get_defaultSettings() { }

}

public enum TonemappingColorGrading.Tonemapper // TypeDefIndex: 11658
{
	public int value__; 
public const TonemappingColorGrading.Tonemapper ACES = 0;
public const TonemappingColorGrading.Tonemapper Curve = 1;
public const TonemappingColorGrading.Tonemapper Hable = 2;
public const TonemappingColorGrading.Tonemapper HejlDawson = 3;
public const TonemappingColorGrading.Tonemapper Photographic = 4;
public const TonemappingColorGrading.Tonemapper Reinhard = 5;
public const TonemappingColorGrading.Tonemapper Neutral = 6;

}

public struct TonemappingColorGrading.TonemappingSettings // TypeDefIndex: 11659
{
	public bool enabled; 
	[TooltipAttribute] 
	public TonemappingColorGrading.Tonemapper tonemapper; 
	[MinAttribute] 
	[TooltipAttribute] 
	public float exposure; 
	[TooltipAttribute] 
	public AnimationCurve curve; 
	[RangeAttribute] 
	public float neutralBlackIn; 
	[RangeAttribute] 
	public float neutralWhiteIn; 
	[RangeAttribute] 
	public float neutralBlackOut; 
	[RangeAttribute] 
	public float neutralWhiteOut; 
	[RangeAttribute] 
	public float neutralWhiteLevel; 
	[RangeAttribute] 
	public float neutralWhiteClip; 

public static TonemappingColorGrading.TonemappingSettings defaultSettings { get; }


public static TonemappingColorGrading.TonemappingSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.LUTSettings // TypeDefIndex: 11660
{
	public bool enabled; 
	[TooltipAttribute] 
	public Texture texture; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float contribution; 

public static TonemappingColorGrading.LUTSettings defaultSettings { get; }


public static TonemappingColorGrading.LUTSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.ColorWheelsSettings // TypeDefIndex: 11661
{
	[ColorUsageAttribute] 
	public Color shadows; 
	[ColorUsageAttribute] 
	public Color midtones; 
	[ColorUsageAttribute] 
	public Color highlights; 

public static TonemappingColorGrading.ColorWheelsSettings defaultSettings { get; }


public static TonemappingColorGrading.ColorWheelsSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.BasicsSettings // TypeDefIndex: 11662
{
	[RangeAttribute] 
	[TooltipAttribute] 
	public float temperatureShift; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float tint; 
	[SpaceAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float hue; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float saturation; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float vibrance; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float value; 
	[SpaceAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float contrast; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float gain; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float gamma; 

public static TonemappingColorGrading.BasicsSettings defaultSettings { get; }


public static TonemappingColorGrading.BasicsSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.ChannelMixerSettings // TypeDefIndex: 11663
{
	public int currentChannel; 
	public Vector3[] channels; 

public static TonemappingColorGrading.ChannelMixerSettings defaultSettings { get; }


public static TonemappingColorGrading.ChannelMixerSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.CurvesSettings // TypeDefIndex: 11664
{
	[TonemappingColorGrading.Curve] 
	public AnimationCurve master; 
	[TonemappingColorGrading.Curve] 
	public AnimationCurve red; 
	[TonemappingColorGrading.Curve] 
	public AnimationCurve green; 
	[TonemappingColorGrading.Curve] 
	public AnimationCurve blue; 

public static TonemappingColorGrading.CurvesSettings defaultSettings { get; }
public static AnimationCurve defaultCurve { get; }


public static TonemappingColorGrading.CurvesSettings get_defaultSettings() { }

public static AnimationCurve get_defaultCurve() { }

}

public enum TonemappingColorGrading.ColorGradingPrecision // TypeDefIndex: 11665
{
	public int value__; 
public const TonemappingColorGrading.ColorGradingPrecision Normal = 16;
public const TonemappingColorGrading.ColorGradingPrecision High = 32;

}

public struct TonemappingColorGrading.ColorGradingSettings // TypeDefIndex: 11666
{
	public bool enabled; 
	[TooltipAttribute] 
	public TonemappingColorGrading.ColorGradingPrecision precision; 
	[SpaceAttribute] 
	[TonemappingColorGrading.ColorWheelGroup] 
	public TonemappingColorGrading.ColorWheelsSettings colorWheels; 
	[SpaceAttribute] 
	[TonemappingColorGrading.IndentedGroup] 
	public TonemappingColorGrading.BasicsSettings basics; 
	[SpaceAttribute] 
	[TonemappingColorGrading.ChannelMixer] 
	public TonemappingColorGrading.ChannelMixerSettings channelMixer; 
	[SpaceAttribute] 
	[TonemappingColorGrading.IndentedGroup] 
	public TonemappingColorGrading.CurvesSettings curves; 
	[SpaceAttribute] 
	[TooltipAttribute] 
	public bool useDithering; 
	[TooltipAttribute] 
	public bool showDebug; 

public static TonemappingColorGrading.ColorGradingSettings defaultSettings { get; }


public static TonemappingColorGrading.ColorGradingSettings get_defaultSettings() { }

internal void Reset() { }

}

private enum TonemappingColorGrading.Pass // TypeDefIndex: 11667
{
	public int value__; 
public const TonemappingColorGrading.Pass LutGen = 0;
public const TonemappingColorGrading.Pass AdaptationLog = 1;
public const TonemappingColorGrading.Pass AdaptationExpBlend = 2;
public const TonemappingColorGrading.Pass AdaptationExp = 3;
public const TonemappingColorGrading.Pass TonemappingOff = 4;
public const TonemappingColorGrading.Pass TonemappingOff_LUT = 5;
public const TonemappingColorGrading.Pass TonemappingACES = 6;
public const TonemappingColorGrading.Pass TonemappingACES_LUT = 7;
public const TonemappingColorGrading.Pass TonemappingCurve = 8;
public const TonemappingColorGrading.Pass TonemappingCurve_LUT = 9;
public const TonemappingColorGrading.Pass TonemappingHable = 10;
public const TonemappingColorGrading.Pass TonemappingHable_LUT = 11;
public const TonemappingColorGrading.Pass TonemappingHejlDawson = 12;
public const TonemappingColorGrading.Pass TonemappingHejlDawson_LUT = 13;
public const TonemappingColorGrading.Pass TonemappingPhotographic = 14;
public const TonemappingColorGrading.Pass TonemappingPhotographic_LUT = 15;
public const TonemappingColorGrading.Pass TonemappingReinhard = 16;
public const TonemappingColorGrading.Pass TonemappingReinhard_LUT = 17;
public const TonemappingColorGrading.Pass TonemappingNeutral = 18;
public const TonemappingColorGrading.Pass TonemappingNeutral_LUT = 19;
public const TonemappingColorGrading.Pass AdaptationDebug = 20;

}

