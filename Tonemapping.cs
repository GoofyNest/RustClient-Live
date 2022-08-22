public class Tonemapping : PostEffectsBase // TypeDefIndex: 8211
{	public Tonemapping.TonemapperType type; // 0x28
	public Tonemapping.AdaptiveTexSize adaptiveTextureSize; // 0x2C
	public AnimationCurve remapCurve; // 0x30
	private Texture2D curveTex; // 0x38
	public float exposureAdjustment; // 0x40
	public float middleGrey; // 0x44
	public float white; // 0x48
	public float adaptionSpeed; // 0x4C
	public Shader tonemapper; // 0x50
	public bool validRenderTextureFormat; // 0x58
	private Material tonemapMaterial; // 0x60
	private RenderTexture rt; // 0x68
	private RenderTextureFormat rtFormat; // 0x70


	public override bool CheckResources() { }

	public float UpdateCurve() { }

	private void OnDisable() { }

	private bool CreateInternalRenderTexture() { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum Tonemapping.TonemapperType // TypeDefIndex: 8212
{	public int value__; // 0x0
	public const Tonemapping.TonemapperType SimpleReinhard = 0;
	public const Tonemapping.TonemapperType UserCurve = 1;
	public const Tonemapping.TonemapperType Hable = 2;
	public const Tonemapping.TonemapperType Photographic = 3;
	public const Tonemapping.TonemapperType OptimizedHejiDawson = 4;
	public const Tonemapping.TonemapperType AdaptiveReinhard = 5;
	public const Tonemapping.TonemapperType AdaptiveReinhardAutoWhite = 6;

}

public enum Tonemapping.AdaptiveTexSize // TypeDefIndex: 8213
{	public int value__; // 0x0
	public const Tonemapping.AdaptiveTexSize Square16 = 16;
	public const Tonemapping.AdaptiveTexSize Square32 = 32;
	public const Tonemapping.AdaptiveTexSize Square64 = 64;
	public const Tonemapping.AdaptiveTexSize Square128 = 128;
	public const Tonemapping.AdaptiveTexSize Square256 = 256;
	public const Tonemapping.AdaptiveTexSize Square512 = 512;
	public const Tonemapping.AdaptiveTexSize Square1024 = 1024;

}

public class TonemappingOverlay : ImageEffectLayer // TypeDefIndex: 9136
{	public TonemappingColorGrading tonemapping; // 0x30
	private int screenWidth; // 0x38
	private int screenHeight; // 0x3C


	public void Awake() { }

	public override void Start() { }

	private void ResetColorGrading() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TonemappingColorGrading : MonoBehaviour // TypeDefIndex: 11651
{	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private TonemappingColorGrading.EyeAdaptationSettings m_EyeAdaptation; // 0x18
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private TonemappingColorGrading.TonemappingSettings m_Tonemapping; // 0x30
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private TonemappingColorGrading.ColorGradingSettings m_ColorGrading; // 0x60
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[TonemappingColorGrading.SettingsGroup] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private TonemappingColorGrading.LUTSettings m_Lut; // 0xF8
	private Texture2D m_IdentityLut; // 0x110
	private RenderTexture m_InternalLut; // 0x118
	private Texture2D m_CurveTexture; // 0x120
	private Texture2D m_TonemapperCurve; // 0x128
	private float m_TonemapperCurveRange; // 0x130
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Shader m_Shader; // 0x138
	private Material m_Material; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <validRenderTextureFormat>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <validUserLutSize>k__BackingField; // 0x149
	private bool m_Dirty; // 0x14A
	private bool m_TonemapperDirty; // 0x14B
	private RenderTexture m_SmallAdaptiveRt; // 0x150
	private RenderTextureFormat m_AdaptiveRtFormat; // 0x158
	private RenderTexture[] rts; // 0x160

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_validRenderTextureFormat() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_validRenderTextureFormat(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_validUserLutSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[ImageEffectTransformsToLDR] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	public int minSizePerWheel; // 0x10
	public int maxSizePerWheel; // 0x14


	public void .ctor() { }

	public void .ctor(int minSizePerWheel, int maxSizePerWheel) { }

}

public class TonemappingColorGrading.Curve : PropertyAttribute // TypeDefIndex: 11656
{	public Color color; // 0x10


	public void .ctor() { }

	public void .ctor(float r, float g, float b, float a) { }

}

public struct TonemappingColorGrading.EyeAdaptationSettings // TypeDefIndex: 11657
{	public bool enabled; // 0x0
	[MinAttribute] // RVA: 0xCB6F0 Offset: 0xCAAF0 VA: 0x1800CB6F0
	[TooltipAttribute] // RVA: 0xCB6F0 Offset: 0xCAAF0 VA: 0x1800CB6F0
	public float middleGrey; // 0x4
	[TooltipAttribute] // RVA: 0xCB9C0 Offset: 0xCADC0 VA: 0x1800CB9C0
	public float min; // 0x8
	[TooltipAttribute] // RVA: 0xCBB50 Offset: 0xCAF50 VA: 0x1800CBB50
	public float max; // 0xC
	[MinAttribute] // RVA: 0xCBC60 Offset: 0xCB060 VA: 0x1800CBC60
	[TooltipAttribute] // RVA: 0xCBC60 Offset: 0xCB060 VA: 0x1800CBC60
	public float speed; // 0x10
	[TooltipAttribute] // RVA: 0xCBDC0 Offset: 0xCB1C0 VA: 0x1800CBDC0
	public bool showDebug; // 0x14

	public static TonemappingColorGrading.EyeAdaptationSettings defaultSettings { get; }


	public static TonemappingColorGrading.EyeAdaptationSettings get_defaultSettings() { }

}

public enum TonemappingColorGrading.Tonemapper // TypeDefIndex: 11658
{	public int value__; // 0x0
	public const TonemappingColorGrading.Tonemapper ACES = 0;
	public const TonemappingColorGrading.Tonemapper Curve = 1;
	public const TonemappingColorGrading.Tonemapper Hable = 2;
	public const TonemappingColorGrading.Tonemapper HejlDawson = 3;
	public const TonemappingColorGrading.Tonemapper Photographic = 4;
	public const TonemappingColorGrading.Tonemapper Reinhard = 5;
	public const TonemappingColorGrading.Tonemapper Neutral = 6;

}

public struct TonemappingColorGrading.TonemappingSettings // TypeDefIndex: 11659
{	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xCBF50 Offset: 0xCB350 VA: 0x1800CBF50
	public TonemappingColorGrading.Tonemapper tonemapper; // 0x4
	[MinAttribute] // RVA: 0xCC020 Offset: 0xCB420 VA: 0x1800CC020
	[TooltipAttribute] // RVA: 0xCC020 Offset: 0xCB420 VA: 0x1800CC020
	public float exposure; // 0x8
	[TooltipAttribute] // RVA: 0xCC250 Offset: 0xCB650 VA: 0x1800CC250
	public AnimationCurve curve; // 0x10
	[RangeAttribute] // RVA: 0xCC320 Offset: 0xCB720 VA: 0x1800CC320
	public float neutralBlackIn; // 0x18
	[RangeAttribute] // RVA: 0xCC4B0 Offset: 0xCB8B0 VA: 0x1800CC4B0
	public float neutralWhiteIn; // 0x1C
	[RangeAttribute] // RVA: 0xCC620 Offset: 0xCBA20 VA: 0x1800CC620
	public float neutralBlackOut; // 0x20
	[RangeAttribute] // RVA: 0xCC6B0 Offset: 0xCBAB0 VA: 0x1800CC6B0
	public float neutralWhiteOut; // 0x24
	[RangeAttribute] // RVA: 0xCAE10 Offset: 0xCA210 VA: 0x1800CAE10
	public float neutralWhiteLevel; // 0x28
	[RangeAttribute] // RVA: 0xB43A0 Offset: 0xB37A0 VA: 0x1800B43A0
	public float neutralWhiteClip; // 0x2C

	public static TonemappingColorGrading.TonemappingSettings defaultSettings { get; }


	public static TonemappingColorGrading.TonemappingSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.LUTSettings // TypeDefIndex: 11660
{	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xCCA20 Offset: 0xCBE20 VA: 0x1800CCA20
	public Texture texture; // 0x8
	[RangeAttribute] // RVA: 0xCCBE0 Offset: 0xCBFE0 VA: 0x1800CCBE0
	[TooltipAttribute] // RVA: 0xCCBE0 Offset: 0xCBFE0 VA: 0x1800CCBE0
	public float contribution; // 0x10

	public static TonemappingColorGrading.LUTSettings defaultSettings { get; }


	public static TonemappingColorGrading.LUTSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.ColorWheelsSettings // TypeDefIndex: 11661
{	[ColorUsageAttribute] // RVA: 0xCCCF0 Offset: 0xCC0F0 VA: 0x1800CCCF0
	public Color shadows; // 0x0
	[ColorUsageAttribute] // RVA: 0xCCCF0 Offset: 0xCC0F0 VA: 0x1800CCCF0
	public Color midtones; // 0x10
	[ColorUsageAttribute] // RVA: 0xCCCF0 Offset: 0xCC0F0 VA: 0x1800CCCF0
	public Color highlights; // 0x20

	public static TonemappingColorGrading.ColorWheelsSettings defaultSettings { get; }


	public static TonemappingColorGrading.ColorWheelsSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.BasicsSettings // TypeDefIndex: 11662
{	[RangeAttribute] // RVA: 0xCCF40 Offset: 0xCC340 VA: 0x1800CCF40
	[TooltipAttribute] // RVA: 0xCCF40 Offset: 0xCC340 VA: 0x1800CCF40
	public float temperatureShift; // 0x0
	[RangeAttribute] // RVA: 0xCD070 Offset: 0xCC470 VA: 0x1800CD070
	[TooltipAttribute] // RVA: 0xCD070 Offset: 0xCC470 VA: 0x1800CD070
	public float tint; // 0x4
	[SpaceAttribute] // RVA: 0xCD270 Offset: 0xCC670 VA: 0x1800CD270
	[RangeAttribute] // RVA: 0xCD270 Offset: 0xCC670 VA: 0x1800CD270
	[TooltipAttribute] // RVA: 0xCD270 Offset: 0xCC670 VA: 0x1800CD270
	public float hue; // 0x8
	[RangeAttribute] // RVA: 0xCD420 Offset: 0xCC820 VA: 0x1800CD420
	[TooltipAttribute] // RVA: 0xCD420 Offset: 0xCC820 VA: 0x1800CD420
	public float saturation; // 0xC
	[RangeAttribute] // RVA: 0xCD510 Offset: 0xCC910 VA: 0x1800CD510
	[TooltipAttribute] // RVA: 0xCD510 Offset: 0xCC910 VA: 0x1800CD510
	public float vibrance; // 0x10
	[RangeAttribute] // RVA: 0xCD620 Offset: 0xCCA20 VA: 0x1800CD620
	[TooltipAttribute] // RVA: 0xCD620 Offset: 0xCCA20 VA: 0x1800CD620
	public float value; // 0x14
	[SpaceAttribute] // RVA: 0xCD830 Offset: 0xCCC30 VA: 0x1800CD830
	[RangeAttribute] // RVA: 0xCD830 Offset: 0xCCC30 VA: 0x1800CD830
	[TooltipAttribute] // RVA: 0xCD830 Offset: 0xCCC30 VA: 0x1800CD830
	public float contrast; // 0x18
	[RangeAttribute] // RVA: 0xCD9D0 Offset: 0xCCDD0 VA: 0x1800CD9D0
	[TooltipAttribute] // RVA: 0xCD9D0 Offset: 0xCCDD0 VA: 0x1800CD9D0
	public float gain; // 0x1C
	[RangeAttribute] // RVA: 0xCDC70 Offset: 0xCD070 VA: 0x1800CDC70
	[TooltipAttribute] // RVA: 0xCDC70 Offset: 0xCD070 VA: 0x1800CDC70
	public float gamma; // 0x20

	public static TonemappingColorGrading.BasicsSettings defaultSettings { get; }


	public static TonemappingColorGrading.BasicsSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.ChannelMixerSettings // TypeDefIndex: 11663
{	public int currentChannel; // 0x0
	public Vector3[] channels; // 0x8

	public static TonemappingColorGrading.ChannelMixerSettings defaultSettings { get; }


	public static TonemappingColorGrading.ChannelMixerSettings get_defaultSettings() { }

}

public struct TonemappingColorGrading.CurvesSettings // TypeDefIndex: 11664
{	[TonemappingColorGrading.Curve] // RVA: 0xCDE20 Offset: 0xCD220 VA: 0x1800CDE20
	public AnimationCurve master; // 0x0
	[TonemappingColorGrading.Curve] // RVA: 0xCDF60 Offset: 0xCD360 VA: 0x1800CDF60
	public AnimationCurve red; // 0x8
	[TonemappingColorGrading.Curve] // RVA: 0xCE030 Offset: 0xCD430 VA: 0x1800CE030
	public AnimationCurve green; // 0x10
	[TonemappingColorGrading.Curve] // RVA: 0xCF550 Offset: 0xCE950 VA: 0x1800CF550
	public AnimationCurve blue; // 0x18

	public static TonemappingColorGrading.CurvesSettings defaultSettings { get; }
	public static AnimationCurve defaultCurve { get; }


	public static TonemappingColorGrading.CurvesSettings get_defaultSettings() { }

	public static AnimationCurve get_defaultCurve() { }

}

public enum TonemappingColorGrading.ColorGradingPrecision // TypeDefIndex: 11665
{	public int value__; // 0x0
	public const TonemappingColorGrading.ColorGradingPrecision Normal = 16;
	public const TonemappingColorGrading.ColorGradingPrecision High = 32;

}

public struct TonemappingColorGrading.ColorGradingSettings // TypeDefIndex: 11666
{	public bool enabled; // 0x0
	[TooltipAttribute] // RVA: 0xCF5C0 Offset: 0xCE9C0 VA: 0x1800CF5C0
	public TonemappingColorGrading.ColorGradingPrecision precision; // 0x4
	[SpaceAttribute] // RVA: 0xCF700 Offset: 0xCEB00 VA: 0x1800CF700
	[TonemappingColorGrading.ColorWheelGroup] // RVA: 0xCF700 Offset: 0xCEB00 VA: 0x1800CF700
	public TonemappingColorGrading.ColorWheelsSettings colorWheels; // 0x8
	[SpaceAttribute] // RVA: 0xCF840 Offset: 0xCEC40 VA: 0x1800CF840
	[TonemappingColorGrading.IndentedGroup] // RVA: 0xCF840 Offset: 0xCEC40 VA: 0x1800CF840
	public TonemappingColorGrading.BasicsSettings basics; // 0x38
	[SpaceAttribute] // RVA: 0xCF840 Offset: 0xCEC40 VA: 0x1800CF840
	[TonemappingColorGrading.ChannelMixer] // RVA: 0xCF840 Offset: 0xCEC40 VA: 0x1800CF840
	public TonemappingColorGrading.ChannelMixerSettings channelMixer; // 0x60
	[SpaceAttribute] // RVA: 0xCF840 Offset: 0xCEC40 VA: 0x1800CF840
	[TonemappingColorGrading.IndentedGroup] // RVA: 0xCF840 Offset: 0xCEC40 VA: 0x1800CF840
	public TonemappingColorGrading.CurvesSettings curves; // 0x70
	[SpaceAttribute] // RVA: 0xCFA00 Offset: 0xCEE00 VA: 0x1800CFA00
	[TooltipAttribute] // RVA: 0xCFA00 Offset: 0xCEE00 VA: 0x1800CFA00
	public bool useDithering; // 0x90
	[TooltipAttribute] // RVA: 0xCFCD0 Offset: 0xCF0D0 VA: 0x1800CFCD0
	public bool showDebug; // 0x91

	public static TonemappingColorGrading.ColorGradingSettings defaultSettings { get; }


	public static TonemappingColorGrading.ColorGradingSettings get_defaultSettings() { }

	internal void Reset() { }

}

private enum TonemappingColorGrading.Pass // TypeDefIndex: 11667
{	public int value__; // 0x0
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

