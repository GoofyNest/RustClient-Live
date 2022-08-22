public class AutoTurret : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6331
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aimPos; // 0x14
	public Vector3 aimDir; // 0x20
	public uint targetID; // 0x2C
	public List<PlayerNameID> users; // 0x30


	public static void ResetToPool(AutoTurret instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AutoTurret instance) { }

	public AutoTurret Copy() { }

	public static AutoTurret Deserialize(Stream stream) { }

	public static AutoTurret DeserializeLengthDelimited(Stream stream) { }

	public static AutoTurret DeserializeLength(Stream stream, int length) { }

	public static AutoTurret Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AutoTurret previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AutoTurret Deserialize(byte[] buffer, AutoTurret instance, bool isDelta = False) { }

	public static AutoTurret Deserialize(Stream stream, AutoTurret instance, bool isDelta) { }

	public static AutoTurret DeserializeLengthDelimited(Stream stream, AutoTurret instance, bool isDelta) { }

	public static AutoTurret DeserializeLength(Stream stream, int length, AutoTurret instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AutoTurret instance, AutoTurret previous) { }

	public static void Serialize(Stream stream, AutoTurret instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AutoTurret instance) { }

	public static void SerializeLengthDelimited(Stream stream, AutoTurret instance) { }

	public void .ctor() { }

}

public class AutoTurret : ContainerIOEntity, IRemoteControllable // TypeDefIndex: 8311
{	private Option __menuOption_Menu_AssignToFriend; // 0x378
	private Option __menuOption_Menu_MaxAuth; // 0x3D0
	private Option __menuOption_MenuAuthorize; // 0x428
	private Option __menuOption_MenuClearList; // 0x480
	private Option __menuOption_MenuDeauthorize; // 0x4D8
	private Option __menuOption_MenuTurretAttackAll; // 0x530
	private Option __menuOption_MenuTurretPeacekeeper; // 0x588
	private Option __menuOption_MenuTurretRotate; // 0x5E0
	public GameObjectRef gun_fire_effect; // 0x638
	public GameObjectRef bulletEffect; // 0x640
	public float bulletSpeed; // 0x648
	public AmbienceEmitter ambienceEmitter; // 0x650
	public GameObject assignDialog; // 0x658
	private SoundModulation.Modulator turnSoundModulator; // 0x660
	private Sound turnLoop; // 0x668
	private float nextFocusSound; // 0x670
	private bool wasTurning; // 0x674
	private Quaternion lastYaw; // 0x678
	private BasePlayer playerController; // 0x688
	private string rcIdentifier; // 0x690
	private Vector3 initialAimDir; // 0x698
	public float rcTurnSensitivity; // 0x6A4
	public Transform RCEyes; // 0x6A8
	public TargetTrigger targetTrigger; // 0x6B0
	public Transform socketTransform; // 0x6B8
	public BaseCombatEntity target; // 0x6C0
	public Transform eyePos; // 0x6C8
	public Transform muzzlePos; // 0x6D0
	public Vector3 aimDir; // 0x6D8
	public Transform gun_yaw; // 0x6E8
	public Transform gun_pitch; // 0x6F0
	public float sightRange; // 0x6F8
	public SoundDefinition turnLoopDef; // 0x700
	public SoundDefinition movementChangeDef; // 0x708
	public SoundDefinition ambientLoopDef; // 0x710
	public SoundDefinition focusCameraDef; // 0x718
	public float focusSoundFreqMin; // 0x720
	public float focusSoundFreqMax; // 0x724
	public GameObjectRef peacekeeperToggleSound; // 0x728
	public GameObjectRef onlineSound; // 0x730
	public GameObjectRef offlineSound; // 0x738
	public GameObjectRef targetAcquiredEffect; // 0x740
	public GameObjectRef targetLostEffect; // 0x748
	public GameObjectRef reloadEffect; // 0x750
	public float aimCone; // 0x758
	public const BaseEntity.Flags Flag_Equipped = 512;
	public const BaseEntity.Flags Flag_MaxAuths = 1024;
	public List<PlayerNameID> authorizedPlayers; // 0x760

	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool ShouldShowLootMenus() { }

	protected override void ClientInit(Entity info) { }

	public void InitializeClientsideEffects() { }

	protected override void DoClientDestroy() { }

	public void ClientTick() { }

