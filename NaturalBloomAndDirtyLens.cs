public class NaturalBloomAndDirtyLens : MonoBehaviour // TypeDefIndex: 10097
{	public Shader shader; // 0x18
	public Texture2D lensDirtTexture; // 0x20
	public float range; // 0x28
	public float cutoff; // 0x2C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float bloomIntensity; // 0x30
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float lensDirtIntensity; // 0x34
	[RangeAttribute] // RVA: 0xB4350 Offset: 0xB3750 VA: 0x1800B4350
	public float spread; // 0x38
	[RangeAttribute] // RVA: 0xB4350 Offset: 0xB3750 VA: 0x1800B4350
	public int iterations; // 0x3C
	[RangeAttribute] // RVA: 0xB43A0 Offset: 0xB37A0 VA: 0x1800B43A0
	public int mips; // 0x40
	public float[] mipWeights; // 0x48
	public bool highPrecision; // 0x50
	public bool downscaleSource; // 0x51
	public bool debug; // 0x52
	public bool temporalFilter; // 0x53
	[RangeAttribute] // RVA: 0xB44A0 Offset: 0xB38A0 VA: 0x1800B44A0
	public float temporalFilterWeight; // 0x54
	private Material material; // 0x58
	private float blurSize; // 0x60
	private RenderTexture temporalHistory; // 0x68
	private static int[] paramID; // 0x0
	private static int[] sourceID; // 0x8


	private void OnDisable() { }

	private void UpdateMaterial(bool encoding) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private static class NaturalBloomAndDirtyLens.Param // TypeDefIndex: 10098
{	public const int _BloomRange = 0;
	public const int _BloomCutoff = 1;
	public const int _BloomIntensity = 2;
	public const int _LensDirtIntensity = 3;
	public const int _MipWeights = 4;
	public const int _LensDirt = 5;
	public const int _BlurSize = 6;
	public const int _TemporalHistory = 7;
	public const int _TemporalFilterWeight = 8;

}

