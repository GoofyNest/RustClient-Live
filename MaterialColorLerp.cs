public class MaterialColorLerp : MonoBehaviour, IClientComponent // TypeDefIndex: 9643
{
	public Color startColor; 
	public Color endColor; 
	public Color currentColor; 
	public float delta; 
	private static MaterialPropertyBlock materialPropertyBlock; 
	private bool initialized; 
	private float lerpStartTime; 
	private List<Renderer> cachedRenderers; 


	public void OnEnable() { }

	private void Init() { }

	public void SetColorScale(float scale) { }

	public void Update() { }

	public void RefreshRenderers() { }

	private void UpdateMaterials(Color final) { }

	public void .ctor() { }

	private static void .cctor() { }

}

