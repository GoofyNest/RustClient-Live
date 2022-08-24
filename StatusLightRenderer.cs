public class StatusLightRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 9239
{
	public Material offMaterial; 
	public Material onMaterial; 
	private MaterialPropertyBlock propertyBlock; 
	private Renderer targetRenderer; 
	private Color lightColor; 
	private Light targetLight; 
	private int colorID; 
	private int emissionID; 


	protected void Awake() { }

	public void SetOff() { }

	public void SetOn() { }

	public void SetRed() { }

	public void SetGreen() { }

	private Color GetColor(byte r, byte g, byte b, byte a) { }

	private Color GetColor(byte r, byte g, byte b, byte a, float intensity) { }

	public void .ctor() { }

}

