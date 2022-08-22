public class Construction : PrefabAttribute // TypeDefIndex: 9052
{	public static string lastPlacementError; // 0x0
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

	public static bool DebugDraw { get; }


	public bool UpdatePlacement(Transform transform, Construction common, ref Construction.Target target) { }

	private bool TestPlacingThroughRock(ref Construction.Placement placement, Construction.Target target) { }

	private static bool TestPlacingThroughWall(ref Construction.Placement placement, Transform transform, Construction common, Construction.Target target) { }

	private bool TestPlacingCloseToRoad(ref Construction.Placement placement, Construction.Target target) { }

	public virtual bool ShowAsNeutral(Construction.Target target) { }

	public static bool get_DebugDraw() { }

	public bool HasMaleSockets(Construction.Target target) { }

	public void FindMaleSockets(Construction.Target target, List<Socket_Base> sockets) { }

	public GameObject CreateGuideSkin() { }

	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

public struct Construction.Target // TypeDefIndex: 9053
{	public bool valid; // 0x0
	public Ray ray; // 0x4
	public BaseEntity entity; // 0x20
	public Socket_Base socket; // 0x28
	public bool onTerrain; // 0x30
	public Vector3 position; // 0x34
	public Vector3 normal; // 0x40
	public Vector3 rotation; // 0x4C
	public BasePlayer player; // 0x58
	public bool inBuildingPrivilege; // 0x60


	public Quaternion GetWorldRotation(bool female) { }

	public Vector3 GetWorldPosition() { }

}

public class Construction.Placement // TypeDefIndex: 9054
{	public Vector3 position; // 0x10
	public Quaternion rotation; // 0x1C


	public void .ctor() { }

}

public class Construction.Grade // TypeDefIndex: 9055
{	public BuildingGrade grade; // 0x10
	public float maxHealth; // 0x18
	public List<ItemAmount> costToBuild; // 0x20

	public PhysicMaterial physicMaterial { get; }
	public ProtectionProperties damageProtecton { get; }


	public PhysicMaterial get_physicMaterial() { }

	public ProtectionProperties get_damageProtecton() { }

	public void .ctor() { }

}

private sealed class Construction.<>c // TypeDefIndex: 9056
{	public static readonly Construction.<>c <>9; // 0x0
	public static Func<ConstructionGrade, bool> <>9__33_0; // 0x8
	public static Func<ConstructionGrade, BuildingGrade.Enum> <>9__33_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CreateGuideSkin>b__33_0(ConstructionGrade x) { }

	internal BuildingGrade.Enum <CreateGuideSkin>b__33_1(ConstructionGrade x) { }

}

public class Construction_SleepingBag : Construction // TypeDefIndex: 9063
{	public static bool ShowSleepingBagProximityWarning; // 0x2B0AA98


	public override bool ShowAsNeutral(Construction.Target target) { }

	public void .ctor() { }

	private static void .cctor() { }

}

