public class IronSights : MonoBehaviour // TypeDefIndex: 11436
{	public bool Enabled; // 0x18
	[HeaderAttribute] // RVA: 0xB0660 Offset: 0xAFA60 VA: 0x1800B0660
	public IronsightAimPoint aimPoint; // 0x20
	public float fieldOfViewOffset; // 0x28
	public float zoomFactor; // 0x2C
	[HeaderAttribute] // RVA: 0xB0750 Offset: 0xAFB50 VA: 0x1800B0750
	public float introSpeed; // 0x30
	public AnimationCurve introCurve; // 0x38
	public float outroSpeed; // 0x40
	public AnimationCurve outroCurve; // 0x48
	[HeaderAttribute] // RVA: 0xA9E90 Offset: 0xA9290 VA: 0x1800A9E90
	public SoundDefinition upSound; // 0x50
	public SoundDefinition downSound; // 0x58
	[HeaderAttribute] // RVA: 0xB0850 Offset: 0xAFC50 VA: 0x1800B0850
	public IronSightOverride ironsightsOverride; // 0x60
	public bool processUltrawideOffset; // 0x68
	private Animator animator; // 0x70
	private int param_ironsightstrength; // 0x78
	private int param_ironsightsEnabled; // 0x7C
	private float delta; // 0x80
	private float rawDelta; // 0x84
	private float maxDelta; // 0x88
	private Vector3 positionOffset; // 0x8C
	private Quaternion rotationOffset; // 0x98
	private AnimationCurve currentCurve; // 0xA8


	public void OnEnable() { }

	public void Update() { }

	public void UpdateIronsights(ref CachedTransform<BaseViewModel> vm, Camera cam) { }

	private float GetUltrawideOffset() { }

	public void SetIronsightsEnabled(bool b) { }

	public void SetEnabled(bool val) { }

	public float GetFOVOffset(float fFOV) { }

	public float GetDelta() { }

	public void .ctor() { }

}

