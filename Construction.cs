public class Construction : PrefabAttribute // TypeDefIndex: 9052
{	// Fields
	public static string lastPlacementError; // 0x0
	public BaseEntity.Menu.Option info; // 0x98
	public bool canBypassBuildingPermission; // 0xB8
	[FormerlySerializedAsAttribute] // RVA: 0xD0520 Offset: 0xCF920 VA: 0x1800D0520
	public bool canRotateBeforePlacement; // 0xB9
	[FormerlySerializedAsAttribute] // RVA: 0xD0520 Offset: 0xCF920 VA: 0x1800D0520
	public bool canRotateAfterPlacement; // 0xBA
	public bool checkVolumeOnRotate; // 0xBB
	public bool checkVolumeOnUpgrade; // 0xBC
	public bool canPlaceAtMaxDistance; // 0xBD
	public bool placeOnWater; // 0xBE
	public Vector3 rotationAmount; // 0xC0
	public Vector3 applyStartingRotation; // 0xCC
	[RangeAttribute] // RVA: 0x980D0 Offset: 0x974D0 VA: 0x1800980D0
	public float healthMultiplier; // 0xD8
	[RangeAttribute] // RVA: 0x980D0 Offset: 0x974D0 VA: 0x1800980D0
	public float costMultiplier; // 0xDC
	[RangeAttribute] // RVA: 0xD0870 Offset: 0xCFC70 VA: 0x1800D0870
	public float maxplaceDistance; // 0xE0
	public Mesh guideMesh; // 0xE8
	public Socket_Base[] allSockets; // 0xF0
	public BuildingProximity[] allProximities; // 0xF8
	public ConstructionGrade defaultGrade; // 0x100
	public SocketHandle socketHandle; // 0x108
	public Bounds bounds; // 0x110
	public bool isBuildingPrivilege; // 0x128
	public ConstructionGrade[] grades; // 0x130
	public Deployable deployable; // 0x138
	public ConstructionPlaceholder placeholder; // 0x140

	// Properties
	public static bool DebugDraw { get; }

	// Methods

	// RVA: 0x510730 Offset: 0x50FB30 VA: 0x180510730
	public bool UpdatePlacement(Transform transform, Construction common, ref Construction.Target target) { }

	// RVA: 0x50FD50 Offset: 0x50F150 VA: 0x18050FD50
	private bool TestPlacingThroughRock(ref Construction.Placement placement, Construction.Target target) { }

	// RVA: 0x510010 Offset: 0x50F410 VA: 0x180510010
	private static bool TestPlacingThroughWall(ref Construction.Placement placement, Transform transform, Construction common, Construction.Target target) { }

	// RVA: 0x50F8A0 Offset: 0x50ECA0 VA: 0x18050F8A0
	private bool TestPlacingCloseToRoad(ref Construction.Placement placement, Construction.Target target) { }

	// RVA: 0x50F4B0 Offset: 0x50E8B0 VA: 0x18050F4B0 Slot: 8
	public virtual bool ShowAsNeutral(Construction.Target target) { }

	// RVA: 0x5117A0 Offset: 0x510BA0 VA: 0x1805117A0
	public static bool get_DebugDraw() { }

	// RVA: 0x50F3B0 Offset: 0x50E7B0 VA: 0x18050F3B0
	public bool HasMaleSockets(Construction.Target target) { }

	// RVA: 0x50F1F0 Offset: 0x50E5F0 VA: 0x18050F1F0
	public void FindMaleSockets(Construction.Target target, List<Socket_Base> sockets) { }

	// RVA: 0x50E7A0 Offset: 0x50DBA0 VA: 0x18050E7A0
	public GameObject CreateGuideSkin() { }

	// RVA: 0x50E3E0 Offset: 0x50D7E0 VA: 0x18050E3E0 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x50F350 Offset: 0x50E750 VA: 0x18050F350 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x50F7B0 Offset: 0x50EBB0 VA: 0x18050F7B0
	public void .ctor() { }

}

public struct Construction.Target // TypeDefIndex: 9053
{	// Fields
	public bool valid; // 0x0
	public Ray ray; // 0x4
	public BaseEntity entity; // 0x20
	public Socket_Base socket; // 0x28
	public bool onTerrain; // 0x30
	public Vector3 position; // 0x34
	public Vector3 normal; // 0x40
	public Vector3 rotation; // 0x4C
	public BasePlayer player; // 0x58
	public bool inBuildingPrivilege; // 0x60

	// Methods

	// RVA: 0xF29B0 Offset: 0xF1DB0 VA: 0x1800F29B0
	public Quaternion GetWorldRotation(bool female) { }

	// RVA: 0xF2990 Offset: 0xF1D90 VA: 0x1800F2990
	public Vector3 GetWorldPosition() { }

}

public class Construction.Placement // TypeDefIndex: 9054
{	// Fields
	public Vector3 position; // 0x10
	public Quaternion rotation; // 0x1C

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Construction.Grade // TypeDefIndex: 9055
{	// Fields
	public BuildingGrade grade; // 0x10
	public float maxHealth; // 0x18
	public List<ItemAmount> costToBuild; // 0x20

	// Properties
	public PhysicMaterial physicMaterial { get; }
	public ProtectionProperties damageProtecton { get; }

	// Methods

	// RVA: 0x524970 Offset: 0x523D70 VA: 0x180524970
	public PhysicMaterial get_physicMaterial() { }

	// RVA: 0x524950 Offset: 0x523D50 VA: 0x180524950
	public ProtectionProperties get_damageProtecton() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class Construction.<>c // TypeDefIndex: 9056
{	// Fields
	public static readonly Construction.<>c <>9; // 0x0
	public static Func<ConstructionGrade, bool> <>9__33_0; // 0x8
	public static Func<ConstructionGrade, BuildingGrade.Enum> <>9__33_1; // 0x10

	// Methods

	// RVA: 0x525870 Offset: 0x524C70 VA: 0x180525870
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5256F0 Offset: 0x524AF0 VA: 0x1805256F0
	internal bool <CreateGuideSkin>b__33_0(ConstructionGrade x) { }

	// RVA: 0x525750 Offset: 0x524B50 VA: 0x180525750
	internal BuildingGrade.Enum <CreateGuideSkin>b__33_1(ConstructionGrade x) { }

}

public class Construction_SleepingBag : Construction // TypeDefIndex: 9063
{	// Fields
	public static bool ShowSleepingBagProximityWarning; // 0x2B0AA98

	// Methods

	// RVA: 0x50F4D0 Offset: 0x50E8D0 VA: 0x18050F4D0 Slot: 8
	public override bool ShowAsNeutral(Construction.Target target) { }

	// RVA: 0x50F7B0 Offset: 0x50EBB0 VA: 0x18050F7B0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

