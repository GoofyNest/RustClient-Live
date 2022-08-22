public class CameraMan : SingletonComponent<CameraMan> // TypeDefIndex: 9139
{	public static string DefaultSaveName; // 0x0
	public const string SavePositionExtension = ".cam";
	public const string SavePositionDirectory = "camsaves";
	public bool OnlyControlWhenCursorHidden; // 0x18
	public bool NeedBothMouseButtonsToZoom; // 0x19
	public float LookSensitivity; // 0x1C
	public float MoveSpeed; // 0x20
	public static float GuideAspect; // 0x8
	public static float GuideRatio; // 0xC
	public Canvas canvas; // 0x28
	public Graphic[] guides; // 0x30
	private Color _guideColor; // 0x38
	private int _guide; // 0x48
	private bool startCulling; // 0x4C
	private static Dictionary<string, CameraMan.CameraState> stateDictionary; // 0x10
	private readonly ViewShake viewShake; // 0x50
	public BaseEntity TargetEntity; // 0x58
	private float targetDistance; // 0x60
	private float targetDistancePrev; // 0x64
	private Vector3 wishMove; // 0x68
	private Vector3 view; // 0x74
	private Vector3 viewPrev; // 0x80
	private Vector3 velocity; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Zoom>k__BackingField; // 0x98

	public Color GuideColor { get; set; }
	public int Guide { get; set; }
	private CameraMan.MovementType currentMovementType { get; }
	public float Zoom { get; set; }
	public float Fov { get; set; }
	public static bool Active { get; }


	public Color get_GuideColor() { }

	public void set_GuideColor(Color value) { }

	public int get_Guide() { }

	public void set_Guide(int value) { }

	private void Start() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void TogglePlayerFreeze() { }

	private bool IsPlayerUnfrozen() { }

	public float FovToZoom(float fov) { }

	public float ZoomToFov(float zoom) { }

	public void Save(string name) { }

	public void SaveToFile(string name) { }

	public CameraMan.CameraState GetCurrentCameraSettings() { }

	public bool Load(string name) { }

	public void ApplyState(CameraMan.CameraState savedState) { }

	public string PrintSaved() { }

	public void Clear() { }

	private void SaveToPlayerPrefs() { }

	private void LoadFromPlayerPrefs() { }

	private CameraMan.MovementType get_currentMovementType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_Zoom() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Zoom(float value) { }

	public float get_Fov() { }

	public void set_Fov(float value) { }

	public static bool get_Active() { }

	public void ShakeView(float amplitude, float frequency, float duration) { }

	public void StopViewShake() { }

	private void Update() { }

	public void ToggleControl(bool state) { }

	private void UpdateMovement() { }

	private void DoControls() { }

	public float GetDofDistance(BaseEntity target) { }

	public void FocusOnTarget() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct CameraMan.CameraState // TypeDefIndex: 9140
{	public Vector3 position; // 0x0
	public Vector3 rotation; // 0xC
	public float zoom; // 0x18
	public float dof; // 0x1C

}

private enum CameraMan.MovementType // TypeDefIndex: 9141
{	public int value__; // 0x0
	public const CameraMan.MovementType Free = 0;
	public const CameraMan.MovementType Target = 1;
	public const CameraMan.MovementType LookAtPlayer = 2;

}

