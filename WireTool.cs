public class WireTool : HeldEntity // TypeDefIndex: 8662
{	public Sprite InputSprite; // 0x1F8
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

	public bool CanChangeColours { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private void AddIOOption(IOEntity.IOSlot slot, List<Option> opts, bool input, int index, int order = 0) { }

	public void AddClearConnections(List<Option> opts) { }

	public List<Option> GetIOOptions(IOEntity source) { }

	public bool get_CanChangeColours() { }

	public void ClearPendingPlug() { }

	public bool HasPendingPlug() { }

	public bool PendingPlugIsInput() { }

	public bool PendingPlugIsType(IOEntity.IOType type) { }

	public bool PendingPlugIsOutput() { }

	public Vector3 PendingPlugWorldPos() { }

	public static bool CanPlayerUseWires(BasePlayer player) { }

	public static bool CanModifyEntity(BasePlayer player, BaseEntity ent) { }

	public bool PendingPlugRoot() { }

	public bool HasPendingWire() { }

	public float GetPendingLengthRemaining() { }

	public int GetWireClicksRemaining() { }

	public bool ValidSurface() { }

	public void ClientRequestClear(IOEntity ent, int slot, bool input) { }

	public IOEntity GetLookingAtIOEnt() { }

	public override void OnHolster() { }

	public override void OnDeploy() { }

	public bool WantsInputList() { }

	public bool WantsOutputList() { }

	public void ClearClicked() { }

	private bool IsSlotOccupied(IOEntity ent, bool input, int index) { }

	private bool IsSlotValidType(IOEntity ent, bool input, int index) { }

	public void ClientAttemptConnection(bool input, int index) { }

	public void BeginLine(Vector3 startWorldPos) { }

	public static ClientIOLine CreateLine(Vector3 spawnPos, Quaternion rotation, IOEntity.IOType type, WireTool.WireColour colour) { }

	private static string GetElectricalWirePath(WireTool.WireColour colour) { }

	private static string GetFluidicWirePath(WireTool.WireColour colour) { }

	public void EndLine(bool destroy = False) { }

	private bool SendPendingLine(IOEntity input, int inputIndex, IOEntity output, int outputIndex, List<Vector3> positions) { }

	public override bool NeedsCrosshair() { }

	public static void RefreshDirectionalVisibility() { }

	public override void OnInput() { }

	public float GetClearProgress() { }

	private void SetCurrentColour(WireTool.WireColour newColour) { }

	private bool ValidateLine(List<Vector3> lineList, IOEntity inputEntity, IOEntity outputEntity, BasePlayer byPlayer) { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <AddClearConnections>b__5_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OnInput>b__67_0(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OnInput>b__67_1(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OnInput>b__67_2(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OnInput>b__67_3(BasePlayer ply) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <OnInput>b__67_4(BasePlayer ply) { }

}

public enum WireTool.WireColour // TypeDefIndex: 8663
{	public int value__; // 0x0
	public const WireTool.WireColour Default = 0;
	public const WireTool.WireColour Red = 1;
	public const WireTool.WireColour Green = 2;
	public const WireTool.WireColour Blue = 3;
	public const WireTool.WireColour Yellow = 4;

}

public struct WireTool.PendingPlug_t // TypeDefIndex: 8664
{	public IOEntity ent; // 0x0
	public bool input; // 0x8
	public int index; // 0xC
	public GameObject tempLine; // 0x10

}

private sealed class WireTool.<>c__DisplayClass4_0 // TypeDefIndex: 8665
{	public WireTool <>4__this; // 0x10
	public bool input; // 0x18
	public int index; // 0x1C


	public void .ctor() { }

	internal void <AddIOOption>b__0(BasePlayer ply) { }

}

private sealed class WireTool.<>c // TypeDefIndex: 8666
{	public static readonly WireTool.<>c <>9; // 0x0
	public static Func<Collider, bool> <>9__33_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CanPlayerUseWires>b__33_0(Collider collider) { }

}

