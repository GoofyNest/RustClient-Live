public class BaseViewModel : MonoBehaviour // TypeDefIndex: 13224
{
	public static bool HideViewmodel; 
	public static BaseViewModel GestureModel; 
	public static List<BaseViewModel> ActiveModels; 
	[HeaderAttribute] 
	public LazyAimProperties lazyaimRegular; 
	public LazyAimProperties lazyaimIronsights; 
	public Transform pivot; 
	public bool useViewModelCamera; 
	public bool wantsHeldItemFlags; 
	public GameObject[] hideSightMeshes; 
	public bool isGestureViewModel; 
	public Transform MuzzlePoint; 
	[HeaderAttribute] 
	public SubsurfaceProfile subsurfaceProfile; 
	internal Animator animator; 
	internal AnimationEvents animationEvent; 
	internal IronSights ironSights; 
	internal ViewmodelSway sway; 
	internal ViewmodelLower lower; 
	internal ViewmodelBob bob; 
	internal ViewmodelPunch punch; 
	internal ViewmodelAspectOffset aspectOffset; 
	internal ViewmodelMountedAnchor mountedAnchor; 
	internal Model model; 
	internal static bool gestureHide; 
	internal static TimeSince gestureHideTime; 
	private static GestureCollection gestureCollection; 
	private Skeleton Skeleton; 
	private GameObject Clothing; 
	private bool workshopMode; 

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

