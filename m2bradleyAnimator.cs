public class m2bradleyAnimator : MonoBehaviour // TypeDefIndex: 9593
{
	public Animator m2Animator; 
	public Material treadLeftMaterial; 
	public Material treadRightMaterial; 
	private Rigidbody mainRigidbody; 
	[HeaderAttribute] 
	public Transform turret; 
	public Transform mainCannon; 
	public Transform coaxGun; 
	public Transform rocketsPitch; 
	public Transform spotLightYaw; 
	public Transform spotLightPitch; 
	public Transform sideMG; 
	public Transform[] sideguns; 
	[HeaderAttribute] 
	public Transform[] ShocksBones; 
	public Transform[] ShockTraceLineBegin; 
	public Vector3[] vecShocksOffsetPosition; 
	[HeaderAttribute] 
	public Transform targetTurret; 
	public Transform targetSpotLight; 
	public Transform[] targetSideguns; 
	private Vector3 vecTurret; 
	private Vector3 vecMainCannon; 
	private Vector3 vecCoaxGun; 
	private Vector3 vecRocketsPitch; 
	private Vector3 vecSpotLightBase; 
	private Vector3 vecSpotLight; 
	private float sideMGPitchValue; 
	[HeaderAttribute] 
	public GameObject muzzleflashCannon; 
	public GameObject muzzleflashCoaxGun; 
	public GameObject muzzleflashSideMG; 
	public GameObject[] muzzleflashRockets; 
	public GameObject spotLightHaloSawnpoint; 
	public GameObject[] muzzleflashSideguns; 
	[HeaderAttribute] 
	public GameObjectRef machineGunMuzzleFlashFX; 
	public GameObjectRef mainCannonFireFX; 
	public GameObjectRef rocketLaunchFX; 
	[HeaderAttribute] 
	public bool rocketsOpen; 
	public Vector3[] vecSideGunRotation; 
	public float treadConstant; 
	public float wheelSpinConstant; 
	[HeaderAttribute] 
	public float sidegunsTurnSpeed; 
	public float turretTurnSpeed; 
	public float cannonPitchSpeed; 
	public float rocketPitchSpeed; 
	public float spotLightTurnSpeed; 
	public float machineGunSpeed; 
	private float wheelAngle; 


private void Start() { }

private void Update() { }

private void AnimateWheelsTreads() { }

private void AdjustShocksHeight() { }

private void TrackTurret() { }

private void TrackSpotLight() { }

private void TrackSideGuns() { }

public void CalculateYawPitchOffset(Transform objectTransform, Vector3 vecStart, Vector3 vecEnd, out float yaw, out float pitch) { }

public float NormalizeYaw(float flYaw) { }

public void .ctor() { }

}

