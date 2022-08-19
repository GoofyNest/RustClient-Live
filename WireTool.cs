public class WireTool : HeldEntity // TypeDefIndex: 8662
{	// Fields
	public Sprite InputSprite; // 0x1F8
	public Sprite OutputSprite; // 0x200
	public Sprite ClearSprite; // 0x208
	public static float maxWireLength; // 0x0
	private const int maxLineNodes = 16;
	public GameObjectRef plugEffect; // 0x210
	public GameObjectRef ioLine; // 0x218
	public IOEntity.IOType wireType; // 0x220
	public static Translate.Phrase Default; // 0x8
	public static Translate.Phrase DefaultDesc; // 0x10
	public static Translate.Phrase Red; // 0x18
	public static Translate.Phrase RedDesc; // 0x20
	public static Translate.Phrase Green; // 0x28
	public static Translate.Phrase GreenDesc; // 0x30
	public static Translate.Phrase Blue; // 0x38
	public static Translate.Phrase BlueDesc; // 0x40
	public static Translate.Phrase Yellow; // 0x48
	public static Translate.Phrase YellowDesc; // 0x50
	public WireTool.PendingPlug_t pending; // 0x228
	private const float lineThickness = 0,02;
	private bool wantsCrosshair; // 0x240
	private ClientIOLine pendingLine; // 0x248
	private WireTool.WireColour currentColour; // 0x250
	private float nextClearSendTime; // 0x254
	private float remainingDist; // 0x258
	private bool validSurface; // 0x25C
	private bool couldBuild; // 0x25D
	private bool isSolo; // 0x25E
	private float clearProgress; // 0x260

	// Properties
	public bool CanChangeColours { get; }

	// Methods

	// RVA: 0x8A5C40 Offset: 0x8A5040 VA: 0x1808A5C40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8A1980 Offset: 0x8A0D80 VA: 0x1808A1980
	private void AddIOOption(IOEntity.IOSlot slot, List<Option> opts, bool input, int index, int order = 0) { }

	// RVA: 0x8A1800 Offset: 0x8A0C00 VA: 0x1808A1800
	public void AddClearConnections(List<Option> opts) { }

	// RVA: 0x8A30B0 Offset: 0x8A24B0 VA: 0x1808A30B0
	public List<Option> GetIOOptions(IOEntity source) { }

	// RVA: 0x8A6E30 Offset: 0x8A6230 VA: 0x1808A6E30
	public bool get_CanChangeColours() { }

	// RVA: 0x8A2200 Offset: 0x8A1600 VA: 0x1808A2200
	public void ClearPendingPlug() { }

	// RVA: 0x8A36A0 Offset: 0x8A2AA0 VA: 0x1808A36A0
	public bool HasPendingPlug() { }

	// RVA: 0x8A5D30 Offset: 0x8A5130 VA: 0x1808A5D30
	public bool PendingPlugIsInput() { }

	// RVA: 0x8A5E50 Offset: 0x8A5250 VA: 0x1808A5E50
	public bool PendingPlugIsType(IOEntity.IOType type) { }

	// RVA: 0x8A5DC0 Offset: 0x8A51C0 VA: 0x1808A5DC0
	public bool PendingPlugIsOutput() { }

	// RVA: 0x8A6000 Offset: 0x8A5400 VA: 0x1808A6000
	public Vector3 PendingPlugWorldPos() { }

	// RVA: 0x8A1F40 Offset: 0x8A1340 VA: 0x1808A1F40
	public static bool CanPlayerUseWires(BasePlayer player) { }

	// RVA: 0x8A1E50 Offset: 0x8A1250 VA: 0x1808A1E50
	public static bool CanModifyEntity(BasePlayer player, BaseEntity ent) { }

	// RVA: 0x8A5F60 Offset: 0x8A5360 VA: 0x1808A5F60
	public bool PendingPlugRoot() { }

	// RVA: 0x8A3720 Offset: 0x8A2B20 VA: 0x1808A3720
	public bool HasPendingWire() { }

	// RVA: 0x8A3540 Offset: 0x8A2940 VA: 0x1808A3540
	public float GetPendingLengthRemaining() { }

	// RVA: 0x8A35F0 Offset: 0x8A29F0 VA: 0x1808A35F0
	public int GetWireClicksRemaining() { }

	// RVA: 0x8A65E0 Offset: 0x8A59E0 VA: 0x1808A65E0
	public bool ValidSurface() { }

	// RVA: 0x8A2C50 Offset: 0x8A2050 VA: 0x1808A2C50
	public void ClientRequestClear(IOEntity ent, int slot, bool input) { }

	// RVA: 0x8A3390 Offset: 0x8A2790 VA: 0x1808A3390
	public IOEntity GetLookingAtIOEnt() { }

	// RVA: 0x8A3A40 Offset: 0x8A2E40 VA: 0x1808A3A40 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x8A3980 Offset: 0x8A2D80 VA: 0x1808A3980 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x8A6AA0 Offset: 0x8A5EA0 VA: 0x1808A6AA0
	public bool WantsInputList() { }

	// RVA: 0x8A6AC0 Offset: 0x8A5EC0 VA: 0x1808A6AC0
	public bool WantsOutputList() { }

	// RVA: 0x8A2150 Offset: 0x8A1550 VA: 0x1808A2150
	public void ClearClicked() { }

	// RVA: 0x8A3780 Offset: 0x8A2B80 VA: 0x1808A3780
	private bool IsSlotOccupied(IOEntity ent, bool input, int index) { }

	// RVA: 0x8A38B0 Offset: 0x8A2CB0 VA: 0x1808A38B0
	private bool IsSlotValidType(IOEntity ent, bool input, int index) { }

	// RVA: 0x8A2230 Offset: 0x8A1630 VA: 0x1808A2230
	public void ClientAttemptConnection(bool input, int index) { }

	// RVA: 0x8A1C20 Offset: 0x8A1020 VA: 0x1808A1C20
	public void BeginLine(Vector3 startWorldPos) { }

	// RVA: 0x8A2D10 Offset: 0x8A2110 VA: 0x1808A2D10
	public static ClientIOLine CreateLine(Vector3 spawnPos, Quaternion rotation, IOEntity.IOType type, WireTool.WireColour colour) { }

	// RVA: 0x8A2FC0 Offset: 0x8A23C0 VA: 0x1808A2FC0
	private static string GetElectricalWirePath(WireTool.WireColour colour) { }

	// RVA: 0x8A3040 Offset: 0x8A2440 VA: 0x1808A3040
	private static string GetFluidicWirePath(WireTool.WireColour colour) { }

	// RVA: 0x8A2EE0 Offset: 0x8A22E0 VA: 0x1808A2EE0
	public void EndLine(bool destroy = False) { }

	// RVA: 0x8A63D0 Offset: 0x8A57D0 VA: 0x1808A63D0
	private bool SendPendingLine(IOEntity input, int inputIndex, IOEntity output, int outputIndex, List<Vector3> positions) { }

	// RVA: 0x8A3970 Offset: 0x8A2D70 VA: 0x1808A3970 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x8A61C0 Offset: 0x8A55C0 VA: 0x1808A61C0
	public static void RefreshDirectionalVisibility() { }

	// RVA: 0x8A3B20 Offset: 0x8A2F20 VA: 0x1808A3B20 Slot: 138
	public override void OnInput() { }

	// RVA: 0x8A2FB0 Offset: 0x8A23B0 VA: 0x1808A2FB0
	public float GetClearProgress() { }

	// RVA: 0x8A6580 Offset: 0x8A5980 VA: 0x1808A6580
	private void SetCurrentColour(WireTool.WireColour newColour) { }

	// RVA: 0x8A65F0 Offset: 0x8A59F0 VA: 0x1808A65F0
	private bool ValidateLine(List<Vector3> lineList, IOEntity inputEntity, IOEntity outputEntity, BasePlayer byPlayer) { }

	// RVA: 0x8A6DD0 Offset: 0x8A61D0 VA: 0x1808A6DD0
	public void .ctor() { }

	// RVA: 0x8A6AE0 Offset: 0x8A5EE0 VA: 0x1808A6AE0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8A2150 Offset: 0x8A1550 VA: 0x1808A2150
	private void <AddClearConnections>b__5_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8A6590 Offset: 0x8A5990 VA: 0x1808A6590
	private void <OnInput>b__67_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8A65A0 Offset: 0x8A59A0 VA: 0x1808A65A0
	private void <OnInput>b__67_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8A65B0 Offset: 0x8A59B0 VA: 0x1808A65B0
	private void <OnInput>b__67_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8A65C0 Offset: 0x8A59C0 VA: 0x1808A65C0
	private void <OnInput>b__67_3(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8A65D0 Offset: 0x8A59D0 VA: 0x1808A65D0
	private void <OnInput>b__67_4(BasePlayer ply) { }

}

public enum WireTool.WireColour // TypeDefIndex: 8663
{	// Fields
	public int value__; // 0x0
	public const WireTool.WireColour Default = 0;
	public const WireTool.WireColour Red = 1;
	public const WireTool.WireColour Green = 2;
	public const WireTool.WireColour Blue = 3;
	public const WireTool.WireColour Yellow = 4;

}

public struct WireTool.PendingPlug_t // TypeDefIndex: 8664
{	// Fields
	public IOEntity ent; // 0x0
	public bool input; // 0x8
	public int index; // 0xC
	public GameObject tempLine; // 0x10

}

private sealed class WireTool.<>c__DisplayClass4_0 // TypeDefIndex: 8665
{	// Fields
	public WireTool <>4__this; // 0x10
	public bool input; // 0x18
	public int index; // 0x1C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x897B10 Offset: 0x896F10 VA: 0x180897B10
	internal void <AddIOOption>b__0(BasePlayer ply) { }

}

private sealed class WireTool.<>c // TypeDefIndex: 8666
{	// Fields
	public static readonly WireTool.<>c <>9; // 0x0
	public static Func<Collider, bool> <>9__33_0; // 0x8

	// Methods

	// RVA: 0x897D20 Offset: 0x897120 VA: 0x180897D20
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x897790 Offset: 0x896B90 VA: 0x180897790
	internal bool <CanPlayerUseWires>b__33_0(Collider collider) { }

}

