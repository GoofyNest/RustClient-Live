public class AutoTurret : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6335
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Vector3 aimPos; 
	public Vector3 aimDir; 
	public uint targetID; 
	public List<PlayerNameID> users; 


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

public class AutoTurret : ContainerIOEntity, IRemoteControllable // TypeDefIndex: 10015
{
	private Option __menuOption_Menu_AssignToFriend; 
	private Option __menuOption_Menu_MaxAuth; 
	private Option __menuOption_MenuAuthorize; 
	private Option __menuOption_MenuClearList; 
	private Option __menuOption_MenuDeauthorize; 
	private Option __menuOption_MenuTurretAttackAll; 
	private Option __menuOption_MenuTurretPeacekeeper; 
	private Option __menuOption_MenuTurretRotate; 
	public GameObjectRef gun_fire_effect; 
	public GameObjectRef bulletEffect; 
	public float bulletSpeed; 
	public AmbienceEmitter ambienceEmitter; 
	public GameObject assignDialog; 
	private SoundModulation.Modulator turnSoundModulator; 
	private Sound turnLoop; 
	private float nextFocusSound; 
	private bool wasTurning; 
	private Quaternion lastYaw; 
	private BasePlayer playerController; 
	private string rcIdentifier; 
	private Vector3 initialAimDir; 
	public float rcTurnSensitivity; 
	public Transform RCEyes; 
	public TargetTrigger targetTrigger; 
	public Transform socketTransform; 
	public BaseCombatEntity target; 
	public Transform eyePos; 
	public Transform muzzlePos; 
	public Vector3 aimDir; 
	public Transform gun_yaw; 
	public Transform gun_pitch; 
	public float sightRange; 
	public SoundDefinition turnLoopDef; 
	public SoundDefinition movementChangeDef; 
	public SoundDefinition ambientLoopDef; 
	public SoundDefinition focusCameraDef; 
	public float focusSoundFreqMin; 
	public float focusSoundFreqMax; 
	public GameObjectRef peacekeeperToggleSound; 
	public GameObjectRef onlineSound; 
	public GameObjectRef offlineSound; 
	public GameObjectRef targetAcquiredEffect; 
	public GameObjectRef targetLostEffect; 
	public GameObjectRef reloadEffect; 
	public float aimCone; 
	public const BaseEntity.Flags Flag_Equipped = 512;
	public const BaseEntity.Flags Flag_MaxAuths = 1024;
	public List<PlayerNameID> authorizedPlayers; 

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

	[BaseEntity.RPC_Client] 
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_MaxAuth(BasePlayer player) { }

	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuAuthorize(BasePlayer player) { }

	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuDeauthorize(BasePlayer player) { }

	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuClearList(BasePlayer player) { }

	public bool MenuClearList_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuTurretRotate(BasePlayer player) { }

	public bool MenuTurretRotate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuTurretPeacekeeper(BasePlayer player) { }

	public bool MenuTurretPeacekeeper_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void MenuTurretAttackAll(BasePlayer player) { }

	public bool MenuTurretAttackAll_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
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

	[CompilerGeneratedAttribute] 
	private bool <Menu_AssignToFriend>b__44_0(ulong id) { }

	[CompilerGeneratedAttribute] 
	private void <Menu_AssignToFriend>b__44_1(ulong id, string steamName) { }

}

public static class AutoTurret.TurretFlags // TypeDefIndex: 10016
{
	public const BaseEntity.Flags Peacekeeper = 128;

}

private sealed class AutoTurret.<>c__DisplayClass104_0 // TypeDefIndex: 10017
{
	public ulong id; 


	public void .ctor() { }

	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class AutoTurret.<>c__DisplayClass105_0 // TypeDefIndex: 10018
{
	public BasePlayer player; 


	public void .ctor() { }

	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

