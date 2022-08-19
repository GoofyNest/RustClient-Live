public class CameraMan : SingletonComponent<CameraMan> // TypeDefIndex: 9139
{	// Fields
	public static string DefaultSaveName; // 0x0
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

	// Properties
	public Color GuideColor { get; set; }
	public int Guide { get; set; }
	private CameraMan.MovementType currentMovementType { get; }
	public float Zoom { get; set; }
	public float Fov { get; set; }
	public static bool Active { get; }

	// Methods

	// RVA: 0x715940 Offset: 0x714D40 VA: 0x180715940
	public Color get_GuideColor() { }

	// RVA: 0x715BC0 Offset: 0x714FC0 VA: 0x180715BC0
	public void set_GuideColor(Color value) { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public int get_Guide() { }

	// RVA: 0x715C30 Offset: 0x715030 VA: 0x180715C30
	public void set_Guide(int value) { }

	// RVA: 0x713FF0 Offset: 0x7133F0 VA: 0x180713FF0
	private void Start() { }

	// RVA: 0x712C50 Offset: 0x712050 VA: 0x180712C50
	private void OnEnable() { }

	// RVA: 0x7128F0 Offset: 0x711CF0 VA: 0x1807128F0
	private void OnDisable() { }

	// RVA: 0x714190 Offset: 0x713590 VA: 0x180714190
	public void TogglePlayerFreeze() { }

	// RVA: 0x712400 Offset: 0x711800 VA: 0x180712400
	private bool IsPlayerUnfrozen() { }

	// RVA: 0x711FC0 Offset: 0x7113C0 VA: 0x180711FC0
	public float FovToZoom(float fov) { }

	// RVA: 0x715600 Offset: 0x714A00 VA: 0x180715600
	public float ZoomToFov(float zoom) { }

	// RVA: 0x713EC0 Offset: 0x7132C0 VA: 0x180713EC0
	public void Save(string name) { }

	// RVA: 0x713CB0 Offset: 0x7130B0 VA: 0x180713CB0
	public void SaveToFile(string name) { }

	// RVA: 0x712030 Offset: 0x711430 VA: 0x180712030
	public CameraMan.CameraState GetCurrentCameraSettings() { }

	// RVA: 0x712750 Offset: 0x711B50 VA: 0x180712750
	public bool Load(string name) { }

	// RVA: 0x7104B0 Offset: 0x70F8B0 VA: 0x1807104B0
	public void ApplyState(CameraMan.CameraState savedState) { }

	// RVA: 0x713280 Offset: 0x712680 VA: 0x180713280
	public string PrintSaved() { }

	// RVA: 0x710780 Offset: 0x70FB80 VA: 0x180710780
	public void Clear() { }

	// RVA: 0x713DD0 Offset: 0x7131D0 VA: 0x180713DD0
	private void SaveToPlayerPrefs() { }

	// RVA: 0x712560 Offset: 0x711960 VA: 0x180712560
	private void LoadFromPlayerPrefs() { }

	// RVA: 0x715960 Offset: 0x714D60 VA: 0x180715960
	private CameraMan.MovementType get_currentMovementType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x715950 Offset: 0x714D50 VA: 0x180715950
	public float get_Zoom() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x715D40 Offset: 0x715140 VA: 0x180715D40
	private void set_Zoom(float value) { }

	// RVA: 0x7158D0 Offset: 0x714CD0 VA: 0x1807158D0
	public float get_Fov() { }

	// RVA: 0x715B40 Offset: 0x714F40 VA: 0x180715B40
	public void set_Fov(float value) { }

	// RVA: 0x715800 Offset: 0x714C00 VA: 0x180715800
	public static bool get_Active() { }

	// RVA: 0x713FC0 Offset: 0x7133C0 VA: 0x180713FC0
	public void ShakeView(float amplitude, float frequency, float duration) { }

	// RVA: 0x7140B0 Offset: 0x7134B0 VA: 0x1807140B0
	public void StopViewShake() { }

	// RVA: 0x7153A0 Offset: 0x7147A0 VA: 0x1807153A0
	private void Update() { }

	// RVA: 0x7140D0 Offset: 0x7134D0 VA: 0x1807140D0
	public void ToggleControl(bool state) { }

	// RVA: 0x714340 Offset: 0x713740 VA: 0x180714340
	private void UpdateMovement() { }

	// RVA: 0x710800 Offset: 0x70FC00 VA: 0x180710800
	private void DoControls() { }

	// RVA: 0x712200 Offset: 0x711600 VA: 0x180712200
	public float GetDofDistance(BaseEntity target) { }

	// RVA: 0x711D80 Offset: 0x711180 VA: 0x180711D80
	public void FocusOnTarget() { }

	// RVA: 0x715710 Offset: 0x714B10 VA: 0x180715710
	public void .ctor() { }

	// RVA: 0x715670 Offset: 0x714A70 VA: 0x180715670
	private static void .cctor() { }

}

public struct CameraMan.CameraState // TypeDefIndex: 9140
{	// Fields
	public Vector3 position; // 0x0
	public Vector3 rotation; // 0xC
	public float zoom; // 0x18
	public float dof; // 0x1C

}

private enum CameraMan.MovementType // TypeDefIndex: 9141
{	// Fields
	public int value__; // 0x0
	public const CameraMan.MovementType Free = 0;
	public const CameraMan.MovementType Target = 1;
	public const CameraMan.MovementType LookAtPlayer = 2;

}

