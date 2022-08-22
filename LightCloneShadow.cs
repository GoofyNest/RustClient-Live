public class LightCloneShadow : MonoBehaviour // TypeDefIndex: 10683
{	public bool cloneShadowMap; // 0x18
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


	private void OnEnable() { }

	private void OnDestroy() { }

	private void Update() { }

	private void AllocateShadowClone() { }

	private void DestroyShadowClone() { }

	private void UpdateShadowMask() { }

	public void .ctor() { }

}

