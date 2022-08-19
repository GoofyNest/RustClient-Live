internal class ScreenSpaceAmbientObscurance : PostEffectsBase // TypeDefIndex: 8201
{	// Fields
	[RangeAttribute] // RVA: 0x84380 Offset: 0x83780 VA: 0x180084380
	public float intensity; // 0x28
	[RangeAttribute] // RVA: 0x85710 Offset: 0x84B10 VA: 0x180085710
	public float radius; // 0x2C
	[RangeAttribute] // RVA: 0x84380 Offset: 0x83780 VA: 0x180084380
	public int blurIterations; // 0x30
	[RangeAttribute] // RVA: 0x75910 Offset: 0x74D10 VA: 0x180075910
	public float blurFilterDistance; // 0x34
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public int downsample; // 0x38
	public Texture2D rand; // 0x40
	public Shader aoShader; // 0x48
	private Material aoMaterial; // 0x50

	// Methods

	// RVA: 0x21E0730 Offset: 0x21DFB30 VA: 0x1821E0730 Slot: 4
	public override bool CheckResources() { }

	// RVA: 0x21E0790 Offset: 0x21DFB90 VA: 0x1821E0790
	private void OnDisable() { }

	[ImageEffectOpaque] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21E0840 Offset: 0x21DFC40 VA: 0x1821E0840
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E0F30 Offset: 0x21E0330 VA: 0x1821E0F30
	public void .ctor() { }

}

public class ScreenSpaceAmbientOcclusion : MonoBehaviour // TypeDefIndex: 8202
{	// Fields
	public float m_Radius; // 0x18
	public ScreenSpaceAmbientOcclusion.SSAOSamples m_SampleCount; // 0x1C
	public float m_OcclusionIntensity; // 0x20
	public int m_Blur; // 0x24
	public int m_Downsampling; // 0x28
	public float m_OcclusionAttenuation; // 0x2C
	public float m_MinZ; // 0x30
	public Shader m_SSAOShader; // 0x38
	private Material m_SSAOMaterial; // 0x40
	public Texture2D m_RandomTexture; // 0x48
	private bool m_Supported; // 0x50

	// Methods

	// RVA: 0x21E0F70 Offset: 0x21E0370 VA: 0x1821E0F70
	private static Material CreateMaterial(Shader shader) { }

	// RVA: 0x21E1170 Offset: 0x21E0570 VA: 0x1821E1170
	private static void DestroyMaterial(Material mat) { }

	// RVA: 0x21E1200 Offset: 0x21E0600 VA: 0x1821E1200
	private void OnDisable() { }

	// RVA: 0x21E1AE0 Offset: 0x21E0EE0 VA: 0x1821E1AE0
	private void Start() { }

	// RVA: 0x21E1290 Offset: 0x21E0690 VA: 0x1821E1290
	private void OnEnable() { }

	// RVA: 0x21E1020 Offset: 0x21E0420 VA: 0x1821E1020
	private void CreateMaterials() { }

	[ImageEffectOpaque] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21E12F0 Offset: 0x21E06F0 VA: 0x1821E12F0
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x21E1BA0 Offset: 0x21E0FA0 VA: 0x1821E1BA0
	public void .ctor() { }

}

public enum ScreenSpaceAmbientOcclusion.SSAOSamples // TypeDefIndex: 8203
{	// Fields
	public int value__; // 0x0
	public const ScreenSpaceAmbientOcclusion.SSAOSamples Low = 0;
	public const ScreenSpaceAmbientOcclusion.SSAOSamples Medium = 1;
	public const ScreenSpaceAmbientOcclusion.SSAOSamples High = 2;

}

public enum ScreenSpaceReflectionPreset // TypeDefIndex: 11796
{	// Fields
	public int value__; // 0x0
	public const ScreenSpaceReflectionPreset Lower = 0;
	public const ScreenSpaceReflectionPreset Low = 1;
	public const ScreenSpaceReflectionPreset Medium = 2;
	public const ScreenSpaceReflectionPreset High = 3;
	public const ScreenSpaceReflectionPreset Higher = 4;
	public const ScreenSpaceReflectionPreset Ultra = 5;
	public const ScreenSpaceReflectionPreset Overkill = 6;
	public const ScreenSpaceReflectionPreset Custom = 7;

}

