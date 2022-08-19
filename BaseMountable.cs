public class BaseMountable : BaseCombatEntity // TypeDefIndex: 8330
{	// Fields
	private Option __menuOption_Menu_Mount; // 0x240
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

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual bool DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes { get; }
	public virtual float FirstPersonWithArmsEyesLerp { get; }
	public virtual bool IsSummerDlcVehicle { get; }
	public virtual bool BlocksDoors { get; }

	// Methods

	// RVA: 0xA29750 Offset: 0xA28B50 VA: 0x180A29750 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA2B820 Offset: 0xA2AC20 VA: 0x180A2B820 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA2A540 Offset: 0xA29940 VA: 0x180A2A540 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA28B50 Offset: 0xA27F50 VA: 0x180A28B50 Slot: 145
	public virtual bool CanHoldItems() { }

	// RVA: 0xA29AB0 Offset: 0xA28EB0 VA: 0x180A29AB0 Slot: 146
	public virtual BasePlayer.CameraMode GetMountedCameraMode() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 147
	public virtual bool DirectlyMountable() { }

	// RVA: 0xA296C0 Offset: 0xA28AC0 VA: 0x180A296C0 Slot: 148
	public virtual Transform GetEyeOverride() { }

	// RVA: 0xA29A60 Offset: 0xA28E60 VA: 0x180A29A60 Slot: 149
	public virtual Quaternion GetMountedBodyAngles() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 150
	public virtual bool ModifiesThirdPersonCamera() { }

	// RVA: 0x6D1070 Offset: 0x6D0470 VA: 0x1806D1070 Slot: 151
	public virtual Vector2 GetPitchClamp() { }

	// RVA: 0x6D1090 Offset: 0x6D0490 VA: 0x1806D1090 Slot: 152
	public virtual Vector2 GetYawClamp() { }

	// RVA: 0xA29D10 Offset: 0xA29110 VA: 0x180A29D10 Slot: 153
	public virtual bool IsMounted() { }

	// RVA: 0xA29350 Offset: 0xA28750 VA: 0x180A29350 Slot: 154
	public virtual Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0xA29250 Offset: 0xA28650 VA: 0x180A29250 Slot: 155
	public virtual Vector3 EyeCenterForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0xA2B650 Offset: 0xA2AA50 VA: 0x180A2B650 Slot: 156
	public virtual float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0xA29E50 Offset: 0xA29250 VA: 0x180A29E50 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0xA2AB40 Offset: 0xA29F40 VA: 0x180A2AB40 Slot: 157
	public virtual bool PlayerIsMounted(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 158
	public virtual void OnClientInput(BasePlayer player) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 159
	public virtual bool ForceUpdatePlayerModel(BasePlayer p) { }

	// RVA: 0xA2B080 Offset: 0xA2A480 VA: 0x180A2B080
	internal void UpdatePlayerModel(PlayerModel playerModel) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 160
	protected virtual void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 161
	protected virtual bool SuppressHandsAnimationLayer() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 162
	protected virtual AnimatorOverrideController GetAnimationOverride() { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 163
	protected virtual float GetSpineLookAtWeight() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 164
	public virtual float GetMountedAnimationSpeed() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 165
	public virtual bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	// RVA: 0x72D8F0 Offset: 0x72CCF0 VA: 0x18072D8F0 Slot: 166
	public virtual float get_FirstPersonWithArmsEyesLerp() { }

	// RVA: 0xA2A010 Offset: 0xA29410 VA: 0x180A2A010 Slot: 167
	public virtual Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset) { }

	// RVA: 0xA29DE0 Offset: 0xA291E0 VA: 0x180A29DE0 Slot: 168
	public virtual bool LockThirdPersonOffset(out Vector3 offset) { }

	// RVA: 0xA29D20 Offset: 0xA29120 VA: 0x180A29D20 Slot: 169
	public virtual bool LocalPlayerIsMounted() { }

	// RVA: 0xA2B5C0 Offset: 0xA2A9C0 VA: 0x180A2B5C0 Slot: 170
	public virtual BaseVehicle VehicleParent() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 171
	public virtual bool get_IsSummerDlcVehicle() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 172
	public virtual bool IsInstrument() { }

	// RVA: 0xA2B140 Offset: 0xA2A540 VA: 0x180A2B140 Slot: 173
	public virtual void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA2B510 Offset: 0xA2A910 VA: 0x180A2B510 Slot: 174
	public virtual void UpdatePlayerRotation(BasePlayer player) { }

	// RVA: 0xA2B050 Offset: 0xA2A450 VA: 0x180A2B050 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0xA2B3A0 Offset: 0xA2A7A0 VA: 0x180A2B3A0
	public void UpdatePlayerPosition(BasePlayer player) { }

	// RVA: 0xA29B80 Offset: 0xA28F80 VA: 0x180A29B80 Slot: 175
	public virtual Quaternion GetMountedRotation() { }

	// RVA: 0xA29AC0 Offset: 0xA28EC0 VA: 0x180A29AC0
	public Vector3 GetMountedPosition() { }

	// RVA: 0xA2AC20 Offset: 0xA2A020 VA: 0x180A2AC20 Slot: 176
	public virtual void PlayerMounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0xA2A660 Offset: 0xA29A60 VA: 0x180A2A660 Slot: 177
	public virtual void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0xA28B60 Offset: 0xA27F60 VA: 0x180A28B60 Slot: 178
	protected virtual void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xA28C00 Offset: 0xA28000 VA: 0x180A28C00 Slot: 179
	protected virtual void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xA2A630 Offset: 0xA29A30 VA: 0x180A2A630 Slot: 180
	public virtual void OverrideViewAngles(BasePlayer player) { }

	// RVA: 0xA28DE0 Offset: 0xA281E0 VA: 0x180A28DE0 Slot: 181
	public virtual void DoPlayerMovement(BasePlayer player, InputState input, ModelState modelState) { }

	// RVA: 0xA29C90 Offset: 0xA29090 VA: 0x180A29C90 Slot: 182
	protected virtual bool HoldToDismount() { }

	// RVA: 0xA28CD0 Offset: 0xA280D0 VA: 0x180A28CD0
	public void ClientRequestDismount() { }

	[BaseEntity.Menu] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.Description] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.Icon] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A8C0 Offset: 0x79CC0 VA: 0x18007A8C0
	// RVA: 0xA29FA0 Offset: 0xA293A0 VA: 0x180A29FA0
	public void Menu_Mount(BasePlayer player) { }

	// RVA: 0xA29F00 Offset: 0xA29300 VA: 0x180A29F00 Slot: 183
	public virtual bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0xA2A030 Offset: 0xA29430 VA: 0x180A2A030 Slot: 184
	public virtual bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xA2A0C0 Offset: 0xA294C0 VA: 0x180A2A0C0
	public bool NearMountPoint(BasePlayer player) { }

	// RVA: 0xA28D10 Offset: 0xA28110 VA: 0x180A28D10
	public static Vector3 ConvertVector(Vector3 vec) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 185
	public virtual bool get_BlocksDoors() { }

	// RVA: 0xA2B770 Offset: 0xA2AB70 VA: 0x180A2B770
	public void .ctor() { }

	// RVA: 0xA2B700 Offset: 0xA2AB00 VA: 0x180A2B700
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA28CD0 Offset: 0xA280D0 VA: 0x180A28CD0
	private void <DoPlayerMovement>b__78_0(BasePlayer basePlayer) { }

}

public enum BaseMountable.MountStatType // TypeDefIndex: 8331
{	// Fields
	public int value__; // 0x0
	public const BaseMountable.MountStatType None = 0;
	public const BaseMountable.MountStatType Boating = 1;
	public const BaseMountable.MountStatType Flying = 2;
	public const BaseMountable.MountStatType Driving = 3;

}

public enum BaseMountable.MountGestureType // TypeDefIndex: 8332
{	// Fields
	public int value__; // 0x0
	public const BaseMountable.MountGestureType None = 0;
	public const BaseMountable.MountGestureType UpperBody = 1;

}

