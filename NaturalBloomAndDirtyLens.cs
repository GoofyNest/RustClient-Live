public class NaturalBloomAndDirtyLens : MonoBehaviour // TypeDefIndex: 10097
{
	public Shader shader; 
	public Texture2D lensDirtTexture; 
	public float range; 
	public float cutoff; 
	[RangeAttribute] 
	public float bloomIntensity; 
	[RangeAttribute] 
	public float lensDirtIntensity; 
	[RangeAttribute] 
	public float spread; 
	[RangeAttribute] 
	public int iterations; 
	[RangeAttribute] 
	public int mips; 
	public float[] mipWeights; 
	public bool highPrecision; 
	public bool downscaleSource; 
	public bool debug; 
	public bool temporalFilter; 
	[RangeAttribute] 
	public float temporalFilterWeight; 
	private Material material; 
	private float blurSize; 
	private RenderTexture temporalHistory; 
	private static int[] paramID; 
	private static int[] sourceID; 


	private void OnDisable() { }

	private void UpdateMaterial(bool encoding) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private static class NaturalBloomAndDirtyLens.Param // TypeDefIndex: 10098
{
	public const int _BloomRange = 0;
	public const int _BloomCutoff = 1;
	public const int _BloomIntensity = 2;
	public const int _LensDirtIntensity = 3;
	public const int _MipWeights = 4;
	public const int _LensDirt = 5;
	public const int _BlurSize = 6;
	public const int _TemporalHistory = 7;
	public const int _TemporalFilterWeight = 8;

}

