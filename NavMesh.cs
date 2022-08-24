public sealed class NavMeshPath // TypeDefIndex: 4444
{

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 

internal class <Module> 

[NativeHeaderAttribute] 
[MovedFromAttribute] 
public sealed class NavMeshPath 
	internal IntPtr m_Ptr; 
	internal Vector3[] m_Corners; 

}

public static class NavMeshBuilder // TypeDefIndex: 4445
{

	public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results) { }

	private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation) { }

	private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds) { }

	private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds) { }

	private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups) { }

	private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

	private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds) { }

}

public sealed class NavMeshAgent : Behaviour // TypeDefIndex: 4446
{
	public bool isOnOffMeshLink { get; }


	[NativeNameAttribute] 
	public bool get_isOnOffMeshLink() { }

}

public struct NavMeshHit // TypeDefIndex: 4448
{

[MovedFromAttribute] 
public struct NavMeshHit 
	private Vector3 m_Position; 
	private Vector3 m_Normal; 
	private float m_Distance; 
	private int m_Mask; 
	private int m_Hit; 

	public Vector3 position { get; }
	public Vector3 normal { get; }


	public Vector3 get_position() { }

	public Vector3 get_normal() { }

}

public sealed class NavMeshData : Object // TypeDefIndex: 4449
{
	public Vector3 position { set; }
	public Quaternion rotation { set; }


	public void .ctor(int agentTypeID) { }

	[StaticAccessorAttribute] 
	private static void Internal_Create(NavMeshData mono, int agentTypeID) { }

	public void set_position(Vector3 value) { }

	public void set_rotation(Quaternion value) { }

	private void set_position_Injected(ref Vector3 value) { }

	private void set_rotation_Injected(ref Quaternion value) { }

}

public struct NavMeshDataInstance // TypeDefIndex: 4450
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private int <id>k__BackingField; 

	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }


	public bool get_valid() { }

	[CompilerGeneratedAttribute] 
	internal int get_id() { }

	[CompilerGeneratedAttribute] 
	internal void set_id(int value) { }

	public void Remove() { }

	public void set_owner(Object value) { }

}

public struct NavMeshLinkData // TypeDefIndex: 4451
{
	private Vector3 m_StartPosition; 
	private Vector3 m_EndPosition; 
	private float m_CostModifier; 
	private int m_Bidirectional; 
	private float m_Width; 
	private int m_Area; 
	private int m_AgentTypeID; 

	public Vector3 startPosition { set; }
	public Vector3 endPosition { set; }
	public float costModifier { set; }
	public bool bidirectional { set; }
	public float width { set; }
	public int area { set; }
	public int agentTypeID { set; }


	public void set_startPosition(Vector3 value) { }

	public void set_endPosition(Vector3 value) { }

	public void set_costModifier(float value) { }

	public void set_bidirectional(bool value) { }

	public void set_width(float value) { }

	public void set_area(int value) { }

	public void set_agentTypeID(int value) { }

}

public struct NavMeshLinkInstance // TypeDefIndex: 4452
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private int <id>k__BackingField; 

	public bool valid { get; }
	internal int id { get; set; }
	public Object owner { set; }


	public bool get_valid() { }

	[CompilerGeneratedAttribute] 
	internal int get_id() { }

	[CompilerGeneratedAttribute] 
	internal void set_id(int value) { }

	public void Remove() { }

	public void set_owner(Object value) { }

}

public struct NavMeshQueryFilter // TypeDefIndex: 4453
{
	private const int k_AreaCostElementCount = 32;
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private float[] <costs>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private int <areaMask>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private int <agentTypeID>k__BackingField; 

}

public static class NavMesh // TypeDefIndex: 4454
{
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; 


	[RequiredByNativeCodeAttribute] 
	private static void Internal_CallOnNavMeshPreUpdate() { }

	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData) { }

	public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] 
	[NativeNameAttribute] 
	internal static bool IsValidNavMeshDataHandle(int handle) { }

	[StaticAccessorAttribute] 
	internal static bool IsValidLinkHandle(int handle) { }

	[StaticAccessorAttribute] 
	[NativeNameAttribute] 
	internal static bool InternalSetOwner(int dataID, int ownerID) { }

	[StaticAccessorAttribute] 
	[NativeNameAttribute] 
	internal static bool InternalSetLinkOwner(int linkID, int ownerID) { }

	[StaticAccessorAttribute] 
	[NativeNameAttribute] 
	internal static int AddNavMeshDataInternal(NavMeshData navMeshData) { }

	[StaticAccessorAttribute] 
	[NativeNameAttribute] 
	internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] 
	[StaticAccessorAttribute] 
	internal static void RemoveNavMeshDataInternal(int handle) { }

	public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[NativeNameAttribute] 
	[StaticAccessorAttribute] 
	internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation) { }

	[StaticAccessorAttribute] 
	[NativeNameAttribute] 
	internal static void RemoveLinkInternal(int handle) { }

	public static NavMeshBuildSettings GetSettingsByID(int agentTypeID) { }

	private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation) { }

	private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation) { }

	private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret) { }

}

