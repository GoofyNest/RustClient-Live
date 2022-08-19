public class NGSS_Directional : MonoBehaviour // TypeDefIndex: 11502
{	// Fields
	[TooltipAttribute] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	[RangeAttribute] // RVA: 0xB8B00 Offset: 0xB7F00 VA: 0x1800B8B00
	public float PCSS_GLOBAL_SOFTNESS; // 0x18
	[TooltipAttribute] // RVA: 0xB8BB0 Offset: 0xB7FB0 VA: 0x1800B8BB0
	[RangeAttribute] // RVA: 0xB8BB0 Offset: 0xB7FB0 VA: 0x1800B8BB0
	public float PCSS_FILTER_DIR_MIN; // 0x1C
	[TooltipAttribute] // RVA: 0xB8D10 Offset: 0xB8110 VA: 0x1800B8D10
	[RangeAttribute] // RVA: 0xB8D10 Offset: 0xB8110 VA: 0x1800B8D10
	public float PCSS_FILTER_DIR_MAX; // 0x20
	[TooltipAttribute] // RVA: 0xB8DA0 Offset: 0xB81A0 VA: 0x1800B8DA0
	[RangeAttribute] // RVA: 0xB8DA0 Offset: 0xB81A0 VA: 0x1800B8DA0
	public float BANDING_NOISE_AMOUNT; // 0x24
	[TooltipAttribute] // RVA: 0xB8F10 Offset: 0xB8310 VA: 0x1800B8F10
	public NGSS_Directional.SAMPLER_COUNT SAMPLERS_COUNT; // 0x28

	// Methods

	// RVA: 0x7C1890 Offset: 0x7C0C90 VA: 0x1807C1890
	private void Update() { }

	// RVA: 0x7C17E0 Offset: 0x7C0BE0 VA: 0x1807C17E0
	private void SetGlobalSettings(bool enabled) { }

	// RVA: 0x7C19D0 Offset: 0x7C0DD0 VA: 0x1807C19D0
	public void .ctor() { }

}

public enum NGSS_Directional.SAMPLER_COUNT // TypeDefIndex: 11503
{	// Fields
	public int value__; // 0x0
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_16 = 0;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_25 = 1;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_32 = 2;
	public const NGSS_Directional.SAMPLER_COUNT SAMPLERS_64 = 3;

}

