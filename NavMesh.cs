public sealed class NavMeshPath // TypeDefIndex: 4444
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 // TypeDefIndex: 4438

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 4439

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 4440

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 // TypeDefIndex: 4441

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 // TypeDefIndex: 4442

// Namespace: 
internal class <Module> // TypeDefIndex: 4443

// Namespace: UnityEngine.AI
[NativeHeaderAttribute] // RVA: 0xB3550 Offset: 0xB2950 VA: 0x1800B3550
[MovedFromAttribute] // RVA: 0xB3550 Offset: 0xB2950 VA: 0x1800B3550
public sealed class NavMeshPath // TypeDefIndex: 4444
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal Vector3[] m_Corners; // 0x18

}

public static class NavMeshBuilder // TypeDefIndex: 4445
{	// Methods

	// RVA: 0x22F6F40 Offset: 0x22F6340 VA: 0x1822F6F40
	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x22F7190 Offset: 0x22F6590 VA: 0x1822F7190
	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	// RVA: 0x22F6EC0 Offset: 0x22F62C0 VA: 0x1822F6EC0
	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x22F6C40 Offset: 0x22F6040 VA: 0x1822F6C40
	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	// RVA: 0x22F75C0 Offset: 0x22F69C0 VA: 0x1822F75C0
	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x22F73F0 Offset: 0x22F67F0 VA: 0x1822F73F0
	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	// RVA: 0x22F7380 Offset: 0x22F6780 VA: 0x1822F7380
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	// RVA: 0x22F6E50 Offset: 0x22F6250 VA: 0x1822F6E50
	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	// RVA: 0x22F7550 Offset: 0x22F6950 VA: 0x1822F7550
	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

	// RVA: 0x22F7310 Offset: 0x22F6710 VA: 0x1822F7310
	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

}

public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 4446
{	// Properties
	public bool isOnOffMeshLink { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0xB3BD0 Offset: 0xB2FD0 VA: 0x1800B3BD0
	// RVA: 0x22F6900 Offset: 0x22F5D00 VA: 0x1822F6900
	public bool get_isOnOffMeshLink() { }

}

public struct NavMeshHit // TypeDefIndex: 4448
{
// Namespace: UnityEngine.AI
[MovedFromAttribute] // RVA: 0xB3D80 Offset: 0xB3180 VA: 0x1800B3D80
public struct NavMeshHit // TypeDefIndex: 4448
	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Normal; // 0xC
	private float m_Distance; // 0x18
	private int m_Mask; // 0x1C
	private int m_Hit; // 0x20

	// Properties
	public Vector3 position { get; }
	public Vector3 normal { get; }

	// Methods

	// RVA: 0x212A20 Offset: 0x211E20 VA: 0x180212A20
	public Vector3 get_position() { }

	// RVA: 0x212A40 Offset: 0x211E40 VA: 0x180212A40
	public Vector3 get_normal() { }

}

public sealed class NavMeshData : Object // TypeDefIndex: 4449
{	// Properties
	public Vector3 position { set; }
	public Quaternion rotation { set; }

	// Methods

	// RVA: 0x22F77E0 Offset: 0x22F6BE0 VA: 0x1822F77E0
	public void .ctor(int agentTypeID) { }

	[StaticAccessorAttribute] // RVA: 0xB3F50 Offset: 0xB3350 VA: 0x1800B3F50
	// RVA: 0x22F77A0 Offset: 0x22F6BA0 VA: 0x1822F77A0
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	// RVA: 0x22F78C0 Offset: 0x22F6CC0 VA: 0x1822F78C0
	public void set_position(Vector3 value) { }

	// RVA: 0x22F7960 Offset: 0x22F6D60 VA: 0x1822F7960
	public void set_rotation(Quaternion value) { }

	// RVA: 0x22F7870 Offset: 0x22F6C70 VA: 0x1822F7870
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x22F7910 Offset: 0x22F6D10 VA: 0x1822F7910
	private void set_rotation_Injected(ref Quaternion value) { }

}

public struct NavMeshDataInstance // TypeDefIndex: 4450
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private int <id>k__BackingField; // 0x0

	// Properties
	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }

	// Methods

	// RVA: 0x23EE20 Offset: 0x23E220 VA: 0x18023EE20
	public bool get_valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	internal int get_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	internal void set_id(int value) { }

	// RVA: 0x23EDE0 Offset: 0x23E1E0 VA: 0x18023EDE0
	public void Remove() { }

	// RVA: 0x23EE70 Offset: 0x23E270 VA: 0x18023EE70
	public void set_owner(Object value) { }

}

