public abstract class PrefabAttribute : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11326
{	// Fields
	public Vector3 worldPosition; // 0x18
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

	// Properties
	public bool isClient { get; }

	// Methods

	// RVA: 0x9811F0 Offset: 0x9805F0 VA: 0x1809811F0
	public bool get_isClient() { }

	// RVA: 0x980CF0 Offset: 0x9800F0 VA: 0x180980CF0 Slot: 5
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	protected virtual void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract Type GetIndexedType();

	// RVA: 0x981200 Offset: 0x980600 VA: 0x180981200
	public static bool op_Equality(PrefabAttribute x, PrefabAttribute y) { }

	// RVA: 0x9812A0 Offset: 0x9806A0 VA: 0x1809812A0
	public static bool op_Inequality(PrefabAttribute x, PrefabAttribute y) { }

	// RVA: 0x980C00 Offset: 0x980000 VA: 0x180980C00 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x980CC0 Offset: 0x9800C0 VA: 0x180980CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x6B8100 Offset: 0x6B7500 VA: 0x1806B8100
	public static bool op_Implicit(PrefabAttribute exists) { }

	// RVA: 0x980BB0 Offset: 0x97FFB0 VA: 0x180980BB0
	internal static bool ComparePrefabAttribute(PrefabAttribute x, PrefabAttribute y) { }

	// RVA: 0x981100 Offset: 0x980500 VA: 0x180981100 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

	// RVA: 0x981140 Offset: 0x980540 VA: 0x180981140
	private static void .cctor() { }

}

public class PrefabAttribute.AttributeCollection // TypeDefIndex: 11327
{	// Fields
	private Dictionary<Type, List<PrefabAttribute>> attributes; // 0x10
	private Dictionary<Type, object> cache; // 0x18

	// Methods

	// RVA: 0x96C790 Offset: 0x96BB90 VA: 0x18096C790
	internal List<PrefabAttribute> Find(Type t) { }

	// RVA: -1 Offset: -1
	public T[] Find<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9E290 Offset: 0x1A9D690 VA: 0x181A9E290
	|-PrefabAttribute.AttributeCollection.Find<object>
	*/

	// RVA: 0x96C610 Offset: 0x96BA10 VA: 0x18096C610
	public void Add(PrefabAttribute attribute) { }

	// RVA: 0x96C850 Offset: 0x96BC50 VA: 0x18096C850
	public void .ctor() { }

}

public class PrefabAttribute.Library // TypeDefIndex: 11328
{	// Fields
	public bool clientside; // 0x10
	public bool serverside; // 0x11
	private Dictionary<uint, PrefabAttribute.AttributeCollection> prefabs; // 0x18

	// Methods

	// RVA: 0x96CD70 Offset: 0x96C170 VA: 0x18096CD70
	public void .ctor(bool clientside, bool serverside) { }

	// RVA: 0x96CB80 Offset: 0x96BF80 VA: 0x18096CB80
	public PrefabAttribute.AttributeCollection Find(uint prefabID, bool warmup = True) { }

	// RVA: -1 Offset: -1
	public T Find<T>(uint prefabID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EAF50 Offset: 0x5EA350 VA: 0x1805EAF50
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

	// RVA: -1 Offset: -1
	public T[] FindAll<T>(uint prefabID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2730 Offset: 0x1AA1B30 VA: 0x181AA2730
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

	// RVA: 0x96C8F0 Offset: 0x96BCF0 VA: 0x18096C8F0
	public void Add(uint prefabID, PrefabAttribute attribute) { }

	// RVA: 0x96CD10 Offset: 0x96C110 VA: 0x18096CD10
	public void Invalidate(uint prefabID) { }

}

