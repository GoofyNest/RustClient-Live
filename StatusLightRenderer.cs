public class StatusLightRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 9239
{	public Material offMaterial; // 0x18
	public Material onMaterial; // 0x20
	private MaterialPropertyBlock propertyBlock; // 0x28
	private Renderer targetRenderer; // 0x30
	private Color lightColor; // 0x38
	private Light targetLight; // 0x48
	private int colorID; // 0x50
	private int emissionID; // 0x54


	protected void Awake() { }

	public void SetOff() { }

	public void SetOn() { }

	public void SetRed() { }

	public void SetGreen() { }

	private Color GetColor(byte r, byte g, byte b, byte a) { }

	private Color GetColor(byte r, byte g, byte b, byte a, float intensity) { }

	public void .ctor() { }

}