public struct NavMeshLinkData // TypeDefIndex: 4451
{	// Fields
	private Vector3 m_StartPosition; // 0x0
	private Vector3 m_EndPosition; // 0xC
	private float m_CostModifier; // 0x18
	private int m_Bidirectional; // 0x1C
	private float m_Width; // 0x20
	private int m_Area; // 0x24
	private int m_AgentTypeID; // 0x28

	// Properties
	public Vector3 startPosition { set; }
	public Vector3 endPosition { set; }
	public float costModifier { set; }
	public bool bidirectional { set; }
	public float width { set; }
	public int area { set; }
	public int agentTypeID { set; }

	// Methods

	// RVA: 0x204DC0 Offset: 0x2041C0 VA: 0x180204DC0
	public void set_startPosition(Vector3 value) { }

	// RVA: 0x212B50 Offset: 0x211F50 VA: 0x180212B50
	public void set_endPosition(Vector3 value) { }

	// RVA: 0x239430 Offset: 0x238830 VA: 0x180239430
	public void set_costModifier(float value) { }

	// RVA: 0x23EF50 Offset: 0x23E350 VA: 0x18023EF50
	public void set_bidirectional(bool value) { }

	// RVA: 0x23D780 Offset: 0x23CB80 VA: 0x18023D780
	public void set_width(float value) { }

	// RVA: 0x2226B0 Offset: 0x221AB0 VA: 0x1802226B0
	public void set_area(int value) { }

	// RVA: 0xF3DF0 Offset: 0xF31F0 VA: 0x1800F3DF0
	public void set_agentTypeID(int value) { }

}

public struct NavMeshLinkInstance // TypeDefIndex: 4452
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private int <id>k__BackingField; // 0x0

	// Properties
	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }

	// Methods

	// RVA: 0x23EFA0 Offset: 0x23E3A0 VA: 0x18023EFA0
	public bool get_valid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	internal int get_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	internal void set_id(int value) { }

	// RVA: 0x23EF60 Offset: 0x23E360 VA: 0x18023EF60
	public void Remove() { }

	// RVA: 0x23EFF0 Offset: 0x23E3F0 VA: 0x18023EFF0
	public void set_owner(Object value) { }

}

public struct NavMeshQueryFilter // TypeDefIndex: 4453
{	// Fields
	private const int k_AreaCostElementCount = 32;
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private float[] <costs>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private int <areaMask>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private int <agentTypeID>k__BackingField; // 0xC

}

public static class NavMesh // TypeDefIndex: 4454
{	// Fields
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x1280D

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F8030 Offset: 0x22F7430 VA: 0x1822F8030
	private static void Internal_CallOnNavMeshPreUpdate() { }

