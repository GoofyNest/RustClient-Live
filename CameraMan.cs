public class CameraMan : SingletonComponent<CameraMan> // TypeDefIndex: 10856
{
	public static string DefaultSaveName; 
	public const string SavePositionExtension = ".cam";
	public const string SavePositionDirectory = "camsaves";
	public bool OnlyControlWhenCursorHidden; 
	public bool NeedBothMouseButtonsToZoom; 
	public float LookSensitivity; 
	public float MoveSpeed; 
	public static float GuideAspect; 
	public static float GuideRatio; 
	public Canvas canvas; 
	public Graphic[] guides; 
	private Color _guideColor; 
	private int _guide; 
	private bool startCulling; 
	private static Dictionary<string, CameraMan.CameraState> stateDictionary; 
	private readonly ViewShake viewShake; 
	public BaseEntity TargetEntity; 
	private float targetDistance; 
	private float targetDistancePrev; 
	private Vector3 wishMove; 
	private Vector3 view; 
	private Vector3 viewPrev; 
	private Vector3 velocity; 
	[CompilerGeneratedAttribute] 
	private float <Zoom>k__BackingField; 

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

	[CompilerGeneratedAttribute] 
	public float get_Zoom() { }

	[CompilerGeneratedAttribute] 
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

public struct CameraMan.CameraState // TypeDefIndex: 10857
{
	public Vector3 position; 
	public Vector3 rotation; 
	public float zoom; 
	public float dof; 

}

private enum CameraMan.MovementType // TypeDefIndex: 10858
{
	public int value__; 
	public const CameraMan.MovementType Free = 0;
	public const CameraMan.MovementType Target = 1;
	public const CameraMan.MovementType LookAtPlayer = 2;

}

