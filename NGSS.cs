public class NGSS_Directional : MonoBehaviour // TypeDefIndex: 13241
{
	[TooltipAttribute] 
	[RangeAttribute] 
	public float PCSS_GLOBAL_SOFTNESS; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float PCSS_FILTER_DIR_MIN; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float PCSS_FILTER_DIR_MAX; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float BANDING_NOISE_AMOUNT; 
	[TooltipAttribute] 
	public NGSS_Directional.SAMPLER_COUNT SAMPLERS_COUNT; 


	private void Update() { }

	private void SetGlobalSettings(bool enabled) { }

	public void .ctor() { }

}

public enum NGSS_Directional.SAMPLER_COUNT // TypeDefIndex: 13242
{
	public int value__; 
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_16 = 0;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_25 = 1;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_32 = 2;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_64 = 3;

}