	// RVA: 0x22F7E60 Offset: 0x22F7260 VA: 0x1822F7E60
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData) { }

	// RVA: 0x22F7D70 Offset: 0x22F7170 VA: 0x1822F7D70
	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	[NativeNameAttribute] // RVA: 0xB4A10 Offset: 0xB3E10 VA: 0x1800B4A10
	// RVA: 0x22F80C0 Offset: 0x22F74C0 VA: 0x1822F80C0
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB4C90 Offset: 0xB4090 VA: 0x1800B4C90
	// RVA: 0x22F8080 Offset: 0x22F7480 VA: 0x1822F8080
	internal static bool IsValidLinkHandle(int handle) { }

	[StaticAccessorAttribute] // RVA: 0xB6120 Offset: 0xB5520 VA: 0x1800B6120
	[NativeNameAttribute] // RVA: 0xB6120 Offset: 0xB5520 VA: 0x1800B6120
	// RVA: 0x22F7FF0 Offset: 0x22F73F0 VA: 0x1822F7FF0
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	[NativeNameAttribute] // RVA: 0xB63B0 Offset: 0xB57B0 VA: 0x1800B63B0
	// RVA: 0x22F7FB0 Offset: 0x22F73B0 VA: 0x1822F7FB0
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[StaticAccessorAttribute] // RVA: 0xB6570 Offset: 0xB5970 VA: 0x1800B6570
	[NativeNameAttribute] // RVA: 0xB6570 Offset: 0xB5970 VA: 0x1800B6570
	// RVA: 0x22F7C70 Offset: 0x22F7070 VA: 0x1822F7C70
	internal static int AddNavMeshDataInternal(NavMeshData navMeshData) { }

	[StaticAccessorAttribute] // RVA: 0xB6570 Offset: 0xB5970 VA: 0x1800B6570
	[NativeNameAttribute] // RVA: 0xB6570 Offset: 0xB5970 VA: 0x1800B6570
	// RVA: 0x22F7D10 Offset: 0x22F7110 VA: 0x1822F7D10
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB6820 Offset: 0xB5C20 VA: 0x1800B6820
	[StaticAccessorAttribute] // RVA: 0xB6820 Offset: 0xB5C20 VA: 0x1800B6820
	// RVA: 0x22F8140 Offset: 0x22F7540 VA: 0x1822F8140
	internal static void RemoveNavMeshDataInternal(int handle) { }

	// RVA: 0x22F7BF0 Offset: 0x22F6FF0 VA: 0x1822F7BF0
	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] // RVA: 0xB6950 Offset: 0xB5D50 VA: 0x1800B6950
	[StaticAccessorAttribute] // RVA: 0xB6950 Offset: 0xB5D50 VA: 0x1800B6950
	// RVA: 0x22F7B90 Offset: 0x22F6F90 VA: 0x1822F7B90
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] // RVA: 0xB6AF0 Offset: 0xB5EF0 VA: 0x1800B6AF0
	[NativeNameAttribute] // RVA: 0xB6AF0 Offset: 0xB5EF0 VA: 0x1800B6AF0
	// RVA: 0x22F8100 Offset: 0x22F7500 VA: 0x1822F8100
	internal static void RemoveLinkInternal(int handle) { }

	// RVA: 0x22F7F50 Offset: 0x22F7350 VA: 0x1822F7F50
	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	// RVA: 0x22F7CB0 Offset: 0x22F70B0 VA: 0x1822F7CB0
	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x22F7B30 Offset: 0x22F6F30 VA: 0x1822F7B30
	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x22F7F10 Offset: 0x22F7310 VA: 0x1822F7F10
	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

}

public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 4455
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A76FB0 Offset: 0x1A763B0 VA: 0x181A76FB0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum NavMeshBuildSourceShape // TypeDefIndex: 4456
{	// Fields
	public int value__; // 0x0
	public const NavMeshBuildSourceShape Mesh = 0;
	public const NavMeshBuildSourceShape Terrain = 1;
	public const NavMeshBuildSourceShape Box = 2;
	public const NavMeshBuildSourceShape Sphere = 3;
	public const NavMeshBuildSourceShape Capsule = 4;
	public const NavMeshBuildSourceShape ModifierBox = 5;

}

public enum NavMeshCollectGeometry // TypeDefIndex: 4457
{	// Fields
	public int value__; // 0x0
	public const NavMeshCollectGeometry RenderMeshes = 0;
	public const NavMeshCollectGeometry PhysicsColliders = 1;

}

public struct NavMeshBuildSource // TypeDefIndex: 4458
{	// Fields
	private Matrix4x4 m_Transform; // 0x0
	private Vector3 m_Size; // 0x40
	private NavMeshBuildSourceShape m_Shape; // 0x4C
	private int m_Area; // 0x50
	private int m_InstanceID; // 0x54
	private int m_ComponentID; // 0x58

	// Properties
	public Matrix4x4 transform { get; set; }
	public Vector3 size { get; set; }
	public NavMeshBuildSourceShape shape { get; set; }
	public int area { set; }
	public Object sourceObject { get; set; }
	public Component component { get; }

	// Methods

	// RVA: 0x23ECE0 Offset: 0x23E0E0 VA: 0x18023ECE0
	public Matrix4x4 get_transform() { }

	// RVA: 0x23EDC0 Offset: 0x23E1C0 VA: 0x18023EDC0
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x23EC80 Offset: 0x23E080 VA: 0x18023EC80
	public Vector3 get_size() { }

	// RVA: 0x23ED20 Offset: 0x23E120 VA: 0x18023ED20
	public void set_size(Vector3 value) { }

