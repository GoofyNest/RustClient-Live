public class StatusLightRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 9239
{	// Fields
	public Material offMaterial; // 0x18
	public Material onMaterial; // 0x20
	private MaterialPropertyBlock propertyBlock; // 0x28
	private Renderer targetRenderer; // 0x30
	private Color lightColor; // 0x38
	private Light targetLight; // 0x48
	private int colorID; // 0x50
	private int emissionID; // 0x54

	// Methods

	// RVA: 0xA889A0 Offset: 0xA87DA0 VA: 0x180A889A0
	protected void Awake() { }

	// RVA: 0xA88CB0 Offset: 0xA880B0 VA: 0x180A88CB0
	public void SetOff() { }

	// RVA: 0xA88DB0 Offset: 0xA881B0 VA: 0x180A88DB0
	public void SetOn() { }

	// RVA: 0xA88EA0 Offset: 0xA882A0 VA: 0x180A88EA0
	public void SetRed() { }

	// RVA: 0xA88B50 Offset: 0xA87F50 VA: 0x180A88B50
	public void SetGreen() { }

	// RVA: 0xA88A60 Offset: 0xA87E60 VA: 0x180A88A60
	private Color GetColor(byte r, byte g, byte b, byte a) { }

	// RVA: 0xA88AC0 Offset: 0xA87EC0 VA: 0x180A88AC0
	private Color GetColor(byte r, byte g, byte b, byte a, float intensity) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

