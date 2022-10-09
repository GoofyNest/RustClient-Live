public abstract class PrefabAttribute : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 13067
{
	public Vector3 worldPosition; 
	public Quaternion worldRotation; 
	public Vector3 worldForward; 
	public Vector3 localPosition; 
	public Vector3 localScale; 
	public Quaternion localRotation; 
	public string fullName; 
	public string hierachyName; 
	public uint prefabID; 
	public int instanceID; 
	public PrefabAttribute.Library prefabAttribute; 
	public GameManager gameManager; 
	public bool isServer; 
	public static PrefabAttribute.Library client; 

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

public class PrefabAttribute.AttributeCollection // TypeDefIndex: 13068
{
	private Dictionary<Type, List<PrefabAttribute>> attributes; 
	private Dictionary<Type, object> cache; 


	internal List<PrefabAttribute> Find(Type t) { }

	public T[] Find<T>() { }
	/* GenericInstMethod :
	|
	|-PrefabAttribute.AttributeCollection.Find<object>
	*/

	public void Add(PrefabAttribute attribute) { }

	public void .ctor() { }

}

public class PrefabAttribute.Library // TypeDefIndex: 13069
{
	public bool clientside; 
	public bool serverside; 
	private Dictionary<uint, PrefabAttribute.AttributeCollection> prefabs; 


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
	|-PrefabAttribute.Library.FindAll<BoundsCheck>
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

