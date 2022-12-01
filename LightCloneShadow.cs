public class LightCloneShadow : MonoBehaviour // TypeDefIndex: 12442
{
	public bool cloneShadowMap;
	public string shaderPropNameMap;
	[RangeAttribute]
	public int cloneShadowMapDownscale;
	public RenderTexture map;
	public bool cloneShadowMask;
	public string shaderPropNameMask;
	[RangeAttribute]
	public int cloneShadowMaskDownscale;
	public RenderTexture mask;
	private Light light;
	private CommandBuffer mapCB;
	private CommandBuffer maskCB;
	private int screenWidth;
	private int screenHeight;


	private void OnEnable() { }

	private void OnDestroy() { }

	private void Update() { }

	private void AllocateShadowClone() { }

	private void DestroyShadowClone() { }

	private void UpdateShadowMask() { }

	public void .ctor() { }

}