	private void UpdateSounds(bool didTurn) { }

	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xB2470 Offset: 0xB1870 VA: 0x1800B2470
	[BaseEntity.Menu.Description] // RVA: 0xB2470 Offset: 0xB1870 VA: 0x1800B2470
	[BaseEntity.Menu.Icon] // RVA: 0xB2470 Offset: 0xB1870 VA: 0x1800B2470
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2470 Offset: 0xB1870 VA: 0x1800B2470
	public void Menu_MaxAuth(BasePlayer player) { }

	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2880 Offset: 0xB1C80 VA: 0x1800B2880
	[BaseEntity.Menu.Description] // RVA: 0xB2880 Offset: 0xB1C80 VA: 0x1800B2880
	[BaseEntity.Menu.Icon] // RVA: 0xB2880 Offset: 0xB1C80 VA: 0x1800B2880
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2880 Offset: 0xB1C80 VA: 0x1800B2880
	public void MenuAuthorize(BasePlayer player) { }

	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	[BaseEntity.Menu.Description] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	[BaseEntity.Menu.Icon] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	public void MenuDeauthorize(BasePlayer player) { }

	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2E30 Offset: 0xB2230 VA: 0x1800B2E30
	[BaseEntity.Menu.Description] // RVA: 0xB2E30 Offset: 0xB2230 VA: 0x1800B2E30
	[BaseEntity.Menu.Icon] // RVA: 0xB2E30 Offset: 0xB2230 VA: 0x1800B2E30
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2E30 Offset: 0xB2230 VA: 0x1800B2E30
	public void MenuClearList(BasePlayer player) { }

	public bool MenuClearList_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	[BaseEntity.Menu.Description] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	[BaseEntity.Menu.Icon] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	public void MenuTurretRotate(BasePlayer player) { }

	public bool MenuTurretRotate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB33E0 Offset: 0xB27E0 VA: 0x1800B33E0
	[BaseEntity.Menu.Description] // RVA: 0xB33E0 Offset: 0xB27E0 VA: 0x1800B33E0
	[BaseEntity.Menu.Icon] // RVA: 0xB33E0 Offset: 0xB27E0 VA: 0x1800B33E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB33E0 Offset: 0xB27E0 VA: 0x1800B33E0
	public void MenuTurretPeacekeeper(BasePlayer player) { }

	public bool MenuTurretPeacekeeper_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB36D0 Offset: 0xB2AD0 VA: 0x1800B36D0
	[BaseEntity.Menu.Description] // RVA: 0xB36D0 Offset: 0xB2AD0 VA: 0x1800B36D0
	[BaseEntity.Menu.Icon] // RVA: 0xB36D0 Offset: 0xB2AD0 VA: 0x1800B36D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB36D0 Offset: 0xB2AD0 VA: 0x1800B36D0
	public void MenuTurretAttackAll(BasePlayer player) { }

	public bool MenuTurretAttackAll_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3AF0 Offset: 0xB2EF0 VA: 0x1800B3AF0
	[BaseEntity.Menu.Icon] // RVA: 0xB3AF0 Offset: 0xB2EF0 VA: 0x1800B3AF0
	[BaseEntity.Menu.Description] // RVA: 0xB3AF0 Offset: 0xB2EF0 VA: 0x1800B3AF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3AF0 Offset: 0xB2EF0 VA: 0x1800B3AF0
	public void Menu_AssignToFriend(BasePlayer player) { }

	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	public bool PeacekeeperMode() { }

	public bool IsBeingRemoteControlled() { }

	public Transform GetEyes() { }

	public bool Occupied() { }

	public BaseEntity GetEnt() { }

	public virtual bool CanControl() { }

	public virtual bool get_RequiresMouse() { }

	public void RCSetup() { }

	public void RCShutdown() { }

	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	public string GetIdentifier() { }

	public override int ConsumptionAmount() { }

	public bool IsOnline() { }

	public bool IsOffline() { }

	public override void ResetState() { }

	public virtual Transform GetCenterMuzzle() { }

	public float AngleToTarget(BaseCombatEntity potentialtarget, bool use2D = False) { }

	public virtual bool InFiringArc(BaseCombatEntity potentialtarget) { }

	public override bool CanPickup(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void Update() { }

	public Vector3 AimOffset(BaseCombatEntity aimat) { }

	public float GetAimSpeed() { }

	public void UpdateAiming() { }

	private static Quaternion Lerp(Quaternion from, Quaternion to, float speed) { }

	private static Vector3 Lerp(Vector3 from, Vector3 to, float speed) { }

	public bool IsAuthed(ulong id) { }

	public bool IsAuthed(BasePlayer player) { }

	public bool AnyAuthed() { }

	public virtual bool CanChangeSettings(BasePlayer player) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Menu_AssignToFriend>b__46_0(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Menu_AssignToFriend>b__46_1(ulong id, string steamName) { }

}

public static class AutoTurret.TurretFlags // TypeDefIndex: 8312
{	public const BaseEntity.Flags Peacekeeper = 128;

}

private sealed class AutoTurret.<>c__DisplayClass106_0 // TypeDefIndex: 8313
{	public ulong id; // 0x10


	public void .ctor() { }

	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class AutoTurret.<>c__DisplayClass107_0 // TypeDefIndex: 8314
{	public BasePlayer player; // 0x10


	public void .ctor() { }

	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

