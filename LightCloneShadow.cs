public class LightCloneShadow : MonoBehaviour // TypeDefIndex: 10683
{	// Fields
	public bool cloneShadowMap; // 0x18
	public string shaderPropNameMap; // 0x20
	[RangeAttribute] // RVA: 0x710E0 Offset: 0x704E0 VA: 0x1800710E0
	public int cloneShadowMapDownscale; // 0x28
	public RenderTexture map; // 0x30
	public bool cloneShadowMask; // 0x38
	public string shaderPropNameMask; // 0x40
	[RangeAttribute] // RVA: 0x710E0 Offset: 0x704E0 VA: 0x1800710E0
	public int cloneShadowMaskDownscale; // 0x48
	public RenderTexture mask; // 0x50
	private Light light; // 0x58
	private CommandBuffer mapCB; // 0x60
	private CommandBuffer maskCB; // 0x68
	private int screenWidth; // 0x70
	private int screenHeight; // 0x74

	// Methods

	// RVA: 0x6C4DB0 Offset: 0x6C41B0 VA: 0x1806C4DB0
	private void OnEnable() { }

	// RVA: 0x6C4D40 Offset: 0x6C4140 VA: 0x1806C4D40
	private void OnDestroy() { }

	// RVA: 0x6C4F50 Offset: 0x6C4350 VA: 0x1806C4F50
	private void Update() { }

	// RVA: 0x6C4470 Offset: 0x6C3870 VA: 0x1806C4470
	private void AllocateShadowClone() { }

	// RVA: 0x6C4B50 Offset: 0x6C3F50 VA: 0x1806C4B50
	private void DestroyShadowClone() { }

	// RVA: 0x6C4E60 Offset: 0x6C4260 VA: 0x1806C4E60
	private void UpdateShadowMask() { }

	// RVA: 0x6C5110 Offset: 0x6C4510 VA: 0x1806C5110
	public void .ctor() { }

}

