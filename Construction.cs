public class Construction : PrefabAttribute // TypeDefIndex: 10767
{
	public static string lastPlacementError; 
	public BaseEntity.Menu.Option info; 
	public bool canBypassBuildingPermission; 
	[FormerlySerializedAsAttribute] 
	public bool canRotateBeforePlacement; 
	[FormerlySerializedAsAttribute] 
	public bool canRotateAfterPlacement; 
	public bool checkVolumeOnRotate; 
	public bool checkVolumeOnUpgrade; 
	public bool canPlaceAtMaxDistance; 
	public bool placeOnWater; 
	public Vector3 rotationAmount; 
	public Vector3 applyStartingRotation; 
	[RangeAttribute] 
	public float healthMultiplier; 
	[RangeAttribute] 
	public float costMultiplier; 
	[RangeAttribute] 
	public float maxplaceDistance; 
	public Mesh guideMesh; 
	public Socket_Base[] allSockets; 
	public BuildingProximity[] allProximities; 
	public ConstructionGrade defaultGrade; 
	public SocketHandle socketHandle; 
	public Bounds bounds; 
	public bool isBuildingPrivilege; 
	public bool isSleepingBag; 
	public ConstructionGrade[] grades; 
	public Deployable deployable; 
	public ConstructionPlaceholder placeholder; 

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

public struct Construction.Target // TypeDefIndex: 10768
{
	public bool valid; 
	public Ray ray; 
	public BaseEntity entity; 
	public Socket_Base socket; 
	public bool onTerrain; 
	public Vector3 position; 
	public Vector3 normal; 
	public Vector3 rotation; 
	public BasePlayer player; 
	public bool inBuildingPrivilege; 


	public Quaternion GetWorldRotation(bool female) { }

	public Vector3 GetWorldPosition() { }

}

public class Construction.Placement // TypeDefIndex: 10769
{
	public Vector3 position; 
	public Quaternion rotation; 


	public void .ctor() { }

}

public class Construction.Grade // TypeDefIndex: 10770
{
	public BuildingGrade grade; 
	public float maxHealth; 
	public List<ItemAmount> costToBuild; 

	public PhysicMaterial physicMaterial { get; }
	public ProtectionProperties damageProtecton { get; }


	public PhysicMaterial get_physicMaterial() { }

	public ProtectionProperties get_damageProtecton() { }

	public void .ctor() { }

}

private sealed class Construction.<>c // TypeDefIndex: 10771
{
	public static readonly Construction.<>c <>9; 
	public static Func<ConstructionGrade, bool> <>9__34_0; 
	public static Func<ConstructionGrade, BuildingGrade.Enum> <>9__34_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CreateGuideSkin>b__34_0(ConstructionGrade x) { }

	internal BuildingGrade.Enum <CreateGuideSkin>b__34_1(ConstructionGrade x) { }

}

public class Construction_SleepingBag : Construction // TypeDefIndex: 10778
{
	public static bool ShowSleepingBagProximityWarning; 


	public override bool ShowAsNeutral(Construction.Target target) { }

	public void .ctor() { }

	private static void .cctor() { }

}

