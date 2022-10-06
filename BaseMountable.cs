public class BaseMountable : BaseCombatEntity // TypeDefIndex: 10034
{
	private Option __menuOption_Menu_Mount; 
	public static Translate.Phrase dismountPhrase; 
	[HeaderAttribute] 
	[FormerlySerializedAsAttribute] 
	public Transform eyePositionOverride; 
	[FormerlySerializedAsAttribute] 
	public Transform eyeCenterOverride; 
	public Vector2 pitchClamp; 
	public Vector2 yawClamp; 
	public bool canWieldItems; 
	public bool relativeViewAngles; 
	[HeaderAttribute] 
	public Transform mountAnchor; 
	public PlayerModel.MountPoses mountPose; 
	public float maxMountDistance; 
	public Transform[] dismountPositions; 
	public bool checkPlayerLosOnMount; 
	public bool disableMeshCullingForPlayers; 
	public bool allowHeadLook; 
	[FormerlySerializedAsAttribute] 
	public bool modifiesPlayerCollider; 
	public BasePlayer.CapsuleColliderInfo customPlayerCollider; 
	public SoundDefinition mountSoundDef; 
	public SoundDefinition swapSoundDef; 
	public SoundDefinition dismountSoundDef; 
	public BaseMountable.MountStatType mountTimeStatType; 
	public BaseMountable.MountGestureType allowedGestures; 
	public bool canDrinkWhileMounted; 
	public bool allowSleeperMounting; 
	[HelpAttribute] 
	public bool animateClothInLocalSpace; 
	[HeaderAttribute] 
	public BasePlayer.CameraMode MountedCameraMode; 
	[FormerlySerializedAsAttribute] 
	public bool isMobile; 
	public float SideLeanAmount; 

	public override bool HasMenuOptions { get; }
	public virtual bool DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes { get; }
	public virtual float FirstPersonWithArmsEyesLerp { get; }
	public virtual bool IsSummerDlcVehicle { get; }
	public virtual bool BlocksDoors { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public virtual bool CanHoldItems() { }

	public virtual BasePlayer.CameraMode GetMountedCameraMode() { }

	public virtual bool DirectlyMountable() { }

	public virtual Transform GetEyeOverride() { }

	public virtual Quaternion GetMountedBodyAngles() { }

	public virtual bool ModifiesThirdPersonCamera() { }

	public virtual Vector2 GetPitchClamp() { }

	public virtual Vector2 GetYawClamp() { }

	public virtual bool IsMounted() { }

	public virtual Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	public virtual Vector3 EyeCenterForPlayer(BasePlayer player, Quaternion lookRot) { }

	public virtual float WaterFactorForPlayer(BasePlayer player) { }

	public override float MaxVelocity() { }

	public virtual bool PlayerIsMounted(BasePlayer player) { }

	public virtual void OnClientInput(BasePlayer player) { }

	public virtual bool ForceUpdatePlayerModel(BasePlayer p) { }

	internal void UpdatePlayerModel(PlayerModel playerModel) { }

	protected virtual void ProcessPlayerModel(PlayerModel playerModel) { }

	protected virtual bool SuppressHandsAnimationLayer() { }

	protected virtual AnimatorOverrideController GetAnimationOverride() { }

	protected virtual float GetSpineLookAtWeight() { }

	public virtual float GetMountedAnimationSpeed() { }

	public virtual bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	public virtual float get_FirstPersonWithArmsEyesLerp() { }

	public virtual Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset) { }

	public virtual bool LockThirdPersonOffset(out Vector3 offset) { }

	public virtual bool LocalPlayerIsMounted() { }

	public virtual BaseVehicle VehicleParent() { }

	public virtual bool get_IsSummerDlcVehicle() { }

	public virtual bool IsInstrument() { }

	public virtual void UpdatePlayerModel(BasePlayer player) { }

	public virtual void UpdatePlayerRotation(BasePlayer player) { }

	public override void SetNetworkPosition(Vector3 vPos) { }

	public void UpdatePlayerPosition(BasePlayer player) { }

	public virtual Quaternion GetMountedRotation() { }

	public Vector3 GetMountedPosition() { }

	public virtual void PlayerMounted(BasePlayer player, bool wasSwap) { }

	public virtual void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	protected virtual void ClientOnPlayerDismounted(BasePlayer player) { }

	protected virtual void ClientOnPlayerMounted(BasePlayer player) { }

	public virtual void OverrideViewAngles(BasePlayer player) { }

	public virtual void DoPlayerMovement(BasePlayer player, InputState input, ModelState modelState) { }

	protected virtual bool HoldToDismount() { }

	public void ClientRequestDismount() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Mount(BasePlayer player) { }

	public virtual bool Menu_Mount_ShowIf(BasePlayer player) { }

	public virtual bool MountMenuVisible(BasePlayer player) { }

	public bool NearMountPoint(BasePlayer player) { }

	public static Vector3 ConvertVector(Vector3 vec) { }

	public virtual bool get_BlocksDoors() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	private void <DoPlayerMovement>b__78_0(BasePlayer basePlayer) { }

}

public enum BaseMountable.MountStatType // TypeDefIndex: 10035
{
	public int value__; 
	public const BaseMountable.MountStatType None = 0;
	public const BaseMountable.MountStatType Boating = 1;
	public const BaseMountable.MountStatType Flying = 2;
	public const BaseMountable.MountStatType Driving = 3;

}

public enum BaseMountable.MountGestureType // TypeDefIndex: 10036
{
	public int value__; 
	public const BaseMountable.MountGestureType None = 0;
	public const BaseMountable.MountGestureType UpperBody = 1;

}

