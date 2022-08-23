public abstract class PrefabAttribute : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11326
{	public Vector3 worldPosition; // 0x18
	public Quaternion worldRotation; // 0x24
	public Vector3 worldForward; // 0x34
	public Vector3 localPosition; // 0x40
	public Vector3 localScale; // 0x4C
	public Quaternion localRotation; // 0x58
	public string fullName; // 0x68
	public string hierachyName; // 0x70
	public uint prefabID; // 0x78
	public int instanceID; // 0x7C
	public PrefabAttribute.Library prefabAttribute; // 0x80
	public GameManager gameManager; // 0x88
	public bool isServer; // 0x90
	public static PrefabAttribute.Library client; // 0x0

	public bool isClient { get; }


	public bool get_isClient() { }

	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	protected virtual void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	protected abstract Type GetIndexedType();

	public static bool op_Equality(PrefabAttribute x, PrefabAttribute y) { }

	public static bool op_Inequality(PrefabAttribute x, PrefabAttribute y) { }

	public override bool Equals(object o) { }

	public override int GetHashCode() { }

	public static bool op_Implicit(PrefabAttribute exists) { }

	internal static bool ComparePrefabAttribute(PrefabAttribute x, PrefabAttribute y) { }

	public override string ToString() { }

	protected void .ctor() { }

	private static void .cctor() { }

}

public class PrefabAttribute.AttributeCollection // TypeDefIndex: 11327
{	private Dictionary<Type, List<PrefabAttribute>> attributes; // 0x10
	private Dictionary<Type, object> cache; // 0x18


	internal List<PrefabAttribute> Find(Type t) { }

	public T[] Find<T>() { }
	/* GenericInstMethod :
	|
	|-PrefabAttribute.AttributeCollection.Find<object>
	*/

	public void Add(PrefabAttribute attribute) { }

	public void .ctor() { }

}

public class PrefabAttribute.Library // TypeDefIndex: 11328
{	public bool clientside; // 0x10
	public bool serverside; // 0x11
	private Dictionary<uint, PrefabAttribute.AttributeCollection> prefabs; // 0x18


	public void .ctor(bool clientside, bool serverside) { }

	public PrefabAttribute.AttributeCollection Find(uint prefabID, bool warmup = True) { }

	public T Find<T>(uint prefabID) { }
	/* GenericInstMethod :
	|
	|-PrefabAttribute.Library.Find<CardGameSounds>
	|-PrefabAttribute.Library.Find<Construction>
	|-PrefabAttribute.Library.Find<DecorSocketFemale>
	|-PrefabAttribute.Library.Find<DecorSocketMale>
	|-PrefabAttribute.Library.Find<DeployShell>
	|-PrefabAttribute.Library.Find<Deployable>
	|-PrefabAttribute.Library.Find<DiscoFloorColourLookups>
	|-PrefabAttribute.Library.Find<PathSequence>
	|-PrefabAttribute.Library.Find<PetCommandList>
	|-PrefabAttribute.Library.Find<PlayerModelCinematicList>
	|-PrefabAttribute.Library.Find<PrefabInformation>
	|-PrefabAttribute.Library.Find<RigidbodyInfo>
	|-PrefabAttribute.Library.Find<object>
	|-PrefabAttribute.Library.Find<Upkeep>
	*/

	public T[] FindAll<T>(uint prefabID) { }
	/* GenericInstMethod :
	|
	|-PrefabAttribute.Library.FindAll<AttractionPoint>
	|-PrefabAttribute.Library.FindAll<ConditionalModel>
	|-PrefabAttribute.Library.FindAll<DecalComponent>
	|-PrefabAttribute.Library.FindAll<DecorComponent>
	|-PrefabAttribute.Library.FindAll<DeployVolume>
	|-PrefabAttribute.Library.FindAll<Gibbable>
	|-PrefabAttribute.Library.FindAll<Socket_Base>
	|-PrefabAttribute.Library.FindAll<object>
	|-PrefabAttribute.Library.FindAll<TerrainAnchor>
	|-PrefabAttribute.Library.FindAll<TerrainCheck>
	|-PrefabAttribute.Library.FindAll<TerrainFilter>
	|-PrefabAttribute.Library.FindAll<TerrainModifier>
	|-PrefabAttribute.Library.FindAll<TerrainPlacement>
	|-PrefabAttribute.Library.FindAll<WaterCheck>
	*/

	public void Add(uint prefabID, PrefabAttribute attribute) { }

	public void Invalidate(uint prefabID) { }

}