public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 4455
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum NavMeshBuildSourceShape // TypeDefIndex: 4456
{
	public int value__; 
	public const NavMeshBuildSourceShape Mesh = 0;
	public const NavMeshBuildSourceShape Terrain = 1;
	public const NavMeshBuildSourceShape Box = 2;
	public const NavMeshBuildSourceShape Sphere = 3;
	public const NavMeshBuildSourceShape Capsule = 4;
	public const NavMeshBuildSourceShape ModifierBox = 5;

}

public enum NavMeshCollectGeometry // TypeDefIndex: 4457
{
	public int value__; 
	public const NavMeshCollectGeometry RenderMeshes = 0;
	public const NavMeshCollectGeometry PhysicsColliders = 1;

}

public struct NavMeshBuildSource // TypeDefIndex: 4458
{
	private Matrix4x4 m_Transform; 
	private Vector3 m_Size; 
	private NavMeshBuildSourceShape m_Shape; 
	private int m_Area; 
	private int m_InstanceID; 
	private int m_ComponentID; 

	public Matrix4x4 transform { get; set; }
	public Vector3 size { get; set; }
	public NavMeshBuildSourceShape shape { get; set; }
	public int area { set; }
	public Object sourceObject { get; set; }
	public Component component { get; }


	public Matrix4x4 get_transform() { }

	public void set_transform(Matrix4x4 value) { }

	public Vector3 get_size() { }

	public void set_size(Vector3 value) { }

	public NavMeshBuildSourceShape get_shape() { }

	public void set_shape(NavMeshBuildSourceShape value) { }

	public void set_area(int value) { }

	public Object get_sourceObject() { }

	public void set_sourceObject(Object value) { }

	public Component get_component() { }

	[StaticAccessorAttribute] 
	private static Component InternalGetComponent(int instanceID) { }

	[StaticAccessorAttribute] 
	private static Object InternalGetObject(int instanceID) { }

}

public struct NavMeshBuildMarkup // TypeDefIndex: 4459
{
	private int m_OverrideArea; 
	private int m_Area; 
	private int m_IgnoreFromBuild; 
	private int m_InstanceID; 

	public bool overrideArea { set; }
	public int area { set; }
	public bool ignoreFromBuild { set; }
	public Transform root { set; }


	public void set_overrideArea(bool value) { }

	public void set_area(int value) { }

	public void set_ignoreFromBuild(bool value) { }

	public void set_root(Transform value) { }

}

public struct NavMeshBuildSettings // TypeDefIndex: 4460
{
	private int m_AgentTypeID; 
	private float m_AgentRadius; 
	private float m_AgentHeight; 
	private float m_AgentSlope; 
	private float m_AgentClimb; 
	private float m_LedgeDropHeight; 
	private float m_MaxJumpAcrossDistance; 
	private float m_MinRegionArea; 
	private int m_OverrideVoxelSize; 
	private float m_VoxelSize; 
	private int m_OverrideTileSize; 
	private int m_TileSize; 
	private int m_AccuratePlacement; 
	private NavMeshBuildDebugSettings m_Debug; 

	public int agentTypeID { get; set; }
	public bool overrideVoxelSize { set; }
	public float voxelSize { set; }
	public bool overrideTileSize { set; }
	public int tileSize { set; }


	public int get_agentTypeID() { }

	public void set_agentTypeID(int value) { }

	public void set_overrideVoxelSize(bool value) { }

	public void set_voxelSize(float value) { }

	public void set_overrideTileSize(bool value) { }

	public void set_tileSize(int value) { }

}

public struct NavMeshBuildDebugSettings // TypeDefIndex: 4461
{
	private byte m_Flags; 

}

