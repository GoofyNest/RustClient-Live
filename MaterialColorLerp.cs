public class MaterialColorLerp : MonoBehaviour, IClientComponent // TypeDefIndex: 9638
{	public Color startColor; // 0x18
	public Color endColor; // 0x28
	public Color currentColor; // 0x38
	public float delta; // 0x48
	private static MaterialPropertyBlock materialPropertyBlock; // 0x0
	private bool initialized; // 0x4C
	private float lerpStartTime; // 0x50
	private List<Renderer> cachedRenderers; // 0x58


	public void OnEnable() { }

	private void Init() { }

	public void SetColorScale(float scale) { }

	public void Update() { }

	public void RefreshRenderers() { }

	private void UpdateMaterials(Color final) { }

	public void .ctor() { }

	private static void .cctor() { }

}

