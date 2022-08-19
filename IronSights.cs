public class IronSights : MonoBehaviour // TypeDefIndex: 11436
{	// Fields
	public bool Enabled; // 0x18
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

	// Methods

	// RVA: 0xA02C50 Offset: 0xA02050 VA: 0x180A02C50
	public void OnEnable() { }

	// RVA: 0xA037E0 Offset: 0xA02BE0 VA: 0x180A037E0
	public void Update() { }

	// RVA: 0xA02DC0 Offset: 0xA021C0 VA: 0x180A02DC0
	public void UpdateIronsights(ref CachedTransform<BaseViewModel> vm, Camera cam) { }

	// RVA: 0xA02AE0 Offset: 0xA01EE0 VA: 0x180A02AE0
	private float GetUltrawideOffset() { }

	// RVA: 0xA02CB0 Offset: 0xA020B0 VA: 0x180A02CB0
	public void SetIronsightsEnabled(bool b) { }

	// RVA: 0xA02CB0 Offset: 0xA020B0 VA: 0x180A02CB0
	public void SetEnabled(bool val) { }

	// RVA: 0xA02930 Offset: 0xA01D30 VA: 0x180A02930
	public float GetFOVOffset(float fFOV) { }

	// RVA: 0x5DCBF0 Offset: 0x5DBFF0 VA: 0x1805DCBF0
	public float GetDelta() { }

	// RVA: 0xA03A70 Offset: 0xA02E70 VA: 0x180A03A70
	public void .ctor() { }

}

