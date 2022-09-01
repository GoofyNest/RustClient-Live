public class EmissionToggle : MonoBehaviour, IClientComponent // TypeDefIndex: 9347
{
	private Color emissionColor; 
	public Renderer[] targetRenderers; 
	public int materialIndex; 
	private bool inited; 
	private Nullable<float> emissionPercent; 
	private static MaterialPropertyBlock block; 
	private static int emissionColorID; 


	public void OnEnable() { }

	private void Init() { }

	public void SetEmissionEnabled(bool on) { }

	public void SetEmission(float percent) { }

	public void .ctor() { }

	private static void .cctor() { }

}

