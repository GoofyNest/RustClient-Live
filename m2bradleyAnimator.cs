public class m2bradleyAnimator : MonoBehaviour // TypeDefIndex: 9593
{	// Fields
	public Animator m2Animator; // 0x18
	public Material treadLeftMaterial; // 0x20
	public Material treadRightMaterial; // 0x28
	private Rigidbody mainRigidbody; // 0x30
	[HeaderAttribute] // RVA: 0x78420 Offset: 0x77820 VA: 0x180078420
	public Transform turret; // 0x38
	public Transform mainCannon; // 0x40
	public Transform coaxGun; // 0x48
	public Transform rocketsPitch; // 0x50
	public Transform spotLightYaw; // 0x58
	public Transform spotLightPitch; // 0x60
	public Transform sideMG; // 0x68
	public Transform[] sideguns; // 0x70
	[HeaderAttribute] // RVA: 0x785B0 Offset: 0x779B0 VA: 0x1800785B0
	public Transform[] ShocksBones; // 0x78
	public Transform[] ShockTraceLineBegin; // 0x80
	public Vector3[] vecShocksOffsetPosition; // 0x88
	[HeaderAttribute] // RVA: 0x786D0 Offset: 0x77AD0 VA: 0x1800786D0
	public Transform targetTurret; // 0x90
	public Transform targetSpotLight; // 0x98
	public Transform[] targetSideguns; // 0xA0
	private Vector3 vecTurret; // 0xA8
	private Vector3 vecMainCannon; // 0xB4
	private Vector3 vecCoaxGun; // 0xC0
	private Vector3 vecRocketsPitch; // 0xCC
	private Vector3 vecSpotLightBase; // 0xD8
	private Vector3 vecSpotLight; // 0xE4
	private float sideMGPitchValue; // 0xF0
	[HeaderAttribute] // RVA: 0x79AA0 Offset: 0x78EA0 VA: 0x180079AA0
	public GameObject muzzleflashCannon; // 0xF8
	public GameObject muzzleflashCoaxGun; // 0x100
	public GameObject muzzleflashSideMG; // 0x108
	public GameObject[] muzzleflashRockets; // 0x110
	public GameObject spotLightHaloSawnpoint; // 0x118
	public GameObject[] muzzleflashSideguns; // 0x120
	[HeaderAttribute] // RVA: 0x79DD0 Offset: 0x791D0 VA: 0x180079DD0
	public GameObjectRef machineGunMuzzleFlashFX; // 0x128
	public GameObjectRef mainCannonFireFX; // 0x130
	public GameObjectRef rocketLaunchFX; // 0x138
	[HeaderAttribute] // RVA: 0x71D40 Offset: 0x71140 VA: 0x180071D40
	public bool rocketsOpen; // 0x140
	public Vector3[] vecSideGunRotation; // 0x148
	public float treadConstant; // 0x150
	public float wheelSpinConstant; // 0x154
	[HeaderAttribute] // RVA: 0x7A150 Offset: 0x79550 VA: 0x18007A150
	public float sidegunsTurnSpeed; // 0x158
	public float turretTurnSpeed; // 0x15C
	public float cannonPitchSpeed; // 0x160
	public float rocketPitchSpeed; // 0x164
	public float spotLightTurnSpeed; // 0x168
	public float machineGunSpeed; // 0x16C
	private float wheelAngle; // 0x170

	// Methods

	// RVA: 0x1A990D0 Offset: 0x1A984D0 VA: 0x181A990D0
	private void Start() { }

	// RVA: 0x1A9A300 Offset: 0x1A99700 VA: 0x181A9A300
	private void Update() { }

	// RVA: 0x1A98AA0 Offset: 0x1A97EA0 VA: 0x181A98AA0
	private void AnimateWheelsTreads() { }

	// RVA: 0x1A98510 Offset: 0x1A97910 VA: 0x181A98510
	private void AdjustShocksHeight() { }

	// RVA: 0x1A99CA0 Offset: 0x1A990A0 VA: 0x181A99CA0
	private void TrackTurret() { }

	// RVA: 0x1A99880 Offset: 0x1A98C80 VA: 0x181A99880
	private void TrackSpotLight() { }

	// RVA: 0x1A991D0 Offset: 0x1A985D0 VA: 0x181A991D0
	private void TrackSideGuns() { }

	// RVA: 0x1A98E00 Offset: 0x1A98200 VA: 0x181A98E00
	public void CalculateYawPitchOffset(Transform objectTransform, Vector3 vecStart, Vector3 vecEnd, out float yaw, out float pitch) { }

	// RVA: 0x1A990A0 Offset: 0x1A984A0 VA: 0x181A990A0
	public float NormalizeYaw(float flYaw) { }

	// RVA: 0x1A9A390 Offset: 0x1A99790 VA: 0x181A9A390
	public void .ctor() { }

}

