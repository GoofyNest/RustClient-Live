public class SprayCan : HeldEntity // TypeDefIndex: 8641
{	// Fields
	public const float MaxFreeSprayDistanceFromStart = 10;
	public const float MaxFreeSprayStartingDistance = 3;
	private SprayCanSpray_Freehand paintingLine; // 0x1F8
	public const BaseEntity.Flags IsFreeSpraying = 128;
	private bool isSpraying; // 0x200
	private bool spawnedLine; // 0x201
	private Vector3 sprayStartPos; // 0x204
	private Vector3 lastPos; // 0x210
	private int colourIndex; // 0x21C
	private int widthIndex; // 0x220
	private BaseEntity sprayingEntity; // 0x228
	private List<AlignedLineDrawer.LinePoint> points; // 0x230
	private TimeSince sprayStarted; // 0x238
	private TimeSince sprayEnded; // 0x23C
	private static Translate.Phrase[] ColourNamePhrases; // 0x0
	private static Translate.Phrase[] ColourDescriptionPhrases; // 0x8
	private static Translate.Phrase[] SpraySizePhrases; // 0x10
	public SoundDefinition SpraySound; // 0x240
	public GameObjectRef SkinSelectPanel; // 0x248
	public float SprayCooldown; // 0x250
	public float ConditionLossPerSpray; // 0x254
	public float ConditionLossPerReskin; // 0x258
	public GameObjectRef LinePrefab; // 0x260
	public Color[] SprayColours; // 0x268
	public float[] SprayWidths; // 0x270
	public ParticleSystem worldSpaceSprayFx; // 0x278
	public GameObjectRef ReskinEffect; // 0x280
	public ItemDefinition SprayDecalItem; // 0x288
	public GameObjectRef SprayDecalEntityRef; // 0x290
	public SteamInventoryItem FreeSprayUnlockItem; // 0x298
	public ParticleSystem.MinMaxGradient DecalSprayGradient; // 0x2A0
	public SoundDefinition SprayLoopDef; // 0x2D8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SprayCan.SprayMode <currentMode>k__BackingField; // 0x2E0
	private int selectedDecalSkin; // 0x2E4
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool UseAccurateMeshSnapping; // 0x18
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool DebugMeshSnapping; // 0x19
	private static int paramAttack; // 0x1C
	private static int paramAttackHold; // 0x20
	private TimeSince timeDeployed; // 0x2E8
	private Sound sprayLoop; // 0x2F0

	// Properties
	private Color SelectedSprayColour { get; }
	public static bool HasOpenedColourWheel { get; set; }
	public static bool HasOpenedSizeWheel { get; set; }
	public SprayCan.SprayMode currentMode { get; set; }

	// Methods

	// RVA: 0xA83180 Offset: 0xA82580 VA: 0x180A83180 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA854C0 Offset: 0xA848C0 VA: 0x180A854C0
	private Color get_SelectedSprayColour() { }

	// RVA: 0xA80150 Offset: 0xA7F550 VA: 0x180A80150
	private void FreePaintInput(BasePlayer player, bool sprayInput) { }

	// RVA: 0xA82250 Offset: 0xA81650 VA: 0x180A82250
	private bool HasSprayDecalAttachment(BasePlayer player) { }

	// RVA: 0xA84380 Offset: 0xA83780 VA: 0x180A84380
	private Ray SprayRay(BasePlayer player) { }

	// RVA: 0xA81A00 Offset: 0xA80E00 VA: 0x180A81A00
	private bool GetSprayPosition(BasePlayer player, out Vector3 pos, out Vector3 normal, out Vector3 upPos, out BaseEntity hitEntity, out Collider hitCollider) { }

	// RVA: 0xA84130 Offset: 0xA83530 VA: 0x180A84130
	public void RegisterInProcessSpray(SprayCanSpray_Freehand spray, List<AlignedLineDrawer.LinePoint> setPoints) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA7FBE0 Offset: 0xA7EFE0 VA: 0x180A7FBE0
	private void Client_ChangeSprayColour(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA85440 Offset: 0xA84840 VA: 0x180A85440
	public static bool get_HasOpenedColourWheel() { }

	// RVA: 0xA85510 Offset: 0xA84910 VA: 0x180A85510
	private static void set_HasOpenedColourWheel(bool value) { }

	// RVA: 0xA85480 Offset: 0xA84880 VA: 0x180A85480
	public static bool get_HasOpenedSizeWheel() { }

	// RVA: 0xA85550 Offset: 0xA84950 VA: 0x180A85550
	private static void set_HasOpenedSizeWheel(bool value) { }

	// RVA: 0xA84320 Offset: 0xA83720 VA: 0x180A84320
	private bool ShouldUseMeshSampling(Collider c) { }

	// RVA: 0xA84620 Offset: 0xA83A20 VA: 0x180A84620
	private Vector3 TrySnapPointToRenderMesh(Vector3 point, Collider c, BasePlayer player) { }

	// RVA: 0xA7FAE0 Offset: 0xA7EEE0 VA: 0x180A7FAE0
	public bool CanSprayFreehand(BasePlayer player) { }

	// RVA: 0xA822A0 Offset: 0xA816A0 VA: 0x180A822A0
	private bool IsSprayBlockedByTrigger(Vector3 pos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x69E7B0 Offset: 0x69DBB0 VA: 0x18069E7B0
	public SprayCan.SprayMode get_currentMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA85590 Offset: 0xA84990 VA: 0x180A85590
	private void set_currentMode(SprayCan.SprayMode value) { }

	// RVA: 0xA828F0 Offset: 0xA81CF0 VA: 0x180A828F0 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA83BE0 Offset: 0xA82FE0 VA: 0x180A83BE0
	private void OpenReskinOptions(BasePlayer player) { }

	// RVA: 0xA7F650 Offset: 0xA7EA50 VA: 0x180A7F650
	public bool CanOpenReskinMenu(BasePlayer player) { }

	// RVA: 0xA7F470 Offset: 0xA7E870 VA: 0x180A7F470
	private void ApplySkinToItem(BaseEntity targetEntity, int targetSkin) { }

	// RVA: 0xA83E90 Offset: 0xA83290 VA: 0x180A83E90
	private void PlayVMAttack() { }

	// RVA: 0xA84500 Offset: 0xA83900 VA: 0x180A84500
	private void ToggleVMHold(bool state) { }

	// RVA: 0xA84140 Offset: 0xA83540 VA: 0x180A84140
	private void SetVmSprayColour(Color c) { }

	// RVA: 0xA83AA0 Offset: 0xA82EA0 VA: 0x180A83AA0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA7FD90 Offset: 0xA7F190 VA: 0x180A7FD90
	private void Client_ReskinResult(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA82410 Offset: 0xA81810 VA: 0x180A82410 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xA84030 Offset: 0xA83430 VA: 0x180A84030 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0xA83FA0 Offset: 0xA833A0 VA: 0x180A83FA0 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA823E0 Offset: 0xA817E0 VA: 0x180A823E0 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0xA823B0 Offset: 0xA817B0 VA: 0x180A823B0 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0xA7F520 Offset: 0xA7E920 VA: 0x180A7F520
	private bool CanEntityBeRespawned(BaseEntity targetEntity, out SprayCan.SprayFailReason reason) { }

	// RVA: 0xA817F0 Offset: 0xA80BF0 VA: 0x180A817F0
	public static bool GetItemDefinitionForEntity(BaseEntity be, out ItemDefinition def, bool useRedirect = True) { }

	// RVA: 0xA852F0 Offset: 0xA846F0 VA: 0x180A852F0
	public void .ctor() { }

	// RVA: 0xA84B40 Offset: 0xA83F40 VA: 0x180A84B40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA84870 Offset: 0xA83C70 VA: 0x180A84870
	private void <FreePaintInput>b__20_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA84870 Offset: 0xA83C70 VA: 0x180A84870
	private void <FreePaintInput>b__20_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA848A0 Offset: 0xA83CA0 VA: 0x180A848A0
	private bool <TrySnapPointToRenderMesh>g__HitPoint|33_0(Renderer forRenderer, out Vector3 trySnapPointToRenderMesh, ref SprayCan.<>c__DisplayClass33_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA84880 Offset: 0xA83C80 VA: 0x180A84880
	private void <OnInput>b__63_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA84890 Offset: 0xA83C90 VA: 0x180A84890
	private void <OnInput>b__63_1(BasePlayer ply) { }

}

private enum SprayCan.SprayFailReason // TypeDefIndex: 8642
{	// Fields
	public int value__; // 0x0
	public const SprayCan.SprayFailReason None = 0;
	public const SprayCan.SprayFailReason MountedBlocked = 1;
	public const SprayCan.SprayFailReason IOConnection = 2;
	public const SprayCan.SprayFailReason LineOfSight = 3;
	public const SprayCan.SprayFailReason SkinNotOwned = 4;
	public const SprayCan.SprayFailReason InvalidItem = 5;

}

public enum SprayCan.SprayMode // TypeDefIndex: 8643
{	// Fields
	public int value__; // 0x0
	public const SprayCan.SprayMode FreeHand = 0;
	public const SprayCan.SprayMode Decal = 1;

}

private sealed class SprayCan.<>c__DisplayClass20_0 // TypeDefIndex: 8644
{	// Fields
	public int index; // 0x10
	public SprayCan <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA8B5A0 Offset: 0xA8A9A0 VA: 0x180A8B5A0
	internal void <FreePaintInput>b__1(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass20_1 // TypeDefIndex: 8645
{	// Fields
	public int index; // 0x10
	public SprayCan <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA8B5D0 Offset: 0xA8A9D0 VA: 0x180A8B5D0
	internal void <FreePaintInput>b__3(BasePlayer ply) { }

}

private struct SprayCan.<>c__DisplayClass33_0 // TypeDefIndex: 8646
{	// Fields
	public SprayCan <>4__this; // 0x0
	public BasePlayer player; // 0x8
	public Vector3 point; // 0x10

}

private sealed class SprayCan.<>c__DisplayClass63_0 // TypeDefIndex: 8647
{	// Fields
	public ItemSkinDirectory.Skin skin; // 0x10
	public SprayCan <>4__this; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA8B600 Offset: 0xA8AA00 VA: 0x180A8B600
	internal void <OnInput>b__2(BasePlayer ply) { }

}

private sealed class SprayCan.<>c__DisplayClass64_0 // TypeDefIndex: 8648
{	// Fields
	public SprayCan <>4__this; // 0x10
	public BaseEntity targetEntity; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xA8B630 Offset: 0xA8AA30 VA: 0x180A8B630
	internal void <OpenReskinOptions>b__0(bool confirmed, int skinId) { }

}