public enum ScreenSpaceReflectionResolution // TypeDefIndex: 11797
{	// Fields
	public int value__; // 0x0
	public const ScreenSpaceReflectionResolution Downsampled = 0;
	public const ScreenSpaceReflectionResolution FullSize = 1;
	public const ScreenSpaceReflectionResolution Supersampled = 2;

}

public sealed class ScreenSpaceReflectionPresetParameter : ParameterOverride<ScreenSpaceReflectionPreset> // TypeDefIndex: 11798
{	// Methods

	// RVA: 0x11D7560 Offset: 0x11D6960 VA: 0x1811D7560
	public void .ctor() { }

}

public sealed class ScreenSpaceReflectionResolutionParameter : ParameterOverride<ScreenSpaceReflectionResolution> // TypeDefIndex: 11799
{	// Methods

	// RVA: 0x11D75A0 Offset: 0x11D69A0 VA: 0x1811D75A0
	public void .ctor() { }

}

public sealed class ScreenSpaceReflections : PostProcessEffectSettings // TypeDefIndex: 11800
{	// Fields
	[TooltipAttribute] // RVA: 0x75430 Offset: 0x74830 VA: 0x180075430
	public ScreenSpaceReflectionPresetParameter preset; // 0x30
	[RangeAttribute] // RVA: 0x75560 Offset: 0x74960 VA: 0x180075560
	[TooltipAttribute] // RVA: 0x75560 Offset: 0x74960 VA: 0x180075560
	public IntParameter maximumIterationCount; // 0x38
	[TooltipAttribute] // RVA: 0x75790 Offset: 0x74B90 VA: 0x180075790
	public ScreenSpaceReflectionResolutionParameter resolution; // 0x40
	[RangeAttribute] // RVA: 0x758C0 Offset: 0x74CC0 VA: 0x1800758C0
	[TooltipAttribute] // RVA: 0x758C0 Offset: 0x74CC0 VA: 0x1800758C0
	public FloatParameter thickness; // 0x48
	[TooltipAttribute] // RVA: 0x75A80 Offset: 0x74E80 VA: 0x180075A80
	public FloatParameter maximumMarchDistance; // 0x50
	[RangeAttribute] // RVA: 0x75D30 Offset: 0x75130 VA: 0x180075D30
	[TooltipAttribute] // RVA: 0x75D30 Offset: 0x75130 VA: 0x180075D30
	public FloatParameter distanceFade; // 0x58
	[RangeAttribute] // RVA: 0x75E70 Offset: 0x75270 VA: 0x180075E70
	[TooltipAttribute] // RVA: 0x75E70 Offset: 0x75270 VA: 0x180075E70
	public FloatParameter vignette; // 0x60

	// Methods

	// RVA: 0x11D93C0 Offset: 0x11D87C0 VA: 0x1811D93C0 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x11D9530 Offset: 0x11D8930 VA: 0x1811D9530
	public void .ctor() { }

}

internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections> // TypeDefIndex: 11801
{	// Fields
	private RenderTexture m_Resolve; // 0x20
	private RenderTexture m_History; // 0x28
	private int[] m_MipIDs; // 0x30
	private readonly ScreenSpaceReflectionsRenderer.QualityPreset[] m_Presets; // 0x38

	// Methods

	// RVA: 0x70CC90 Offset: 0x70C090 VA: 0x18070CC90 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x11D75E0 Offset: 0x11D69E0 VA: 0x1811D75E0
	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap) { }

	// RVA: 0x11D7880 Offset: 0x11D6C80 VA: 0x1811D7880 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x11D77E0 Offset: 0x11D6BE0 VA: 0x1811D77E0 Slot: 7
	public override void Release() { }

	// RVA: 0x11D8F90 Offset: 0x11D8390 VA: 0x1811D8F90
	public void .ctor() { }

}

private class ScreenSpaceReflectionsRenderer.QualityPreset // TypeDefIndex: 11802
{	// Fields
	public int maximumIterationCount; // 0x10
	public float thickness; // 0x14
	public ScreenSpaceReflectionResolution downsampling; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private enum ScreenSpaceReflectionsRenderer.Pass // TypeDefIndex: 11803
{	// Fields
	public int value__; // 0x0
	public const ScreenSpaceReflectionsRenderer.Pass Test = 0;
	public const ScreenSpaceReflectionsRenderer.Pass Resolve = 1;
	public const ScreenSpaceReflectionsRenderer.Pass Reproject = 2;
	public const ScreenSpaceReflectionsRenderer.Pass Composite = 3;

}