public class NavMeshLink : MonoBehaviour // TypeDefIndex: 8143
{
	[CompilerGeneratedAttribute] 
	private bool <UpdateOnTransformChanged>k__BackingField; 
	[SerializeField] 
	private int m_AgentTypeID; 
	[SerializeField] 
	private Vector3 m_StartPoint; 
	[SerializeField] 
	private Vector3 m_EndPoint; 
	[SerializeField] 
	private float m_Width; 
	[SerializeField] 
	private int m_CostModifier; 
	[SerializeField] 
	private bool m_Bidirectional; 
	[SerializeField] 
	private bool m_AutoUpdatePosition; 
	[SerializeField] 
	private int m_Area; 
	private NavMeshLinkInstance m_LinkInstance; 
	private Vector3 m_LastPosition; 
	private Quaternion m_LastRotation; 
	private static readonly List<NavMeshLink> s_Tracked; 

	public bool UpdateOnTransformChanged { get; set; }
	public int agentTypeID { get; set; }
	public Vector3 startPoint { get; set; }
	public Vector3 endPoint { get; set; }
	public float width { get; set; }
	public int costModifier { get; set; }
	public bool bidirectional { get; set; }
	public bool autoUpdate { get; set; }
	public int area { get; set; }


	[CompilerGeneratedAttribute] 
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] 
	public void set_UpdateOnTransformChanged(bool value) { }

	public int get_agentTypeID() { }

	public void set_agentTypeID(int value) { }

	public Vector3 get_startPoint() { }

	public void set_startPoint(Vector3 value) { }

	public Vector3 get_endPoint() { }

	public void set_endPoint(Vector3 value) { }

	public float get_width() { }

	public void set_width(float value) { }

	public int get_costModifier() { }

	public void set_costModifier(int value) { }

	public bool get_bidirectional() { }

	public void set_bidirectional(bool value) { }

	public bool get_autoUpdate() { }

	public void set_autoUpdate(bool value) { }

	public int get_area() { }

	public void set_area(int value) { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void UpdateLink() { }

	private static void AddTracking(NavMeshLink link) { }

	private static void RemoveTracking(NavMeshLink link) { }

	private void SetAutoUpdate(bool value) { }

	private void AddLink() { }

	private bool HasTransformChanged() { }

	private void OnDidApplyAnimationProperties() { }

	private static void UpdateTrackedInstances() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class NavMeshModifier : MonoBehaviour // TypeDefIndex: 8144
{
	[SerializeField] 
	private bool m_OverrideArea; 
	[SerializeField] 
	private int m_Area; 
	[SerializeField] 
	private bool m_IgnoreFromBuild; 
	[SerializeField] 
	private List<int> m_AffectedAgents; 
	private static readonly List<NavMeshModifier> s_NavMeshModifiers; 

	public bool overrideArea { get; set; }
	public int area { get; set; }
	public bool ignoreFromBuild { get; set; }
	public static List<NavMeshModifier> activeModifiers { get; }


	public bool get_overrideArea() { }

	public void set_overrideArea(bool value) { }

	public int get_area() { }

	public void set_area(int value) { }

	public bool get_ignoreFromBuild() { }

	public void set_ignoreFromBuild(bool value) { }

	public static List<NavMeshModifier> get_activeModifiers() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public bool AffectsAgentType(int agentTypeID) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class NavMeshModifierVolume : MonoBehaviour // TypeDefIndex: 8145
{
	[SerializeField] 
	private Vector3 m_Size; 
	[SerializeField] 
	private Vector3 m_Center; 
	[SerializeField] 
	private int m_Area; 
	[SerializeField] 
	private List<int> m_AffectedAgents; 
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; 

	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public int area { get; set; }
	public static List<NavMeshModifierVolume> activeModifiers { get; }


	public Vector3 get_size() { }

	public void set_size(Vector3 value) { }

	public Vector3 get_center() { }

	public void set_center(Vector3 value) { }

	public int get_area() { }

	public void set_area(int value) { }

	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public bool AffectsAgentType(int agentTypeID) { }

	public void AddAgentType(int agentTypeID) { }

	public void ClearAgentTypes() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 8147
{
	[CompilerGeneratedAttribute] 
	private bool <UpdateOnTransformChanged>k__BackingField; 
	[SerializeField] 
	private int m_AgentTypeID; 
	[SerializeField] 
	private CollectObjects m_CollectObjects; 
	[SerializeField] 
	private Vector3 m_Size; 
	[SerializeField] 
	private Vector3 m_Center; 
	[SerializeField] 
	private LayerMask m_LayerMask; 
	[SerializeField] 
	private NavMeshCollectGeometry m_UseGeometry; 
	[SerializeField] 
	private int m_DefaultArea; 
	[SerializeField] 
	private bool m_IgnoreNavMeshAgent; 
	[SerializeField] 
	private bool m_IgnoreNavMeshObstacle; 
	[SerializeField] 
	private bool m_OverrideTileSize; 
	[SerializeField] 
	private int m_TileSize; 
	[SerializeField] 
	private bool m_OverrideVoxelSize; 
	[SerializeField] 
	private float m_VoxelSize; 
	[SerializeField] 
	private bool m_BuildHeightMesh; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private NavMeshData m_NavMeshData; 
	private NavMeshDataInstance m_NavMeshDataInstance; 
	private Vector3 m_LastPosition; 
	private Quaternion m_LastRotation; 
	private static readonly List<NavMeshSurface> s_NavMeshSurfaces; 

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


	[CompilerGeneratedAttribute] 
	public bool get_UpdateOnTransformChanged() { }

	[CompilerGeneratedAttribute] 
	public void set_UpdateOnTransformChanged(bool value) { }

	public int get_agentTypeID() { }

	public void set_agentTypeID(int value) { }

	public CollectObjects get_collectObjects() { }

	public void set_collectObjects(CollectObjects value) { }

	public Vector3 get_size() { }

	public void set_size(Vector3 value) { }

	public Vector3 get_center() { }

	public void set_center(Vector3 value) { }

	public LayerMask get_layerMask() { }

	public void set_layerMask(LayerMask value) { }

	public NavMeshCollectGeometry get_useGeometry() { }

	public void set_useGeometry(NavMeshCollectGeometry value) { }

	public int get_defaultArea() { }

	public void set_defaultArea(int value) { }

	public bool get_ignoreNavMeshAgent() { }

	public void set_ignoreNavMeshAgent(bool value) { }

	public bool get_ignoreNavMeshObstacle() { }

	public void set_ignoreNavMeshObstacle(bool value) { }

	public bool get_overrideTileSize() { }

	public void set_overrideTileSize(bool value) { }

	public int get_tileSize() { }

	public void set_tileSize(int value) { }

	public bool get_overrideVoxelSize() { }

	public void set_overrideVoxelSize(bool value) { }

	public float get_voxelSize() { }

	public void set_voxelSize(float value) { }

	public bool get_buildHeightMesh() { }

	public void set_buildHeightMesh(bool value) { }

	public NavMeshData get_navMeshData() { }

	public void set_navMeshData(NavMeshData value) { }

	public static List<NavMeshSurface> get_activeSurfaces() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void AddData() { }

	public void RemoveData() { }

	public NavMeshBuildSettings GetBuildSettings() { }

	public void BuildNavMesh() { }

	public void BuildNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds, NavMeshBuildSettings buildSettings) { }

	public AsyncOperation UpdateNavMesh() { }

	public AsyncOperation UpdateNavMesh(List<NavMeshBuildSource> sources, bool calculateWorldBounds) { }

	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

	private static void Register(NavMeshSurface surface) { }

	private static void Unregister(NavMeshSurface surface) { }

	private static void UpdateActive() { }

	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) { }

	private List<NavMeshBuildSource> CollectSources() { }

	private static Vector3 Abs(Vector3 v) { }

	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	private bool HasTransformChanged() { }

	private void UpdateDataIfTransformChanged() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class NavMeshSurface.<>c // TypeDefIndex: 8148
{
	public static readonly NavMeshSurface.<>c <>9; 
	public static Predicate<NavMeshModifierVolume> <>9__83_0; 
	public static Predicate<NavMeshModifier> <>9__84_0; 
	public static Predicate<NavMeshBuildSource> <>9__84_1; 
	public static Predicate<NavMeshBuildSource> <>9__84_2; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <AppendModifierVolumes>b__83_0(NavMeshModifierVolume x) { }

	internal bool <CollectSources>b__84_0(NavMeshModifier x) { }

	internal bool <CollectSources>b__84_1(NavMeshBuildSource x) { }

	internal bool <CollectSources>b__84_2(NavMeshBuildSource x) { }

}

public class NavMeshTester : MonoBehaviour // TypeDefIndex: 8962
{

	public void .ctor() { }

}

