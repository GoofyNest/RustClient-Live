public class BaseViewModel : MonoBehaviour // TypeDefIndex: 11432
{	public static bool HideViewmodel; // 0x0
	public static BaseViewModel GestureModel; // 0x8
	public static List<BaseViewModel> ActiveModels; // 0x10
	[HeaderAttribute] // RVA: 0xB0530 Offset: 0xAF930 VA: 0x1800B0530
	public LazyAimProperties lazyaimRegular; // 0x18
	public LazyAimProperties lazyaimIronsights; // 0x20
	public Transform pivot; // 0x28
	public bool useViewModelCamera; // 0x30
	public bool wantsHeldItemFlags; // 0x31
	public GameObject[] hideSightMeshes; // 0x38
	public bool isGestureViewModel; // 0x40
	public Transform MuzzlePoint; // 0x48
	[HeaderAttribute] // RVA: 0x7F400 Offset: 0x7E800 VA: 0x18007F400
	public SubsurfaceProfile subsurfaceProfile; // 0x50
	internal Animator animator; // 0x58
	internal AnimationEvents animationEvent; // 0x60
	internal IronSights ironSights; // 0x68
	internal ViewmodelSway sway; // 0x70
	internal ViewmodelLower lower; // 0x78
	internal ViewmodelBob bob; // 0x80
	internal ViewmodelPunch punch; // 0x88
	internal ViewmodelAspectOffset aspectOffset; // 0x90
	internal ViewmodelMountedAnchor mountedAnchor; // 0x98
	internal Model model; // 0xA0
	internal static bool gestureHide; // 0x18
	internal static TimeSince gestureHideTime; // 0x1C
	private static GestureCollection gestureCollection; // 0x20
	private Skeleton Skeleton; // 0xA8
	private GameObject Clothing; // 0xB0
	private bool workshopMode; // 0xB8

	public static BaseViewModel ActiveModel { get; }
	public static bool UsingViewModelCamera { get; }


	public static BaseViewModel get_ActiveModel() { }

	public static bool get_UsingViewModelCamera() { }

	public bool IsOK() { }

	public void PreDestroy() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void Awake() { }

	public void UpdateRenderersAndSkin(BasePlayer forPlayer) { }

	public void OnClothingChanged(BasePlayer player) { }

	private void UpdateRenderers(BasePlayer forPlayer) { }

	private void AddHandsModel() { }

	private void UpdateClothingModels(BasePlayer player) { }

	private void AddClothing(ViewmodelClothing clothing, Item item) { }

	private void SetSkinColor(Color skinColor) { }

	public void OnCameraPositionChanged(Camera cam) { }

	public void OnCameraPositionChanged(Camera cam, BasePlayer player) { }

	public LazyAimProperties GetLazyAim() { }

	private Quaternion GetGestureRotationOffset(out Vector3 offset) { }

	public static void ToggleGestureHide(bool state) { }

	public void TriggerAdmire() { }

	public void TriggerAttack() { }

	public void TriggerAttack2() { }

	public void TriggerReady() { }

	public void TriggerCancel() { }

	public void TriggerDeploy() { }

	public void TriggerReload() { }

	public void TriggerHolster() { }

	public void TriggerEmpty() { }

	public void Trigger(string name) { }

	public void Trigger(int hash) { }

	public void ResetTrigger(string name) { }

	public void ResetTrigger(int hash) { }

	public void SetBool(string name, bool bState) { }

	public void SetBool(int hash, bool bState) { }

	public void SetFloat(string name, float fAmount) { }

	public void SetFloat(int hash, float fAmount) { }

	public void Play(string anim, int layer = 0) { }

	public void CrossFade(string anim, float fade) { }

	public void HideSightMeshes(bool bHide) { }

	public virtual void OnDeployedNoSkin() { }

	public void WorkshopMode() { }

	public void .ctor() { }

	private static void .cctor() { }

}