	// RVA: 0x23EC70 Offset: 0x23E070 VA: 0x18023EC70
	public NavMeshBuildSourceShape get_shape() { }

	// RVA: 0x23ED10 Offset: 0x23E110 VA: 0x18023ED10
	public void set_shape(NavMeshBuildSourceShape value) { }

	// RVA: 0x1D2630 Offset: 0x1D1A30 VA: 0x1801D2630
	public void set_area(int value) { }

	// RVA: 0x23ECA0 Offset: 0x23E0A0 VA: 0x18023ECA0
	public Object get_sourceObject() { }

	// RVA: 0x23ED30 Offset: 0x23E130 VA: 0x18023ED30
	public void set_sourceObject(Object value) { }

	// RVA: 0x23EC30 Offset: 0x23E030 VA: 0x18023EC30
	public Component get_component() { }

	[StaticAccessorAttribute] // RVA: 0xB6E40 Offset: 0xB6240 VA: 0x1800B6E40
	// RVA: 0x22F6A20 Offset: 0x22F5E20 VA: 0x1822F6A20
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessorAttribute] // RVA: 0xB6E40 Offset: 0xB6240 VA: 0x1800B6E40
	// RVA: 0x22F6A60 Offset: 0x22F5E60 VA: 0x1822F6A60
	private static Object InternalGetObject(int instanceID) { }

}

public struct NavMeshBuildMarkup // TypeDefIndex: 4459
{	// Fields
	private int m_OverrideArea; // 0x0
	private int m_Area; // 0x4
	private int m_IgnoreFromBuild; // 0x8
	private int m_InstanceID; // 0xC

	// Properties
	public bool overrideArea { set; }
	public int area { set; }
	public bool ignoreFromBuild { set; }
	public Transform root { set; }

	// Methods

	// RVA: 0x23EB70 Offset: 0x23DF70 VA: 0x18023EB70
	public void set_overrideArea(bool value) { }

	// RVA: 0x19DDF0 Offset: 0x19D1F0 VA: 0x18019DDF0
	public void set_area(int value) { }

	// RVA: 0x23EB60 Offset: 0x23DF60 VA: 0x18023EB60
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x23EB80 Offset: 0x23DF80 VA: 0x18023EB80
	public void set_root(Transform value) { }

}

public struct NavMeshBuildSettings // TypeDefIndex: 4460
{	// Fields
	private int m_AgentTypeID; // 0x0
	private float m_AgentRadius; // 0x4
	private float m_AgentHeight; // 0x8
	private float m_AgentSlope; // 0xC
	private float m_AgentClimb; // 0x10
	private float m_LedgeDropHeight; // 0x14
	private float m_MaxJumpAcrossDistance; // 0x18
	private float m_MinRegionArea; // 0x1C
	private int m_OverrideVoxelSize; // 0x20
	private float m_VoxelSize; // 0x24
	private int m_OverrideTileSize; // 0x28
	private int m_TileSize; // 0x2C
	private int m_AccuratePlacement; // 0x30
	private NavMeshBuildDebugSettings m_Debug; // 0x34

	// Properties
	public int agentTypeID { get; set; }
	public bool overrideVoxelSize { set; }
	public float voxelSize { set; }
	public bool overrideTileSize { set; }
	public int tileSize { set; }

	// Methods

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	public int get_agentTypeID() { }

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_agentTypeID(int value) { }

	// RVA: 0x23EC20 Offset: 0x23E020 VA: 0x18023EC20
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x23D790 Offset: 0x23CB90 VA: 0x18023D790
	public void set_voxelSize(float value) { }

	// RVA: 0x23EC10 Offset: 0x23E010 VA: 0x18023EC10
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x1D8540 Offset: 0x1D7940 VA: 0x1801D8540
	public void set_tileSize(int value) { }

}

public struct NavMeshBuildDebugSettings // TypeDefIndex: 4461
{	// Fields
	private byte m_Flags; // 0x0

}

