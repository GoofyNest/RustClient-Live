public class AutoTurret : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6331
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aimPos; // 0x14
	public Vector3 aimDir; // 0x20
	public uint targetID; // 0x2C
	public List<PlayerNameID> users; // 0x30

	// Methods

	// RVA: 0x1FF55C0 Offset: 0x1FF49C0 VA: 0x181FF55C0
	public static void ResetToPool(AutoTurret instance) { }

	// RVA: 0x1FF53D0 Offset: 0x1FF47D0 VA: 0x181FF53D0
	public void ResetToPool() { }

	// RVA: 0x1FF50E0 Offset: 0x1FF44E0 VA: 0x181FF50E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FF3C10 Offset: 0x1FF3010 VA: 0x181FF3C10
	public void CopyTo(AutoTurret instance) { }

	// RVA: 0x1FF3D60 Offset: 0x1FF3160 VA: 0x181FF3D60
	public AutoTurret Copy() { }

	// RVA: 0x1FF4B80 Offset: 0x1FF3F80 VA: 0x181FF4B80
	public static AutoTurret Deserialize(Stream stream) { }

	// RVA: 0x1FF4220 Offset: 0x1FF3620 VA: 0x181FF4220
	public static AutoTurret DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF4590 Offset: 0x1FF3990 VA: 0x181FF4590
	public static AutoTurret DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF4DF0 Offset: 0x1FF41F0 VA: 0x181FF4DF0
	public static AutoTurret Deserialize(byte[] buffer) { }

	// RVA: 0x1FF5160 Offset: 0x1FF4560 VA: 0x181FF5160
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF6250 Offset: 0x1FF5650 VA: 0x181FF6250 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF6270 Offset: 0x1FF5670 VA: 0x181FF6270 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AutoTurret previous) { }

	// RVA: 0x1FF53B0 Offset: 0x1FF47B0 VA: 0x181FF53B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF4870 Offset: 0x1FF3C70 VA: 0x181FF4870
	public static AutoTurret Deserialize(byte[] buffer, AutoTurret instance, bool isDelta = False) { }

	// RVA: 0x1FF4620 Offset: 0x1FF3A20 VA: 0x181FF4620
	public static AutoTurret Deserialize(Stream stream, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FF3F00 Offset: 0x1FF3300 VA: 0x181FF3F00
	public static AutoTurret DeserializeLengthDelimited(Stream stream, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FF42A0 Offset: 0x1FF36A0 VA: 0x181FF42A0
	public static AutoTurret DeserializeLength(Stream stream, int length, AutoTurret instance, bool isDelta) { }

	// RVA: 0x1FF57B0 Offset: 0x1FF4BB0 VA: 0x181FF57B0
	public static void SerializeDelta(Stream stream, AutoTurret instance, AutoTurret previous) { }

	// RVA: 0x1FF5E90 Offset: 0x1FF5290 VA: 0x181FF5E90
	public static void Serialize(Stream stream, AutoTurret instance) { }

	// RVA: 0x1FF6240 Offset: 0x1FF5640 VA: 0x181FF6240
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF6250 Offset: 0x1FF5650 VA: 0x181FF6250
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF5D80 Offset: 0x1FF5180 VA: 0x181FF5D80
	public static byte[] SerializeToBytes(AutoTurret instance) { }

	// RVA: 0x1FF5CD0 Offset: 0x1FF50D0 VA: 0x181FF5CD0
	public static void SerializeLengthDelimited(Stream stream, AutoTurret instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AutoTurret : ContainerIOEntity, IRemoteControllable // TypeDefIndex: 8311
{	// Fields
	private Option __menuOption_Menu_AssignToFriend; // 0x378
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

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }

	// Methods

	// RVA: 0x836E50 Offset: 0x836250 VA: 0x180836E50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x83A110 Offset: 0x839510 VA: 0x18083A110 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x838C90 Offset: 0x838090 VA: 0x180838C90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8394A0 Offset: 0x8388A0 VA: 0x1808394A0 Slot: 164
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x836C00 Offset: 0x836000 VA: 0x180836C00 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void InitializeClientsideEffects() { }

	// RVA: 0x836D30 Offset: 0x836130 VA: 0x180836D30 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x836C10 Offset: 0x836010 VA: 0x180836C10
	public void ClientTick() { }

	// RVA: 0x839AA0 Offset: 0x838EA0 VA: 0x180839AA0
	private void UpdateSounds(bool didTurn) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 165
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x838070 Offset: 0x837470 VA: 0x180838070 Slot: 166
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x836AF0 Offset: 0x835EF0 VA: 0x180836AF0
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x836630 Offset: 0x835A30 VA: 0x180836630
	public void CLIENT_FireGun(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xB2470 Offset: 0xB1870 VA: 0x1800B2470
	[BaseEntity.Menu.Description] // RVA: 0xB2470 Offset: 0xB1870 VA: 0x1800B2470
	[BaseEntity.Menu.Icon] // RVA: 0xB2470 Offset: 0xB1870 VA: 0x1800B2470
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2470 Offset: 0xB1870 VA: 0x1800B2470
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_MaxAuth(BasePlayer player) { }

	// RVA: 0x838990 Offset: 0x837D90 VA: 0x180838990
	public bool MenuMaxAuth_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2880 Offset: 0xB1C80 VA: 0x1800B2880
	[BaseEntity.Menu.Description] // RVA: 0xB2880 Offset: 0xB1C80 VA: 0x1800B2880
	[BaseEntity.Menu.Icon] // RVA: 0xB2880 Offset: 0xB1C80 VA: 0x1800B2880
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2880 Offset: 0xB1C80 VA: 0x1800B2880
	// RVA: 0x8388B0 Offset: 0x837CB0 VA: 0x1808388B0
	public void MenuAuthorize(BasePlayer player) { }

	// RVA: 0x838840 Offset: 0x837C40 VA: 0x180838840
	public bool MenuAuthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	[BaseEntity.Menu.Description] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	[BaseEntity.Menu.Icon] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2C00 Offset: 0xB2000 VA: 0x1800B2C00
	// RVA: 0x838950 Offset: 0x837D50 VA: 0x180838950
	public void MenuDeauthorize(BasePlayer player) { }

	// RVA: 0x8388F0 Offset: 0x837CF0 VA: 0x1808388F0
	public bool MenuDeauthorize_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB2E30 Offset: 0xB2230 VA: 0x1800B2E30
	[BaseEntity.Menu.Description] // RVA: 0xB2E30 Offset: 0xB2230 VA: 0x1800B2E30
	[BaseEntity.Menu.Icon] // RVA: 0xB2E30 Offset: 0xB2230 VA: 0x1800B2E30
	[BaseEntity.Menu.ShowIf] // RVA: 0xB2E30 Offset: 0xB2230 VA: 0x1800B2E30
	// RVA: 0x838910 Offset: 0x837D10 VA: 0x180838910
	public void MenuClearList(BasePlayer player) { }

	// RVA: 0x8388F0 Offset: 0x837CF0 VA: 0x1808388F0
	public bool MenuClearList_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	[BaseEntity.Menu.Description] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	[BaseEntity.Menu.Icon] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3130 Offset: 0xB2530 VA: 0x1800B3130
	// RVA: 0x838AE0 Offset: 0x837EE0 VA: 0x180838AE0
	public void MenuTurretRotate(BasePlayer player) { }

	// RVA: 0x8388F0 Offset: 0x837CF0 VA: 0x1808388F0
	public bool MenuTurretRotate_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB33E0 Offset: 0xB27E0 VA: 0x1800B33E0
	[BaseEntity.Menu.Description] // RVA: 0xB33E0 Offset: 0xB27E0 VA: 0x1800B33E0
	[BaseEntity.Menu.Icon] // RVA: 0xB33E0 Offset: 0xB27E0 VA: 0x1800B33E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB33E0 Offset: 0xB27E0 VA: 0x1800B33E0
	// RVA: 0x838AA0 Offset: 0x837EA0 VA: 0x180838AA0
	public void MenuTurretPeacekeeper(BasePlayer player) { }

	// RVA: 0x838A60 Offset: 0x837E60 VA: 0x180838A60
	public bool MenuTurretPeacekeeper_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB36D0 Offset: 0xB2AD0 VA: 0x1800B36D0
	[BaseEntity.Menu.Description] // RVA: 0xB36D0 Offset: 0xB2AD0 VA: 0x1800B36D0
	[BaseEntity.Menu.Icon] // RVA: 0xB36D0 Offset: 0xB2AD0 VA: 0x1800B36D0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB36D0 Offset: 0xB2AD0 VA: 0x1800B36D0
	// RVA: 0x838A20 Offset: 0x837E20 VA: 0x180838A20
	public void MenuTurretAttackAll(BasePlayer player) { }

	// RVA: 0x8389E0 Offset: 0x837DE0 VA: 0x1808389E0
	public bool MenuTurretAttackAll_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xB3AF0 Offset: 0xB2EF0 VA: 0x1800B3AF0
	[BaseEntity.Menu.Icon] // RVA: 0xB3AF0 Offset: 0xB2EF0 VA: 0x1800B3AF0
	[BaseEntity.Menu.Description] // RVA: 0xB3AF0 Offset: 0xB2EF0 VA: 0x1800B3AF0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB3AF0 Offset: 0xB2EF0 VA: 0x1800B3AF0
	// RVA: 0x838B60 Offset: 0x837F60 VA: 0x180838B60
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0x838B20 Offset: 0x837F20 VA: 0x180838B20 Slot: 176
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	public bool PeacekeeperMode() { }

	// RVA: 0x838520 Offset: 0x837920 VA: 0x180838520
	public bool IsBeingRemoteControlled() { }

	// RVA: 0x836E30 Offset: 0x836230 VA: 0x180836E30 Slot: 167
	public Transform GetEyes() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 169
	public bool Occupied() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 168
	public BaseEntity GetEnt() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 177
	public virtual bool CanControl() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 178
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 172
	public void RCSetup() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 173
	public void RCShutdown() { }

	// RVA: 0x839A90 Offset: 0x838E90 VA: 0x180839A90 Slot: 170
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x836E40 Offset: 0x836240 VA: 0x180836E40 Slot: 171
	public string GetIdentifier() { }

	// RVA: 0x4A2F20 Offset: 0x4A2320 VA: 0x1804A2F20 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x5C9C90 Offset: 0x5C9090 VA: 0x1805C9C90
	public bool IsOnline() { }

	// RVA: 0x6F2BD0 Offset: 0x6F1FD0 VA: 0x1806F2BD0
	public bool IsOffline() { }

	// RVA: 0x839410 Offset: 0x838810 VA: 0x180839410 Slot: 27
	public override void ResetState() { }

	// RVA: 0x836E20 Offset: 0x836220 VA: 0x180836E20 Slot: 179
	public virtual Transform GetCenterMuzzle() { }

	// RVA: 0x836420 Offset: 0x835820 VA: 0x180836420
	public float AngleToTarget(BaseCombatEntity potentialtarget, bool use2D = False) { }

	// RVA: 0x8381A0 Offset: 0x8375A0 VA: 0x1808381A0 Slot: 180
	public virtual bool InFiringArc(BaseCombatEntity potentialtarget) { }

	// RVA: 0x836BB0 Offset: 0x835FB0 VA: 0x180836BB0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x8387A0 Offset: 0x837BA0 VA: 0x1808387A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x839EE0 Offset: 0x8392E0 VA: 0x180839EE0
	public void Update() { }

	// RVA: 0x836190 Offset: 0x835590 VA: 0x180836190
	public Vector3 AimOffset(BaseCombatEntity aimat) { }

	// RVA: 0x836DF0 Offset: 0x8361F0 VA: 0x180836DF0
	public float GetAimSpeed() { }

	// RVA: 0x8395F0 Offset: 0x8389F0 VA: 0x1808395F0
	public void UpdateAiming() { }

	// RVA: 0x838580 Offset: 0x837980 VA: 0x180838580
	private static Quaternion Lerp(Quaternion from, Quaternion to, float speed) { }

	// RVA: 0x838680 Offset: 0x837A80 VA: 0x180838680
	private static Vector3 Lerp(Vector3 from, Vector3 to, float speed) { }

	// RVA: 0x8383B0 Offset: 0x8377B0 VA: 0x1808383B0
	public bool IsAuthed(ulong id) { }

	// RVA: 0x838460 Offset: 0x837860 VA: 0x180838460
	public bool IsAuthed(BasePlayer player) { }

	// RVA: 0x8365E0 Offset: 0x8359E0 VA: 0x1808365E0
	public bool AnyAuthed() { }

	// RVA: 0x836B50 Offset: 0x835F50 VA: 0x180836B50 Slot: 181
	public virtual bool CanChangeSettings(BasePlayer player) { }

	// RVA: 0x83A020 Offset: 0x839420 VA: 0x18083A020
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8394D0 Offset: 0x8388D0 VA: 0x1808394D0
	private bool <Menu_AssignToFriend>b__46_0(ulong id) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x839580 Offset: 0x838980 VA: 0x180839580
	private void <Menu_AssignToFriend>b__46_1(ulong id, string steamName) { }

}

public static class AutoTurret.TurretFlags // TypeDefIndex: 8312
{	// Fields
	public const BaseEntity.Flags Peacekeeper = 128;

}

private sealed class AutoTurret.<>c__DisplayClass106_0 // TypeDefIndex: 8313
{	// Fields
	public ulong id; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x71F0C0 Offset: 0x71E4C0 VA: 0x18071F0C0
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

private sealed class AutoTurret.<>c__DisplayClass107_0 // TypeDefIndex: 8314
{	// Fields
	public BasePlayer player; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x71F090 Offset: 0x71E490 VA: 0x18071F090
	internal bool <IsAuthed>b__0(PlayerNameID x) { }

}

