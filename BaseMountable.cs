public class BaseMountable : BaseCombatEntity // TypeDefIndex: 8330
{	private Option __menuOption_Menu_Mount; // 0x240
	public static Translate.Phrase dismountPhrase; // 0x0
	[HeaderAttribute] // RVA: 0xB9130 Offset: 0xB8530 VA: 0x1800B9130
	[FormerlySerializedAsAttribute] // RVA: 0xB9130 Offset: 0xB8530 VA: 0x1800B9130
	public Transform eyePositionOverride; // 0x298
	[FormerlySerializedAsAttribute] // RVA: 0xB94F0 Offset: 0xB88F0 VA: 0x1800B94F0
	public Transform eyeCenterOverride; // 0x2A0
	public Vector2 pitchClamp; // 0x2A8
	public Vector2 yawClamp; // 0x2B0
	public bool canWieldItems; // 0x2B8
	public bool relativeViewAngles; // 0x2B9
	[HeaderAttribute] // RVA: 0xB9610 Offset: 0xB8A10 VA: 0x1800B9610
	public Transform mountAnchor; // 0x2C0
	public PlayerModel.MountPoses mountPose; // 0x2C8
	public float maxMountDistance; // 0x2CC
	public Transform[] dismountPositions; // 0x2D0
	public bool checkPlayerLosOnMount; // 0x2D8
	public bool disableMeshCullingForPlayers; // 0x2D9
	public bool allowHeadLook; // 0x2DA
	[FormerlySerializedAsAttribute] // RVA: 0xB96D0 Offset: 0xB8AD0 VA: 0x1800B96D0
	public bool modifiesPlayerCollider; // 0x2DB
	public BasePlayer.CapsuleColliderInfo customPlayerCollider; // 0x2DC
	public SoundDefinition mountSoundDef; // 0x2F0
	public SoundDefinition swapSoundDef; // 0x2F8
	public SoundDefinition dismountSoundDef; // 0x300
	public BaseMountable.MountStatType mountTimeStatType; // 0x308
	public BaseMountable.MountGestureType allowedGestures; // 0x30C
	public bool canDrinkWhileMounted; // 0x310
	public bool allowSleeperMounting; // 0x311
	[HelpAttribute] // RVA: 0xB9840 Offset: 0xB8C40 VA: 0x1800B9840
	public bool animateClothInLocalSpace; // 0x312
	[HeaderAttribute] // RVA: 0xABC70 Offset: 0xAB070 VA: 0x1800ABC70
	public BasePlayer.CameraMode MountedCameraMode; // 0x314
	[FormerlySerializedAsAttribute] // RVA: 0xB9A50 Offset: 0xB8E50 VA: 0x1800B9A50
	public bool isMobile; // 0x318
	public float SideLeanAmount; // 0x31C

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

	[BaseEntity.Menu] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.Description] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.Icon] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	public void Menu_Mount(BasePlayer player) { }

	public virtual bool Menu_Mount_ShowIf(BasePlayer player) { }

	public virtual bool MountMenuVisible(BasePlayer player) { }

	public bool NearMountPoint(BasePlayer player) { }

	public static Vector3 ConvertVector(Vector3 vec) { }

	public virtual bool get_BlocksDoors() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <DoPlayerMovement>b__78_0(BasePlayer basePlayer) { }

}

public enum BaseMountable.MountStatType // TypeDefIndex: 8331
{	public int value__; // 0x0
	public const BaseMountable.MountStatType None = 0;
	public const BaseMountable.MountStatType Boating = 1;
	public const BaseMountable.MountStatType Flying = 2;
	public const BaseMountable.MountStatType Driving = 3;

}

public enum BaseMountable.MountGestureType // TypeDefIndex: 8332
{	public int value__; // 0x0
	public const BaseMountable.MountGestureType None = 0;
	public const BaseMountable.MountGestureType UpperBody = 1;

}