public class NavMeshLink : MonoBehaviour // TypeDefIndex: 8143
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <UpdateOnTransformChanged>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_AgentTypeID; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 m_StartPoint; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 m_EndPoint; // 0x2C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_Width; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_CostModifier; // 0x3C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_Bidirectional; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_AutoUpdatePosition; // 0x41
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_Area; // 0x44
	private NavMeshLinkInstance m_LinkInstance; // 0x48
	private Vector3 m_LastPosition; // 0x4C
	private Quaternion m_LastRotation; // 0x58
	private static readonly List<NavMeshLink> s_Tracked; // 0x0

	// Properties
	public bool UpdateOnTransformChanged { get; set; }
	public int agentTypeID { get; set; }
	public Vector3 startPoint { get; set; }
	public Vector3 endPoint { get; set; }
	public float width { get; set; }
	public int costModifier { get; set; }
	public bool bidirectional { get; set; }
	public bool autoUpdate { get; set; }
	public int area { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	public void set_UpdateOnTransformChanged(bool value) { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_agentTypeID() { }

	// RVA: 0x12C7830 Offset: 0x12C6C30 VA: 0x1812C7830
	public void set_agentTypeID(int value) { }

	// RVA: 0x12C7810 Offset: 0x12C6C10 VA: 0x1812C7810
	public Vector3 get_startPoint() { }

	// RVA: 0x12C7930 Offset: 0x12C6D30 VA: 0x1812C7930
	public void set_startPoint(Vector3 value) { }

	// RVA: 0x12C77F0 Offset: 0x12C6BF0 VA: 0x1812C77F0
	public Vector3 get_endPoint() { }

	// RVA: 0x12C78F0 Offset: 0x12C6CF0 VA: 0x1812C78F0
	public void set_endPoint(Vector3 value) { }

	// RVA: 0x10B2CD0 Offset: 0x10B20D0 VA: 0x1810B2CD0
	public float get_width() { }

	// RVA: 0x12C7970 Offset: 0x12C6D70 VA: 0x1812C7970
	public void set_width(float value) { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	public int get_costModifier() { }

	// RVA: 0x12C78C0 Offset: 0x12C6CC0 VA: 0x1812C78C0
	public void set_costModifier(int value) { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	public bool get_bidirectional() { }

	// RVA: 0x12C7890 Offset: 0x12C6C90 VA: 0x1812C7890
	public void set_bidirectional(bool value) { }

	// RVA: 0xEE1D40 Offset: 0xEE1140 VA: 0x180EE1D40
	public bool get_autoUpdate() { }

	// RVA: 0x12C7470 Offset: 0x12C6870 VA: 0x1812C7470
	public void set_autoUpdate(bool value) { }

	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public int get_area() { }

	// RVA: 0x12C7860 Offset: 0x12C6C60 VA: 0x1812C7860
	public void set_area(int value) { }

	// RVA: 0x12C72C0 Offset: 0x12C66C0 VA: 0x1812C72C0
	private void OnEnable() { }

	// RVA: 0x12C7260 Offset: 0x12C6660 VA: 0x1812C7260
	private void OnDisable() { }

	// RVA: 0x12C7230 Offset: 0x12C6630 VA: 0x1812C7230
	public void UpdateLink() { }

	// RVA: 0x12C6FA0 Offset: 0x12C63A0 VA: 0x1812C6FA0
	private static void AddTracking(NavMeshLink link) { }

	// RVA: 0x12C7340 Offset: 0x12C6740 VA: 0x1812C7340
	private static void RemoveTracking(NavMeshLink link) { }

	// RVA: 0x12C7470 Offset: 0x12C6870 VA: 0x1812C7470
	private void SetAutoUpdate(bool value) { }

	// RVA: 0x12C6D90 Offset: 0x12C6190 VA: 0x1812C6D90
	private void AddLink() { }

	// RVA: 0x12C70F0 Offset: 0x12C64F0 VA: 0x1812C70F0
	private bool HasTransformChanged() { }

	// RVA: 0x12C7230 Offset: 0x12C6630 VA: 0x1812C7230
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x12C7510 Offset: 0x12C6910 VA: 0x1812C7510
	private static void UpdateTrackedInstances() { }

	// RVA: 0x12C76D0 Offset: 0x12C6AD0 VA: 0x1812C76D0
	public void .ctor() { }

	// RVA: 0x12C7670 Offset: 0x12C6A70 VA: 0x1812C7670
	private static void .cctor() { }

}

public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 8144
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_OverrideArea; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_Area; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_IgnoreFromBuild; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<int> m_AffectedAgents; // 0x28
	private static readonly List<NavMeshModifier> s_NavMeshModifiers; // 0x0

	// Properties
	public bool overrideArea { get; set; }
	public int area { get; set; }
	public bool ignoreFromBuild { get; set; }
	public static List<NavMeshModifier> activeModifiers { get; }

	// Methods

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_overrideArea() { }

	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	public void set_overrideArea(bool value) { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_area() { }

	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0
	public void set_area(int value) { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_ignoreFromBuild() { }

	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	public void set_ignoreFromBuild(bool value) { }

	// RVA: 0x12C8140 Offset: 0x12C7540 VA: 0x1812C8140
	public static List<NavMeshModifier> get_activeModifiers() { }

	// RVA: 0x12C7F50 Offset: 0x12C7350 VA: 0x1812C7F50
	private void OnEnable() { }

	// RVA: 0x12C7ED0 Offset: 0x12C72D0 VA: 0x1812C7ED0
	private void OnDisable() { }

	// RVA: 0x12C7E30 Offset: 0x12C7230 VA: 0x1812C7E30
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x12C8080 Offset: 0x12C7480 VA: 0x1812C8080
	public void .ctor() { }

	// RVA: 0x12C8020 Offset: 0x12C7420 VA: 0x1812C8020
	private static void .cctor() { }

}

public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 8145
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 m_Size; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 m_Center; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_Area; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private List<int> m_AffectedAgents; // 0x38
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; // 0x0

	// Properties
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public int area { get; set; }
	public static List<NavMeshModifierVolume> activeModifiers { get; }

	// Methods

	// RVA: 0x12C7E00 Offset: 0x12C7200 VA: 0x1812C7E00
	public Vector3 get_size() { }

	// RVA: 0x12C7E20 Offset: 0x12C7220 VA: 0x1812C7E20
	public void set_size(Vector3 value) { }

	// RVA: 0x106F490 Offset: 0x106E890 VA: 0x18106F490
	public Vector3 get_center() { }

	// RVA: 0x106F670 Offset: 0x106EA70 VA: 0x18106F670
	public void set_center(Vector3 value) { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public int get_area() { }

	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80
	public void set_area(int value) { }

	// RVA: 0x12C7DA0 Offset: 0x12C71A0 VA: 0x1812C7DA0
	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	// RVA: 0x12C7B80 Offset: 0x12C6F80 VA: 0x1812C7B80
	private void OnEnable() { }

	// RVA: 0x12C7B00 Offset: 0x12C6F00 VA: 0x1812C7B00
	private void OnDisable() { }

	// RVA: 0x12C7A10 Offset: 0x12C6E10 VA: 0x1812C7A10
	public bool AffectsAgentType(int agentTypeID) { }

	// RVA: 0x12C79A0 Offset: 0x12C6DA0 VA: 0x1812C79A0
	public void AddAgentType(int agentTypeID) { }

	// RVA: 0x12C7AB0 Offset: 0x12C6EB0 VA: 0x1812C7AB0
	public void ClearAgentTypes() { }

	// RVA: 0x12C7CB0 Offset: 0x12C70B0 VA: 0x1812C7CB0
	public void .ctor() { }

	// RVA: 0x12C7C50 Offset: 0x12C7050 VA: 0x1812C7C50
	private static void .cctor() { }

}

public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 8147
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <UpdateOnTransformChanged>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_AgentTypeID; // 0x1C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CollectObjects m_CollectObjects; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 m_Size; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 m_Center; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private LayerMask m_LayerMask; // 0x3C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private NavMeshCollectGeometry m_UseGeometry; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_DefaultArea; // 0x44
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_IgnoreNavMeshAgent; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_IgnoreNavMeshObstacle; // 0x49
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_OverrideTileSize; // 0x4A
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_TileSize; // 0x4C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_OverrideVoxelSize; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_VoxelSize; // 0x54
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_BuildHeightMesh; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0x96810 Offset: 0x95C10 VA: 0x180096810
	[SerializeField] // RVA: 0x96810 Offset: 0x95C10 VA: 0x180096810
	private NavMeshData m_NavMeshData; // 0x60
	private NavMeshDataInstance m_NavMeshDataInstance; // 0x68
	private Vector3 m_LastPosition; // 0x6C
	private Quaternion m_LastRotation; // 0x78
	private static readonly List<NavMeshSurface> s_NavMeshSurfaces; // 0x0

	// Properties
	public bool UpdateOnTransformChanged { get; set; }
	public int agentTypeID { get; set; }
	public CollectObjects collectObjects { get; set; }
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public LayerMask layerMask { get; set; }
	public NavMeshCollectGeometry useGeometry { get; set; }
	public int defaultArea { get; set; }
	public bool ignoreNavMeshAgent { get; set; }
	public bool ignoreNavMeshObstacle { get; set; }
	public bool overrideTileSize { get; set; }
	public int tileSize { get; set; }
	public bool overrideVoxelSize { get; set; }
	public float voxelSize { get; set; }
	public bool buildHeightMesh { get; set; }
	public NavMeshData navMeshData { get; set; }
	public static List<NavMeshSurface> activeSurfaces { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	public void set_UpdateOnTransformChanged(bool value) { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public int get_agentTypeID() { }

	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0
	public void set_agentTypeID(int value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public CollectObjects get_collectObjects() { }

	// RVA: 0x69CC40 Offset: 0x69C040 VA: 0x18069CC40
	public void set_collectObjects(CollectObjects value) { }

	// RVA: 0x106F490 Offset: 0x106E890 VA: 0x18106F490
	public Vector3 get_size() { }

	// RVA: 0x106F670 Offset: 0x106EA70 VA: 0x18106F670
	public void set_size(Vector3 value) { }

	// RVA: 0x12CB700 Offset: 0x12CAB00 VA: 0x1812CB700
	public Vector3 get_center() { }

	// RVA: 0x12CB720 Offset: 0x12CAB20 VA: 0x1812CB720
	public void set_center(Vector3 value) { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	public LayerMask get_layerMask() { }

	// RVA: 0x8B1150 Offset: 0x8B0550 VA: 0x1808B1150
	public void set_layerMask(LayerMask value) { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	public NavMeshCollectGeometry get_useGeometry() { }

	// RVA: 0x6B9860 Offset: 0x6B8C60 VA: 0x1806B9860
	public void set_useGeometry(NavMeshCollectGeometry value) { }

	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public int get_defaultArea() { }

	// RVA: 0x8B0DE0 Offset: 0x8B01E0 VA: 0x1808B0DE0
	public void set_defaultArea(int value) { }

	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	public bool get_ignoreNavMeshAgent() { }

	// RVA: 0x4B9470 Offset: 0x4B8870 VA: 0x1804B9470
	public void set_ignoreNavMeshAgent(bool value) { }

	// RVA: 0xB9D230 Offset: 0xB9C630 VA: 0x180B9D230
	public bool get_ignoreNavMeshObstacle() { }

	// RVA: 0x82B450 Offset: 0x82A850 VA: 0x18082B450
	public void set_ignoreNavMeshObstacle(bool value) { }

	// RVA: 0xB9D220 Offset: 0xB9C620 VA: 0x180B9D220
	public bool get_overrideTileSize() { }

	// RVA: 0x1233220 Offset: 0x1232620 VA: 0x181233220
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x5B35A0 Offset: 0x5B29A0 VA: 0x1805B35A0
	public int get_tileSize() { }

	// RVA: 0x5B3950 Offset: 0x5B2D50 VA: 0x1805B3950
	public void set_tileSize(int value) { }

	// RVA: 0x778E40 Offset: 0x778240 VA: 0x180778E40
	public bool get_overrideVoxelSize() { }

	// RVA: 0xE63B70 Offset: 0xE62F70 VA: 0x180E63B70
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0xFCA200 Offset: 0xFC9600 VA: 0x180FCA200
	public float get_voxelSize() { }

	// RVA: 0x12CB730 Offset: 0x12CAB30 VA: 0x1812CB730
	public void set_voxelSize(float value) { }

	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_buildHeightMesh() { }

	// RVA: 0x5ABEA0 Offset: 0x5AB2A0 VA: 0x1805ABEA0
	public void set_buildHeightMesh(bool value) { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public NavMeshData get_navMeshData() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_navMeshData(NavMeshData value) { }

	// RVA: 0x12CB6A0 Offset: 0x12CAAA0 VA: 0x1812CB6A0
	public static List<NavMeshSurface> get_activeSurfaces() { }

	// RVA: 0x12CA880 Offset: 0x12C9C80 VA: 0x1812CA880
	private void OnEnable() { }

	// RVA: 0x12CA700 Offset: 0x12C9B00 VA: 0x1812CA700
	private void OnDisable() { }

	// RVA: 0x12C8250 Offset: 0x12C7650 VA: 0x1812C8250
	public void AddData() { }

	// RVA: 0x12CAC00 Offset: 0x12CA000 VA: 0x1812CAC00
	public void RemoveData() { }

	// RVA: 0x12CA040 Offset: 0x12C9440 VA: 0x1812CA040
	public NavMeshBuildSettings GetBuildSettings() { }

	// RVA: 0x12C8A60 Offset: 0x12C7E60 VA: 0x1812C8A60
	public void BuildNavMesh() { }

	// RVA: 0x12C8AE0 Offset: 0x12C7EE0 VA: 0x1812C8AE0
	public void BuildNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds, NavMeshBuildSettings buildSettings) { }

	// RVA: 0x12CAF80 Offset: 0x12CA380 VA: 0x1812CAF80
	public AsyncOperation UpdateNavMesh() { }

	// RVA: 0x12CB1B0 Offset: 0x12CA5B0 VA: 0x1812CB1B0
	public AsyncOperation UpdateNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds) { }

	// RVA: 0x12CAFB0 Offset: 0x12CA3B0 VA: 0x1812CAFB0
	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

	// RVA: 0x12CAA60 Offset: 0x12C9E60 VA: 0x1812CAA60
	private static void Register(NavMeshSurface surface) { }

	// RVA: 0x12CAC20 Offset: 0x12CA020 VA: 0x1812CAC20
	private static void Unregister(NavMeshSurface surface) { }

	// RVA: 0x12CAD50 Offset: 0x12CA150 VA: 0x1812CAD50
	private static void UpdateActive() { }

	// RVA: 0x12C83E0 Offset: 0x12C77E0 VA: 0x1812C83E0
	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) { }

	// RVA: 0x12C9840 Offset: 0x12C8C40 VA: 0x1812C9840
	private List<NavMeshBuildSource> CollectSources() { }

	// RVA: 0x12C81A0 Offset: 0x12C75A0 VA: 0x1812C81A0
	private static Vector3 Abs(Vector3 v) { }

	// RVA: 0x12CA190 Offset: 0x12C9590 VA: 0x1812CA190
	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	// RVA: 0x12C8DF0 Offset: 0x12C81F0 VA: 0x1812C8DF0
	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	// RVA: 0x12CA5C0 Offset: 0x12C99C0 VA: 0x1812CA5C0
	private bool HasTransformChanged() { }

	// RVA: 0x12CAE20 Offset: 0x12CA220 VA: 0x1812CAE20
	private void UpdateDataIfTransformChanged() { }

	// RVA: 0x12CB570 Offset: 0x12CA970 VA: 0x1812CB570
	public void .ctor() { }

	// RVA: 0x12CB510 Offset: 0x12CA910 VA: 0x1812CB510
	private static void .cctor() { }

}

private sealed class NavMeshSurface.<>c // TypeDefIndex: 8148
{	// Fields
	public static readonly NavMeshSurface.<>c <>9; // 0x0
	public static Predicate<NavMeshModifierVolume> <>9__83_0; // 0x8
	public static Predicate<NavMeshModifier> <>9__84_0; // 0x10
	public static Predicate<NavMeshBuildSource> <>9__84_1; // 0x18
	public static Predicate<NavMeshBuildSource> <>9__84_2; // 0x20

	// Methods

	// RVA: 0x12D7DC0 Offset: 0x12D71C0 VA: 0x1812D7DC0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x12D7BD0 Offset: 0x12D6FD0 VA: 0x1812D7BD0
	internal bool <AppendModifierVolumes>b__83_0(NavMeshModifierVolume x) { }

	// RVA: 0x12D7BD0 Offset: 0x12D6FD0 VA: 0x1812D7BD0
	internal bool <CollectSources>b__84_0(NavMeshModifier x) { }

	// RVA: 0x12D7C00 Offset: 0x12D7000 VA: 0x1812D7C00
	internal bool <CollectSources>b__84_1(NavMeshBuildSource x) { }

	// RVA: 0x12D7CE0 Offset: 0x12D70E0 VA: 0x1812D7CE0
	internal bool <CollectSources>b__84_2(NavMeshBuildSource x) { }

}

public class NavMeshTester : MonoBehaviour // TypeDefIndex: 8962
{	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

