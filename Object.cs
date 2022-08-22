public class Object // TypeDefIndex: 383
{
	public virtual bool Equals(object obj) { }

	public static bool Equals(object objA, object objB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	protected virtual void Finalize() { }

	public virtual int GetHashCode() { }

	public Type GetType() { }

	protected object MemberwiseClone() { }

	public virtual string ToString() { }

	internal static int InternalGetHashCode(object o) { }

	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	private void FieldSetter(string typeName, string fieldName, object val) { }

}

public class Object // TypeDefIndex: 3535
{	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	public string name { get; set; }
	public HideFlags hideFlags { get; set; }


	public int GetInstanceID() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public static bool op_Implicit(Object exists) { }

	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	private static bool IsNativeObjectAlive(Object o) { }

	private IntPtr GetCachedPtr() { }

	public string get_name() { }

	public void set_name(string value) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	public static Object Instantiate(Object original) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF560 Offset: 0x14BE960 VA: 0x1814BF560
	|-Object.Instantiate<ERMarkerExt>
	|-Object.Instantiate<ERSOMarkerExt>
	|-Object.Instantiate<ERSORoadExt>
	|-Object.Instantiate<ItemSearchEntry>
	|-Object.Instantiate<TechTreeDialog>
	|-Object.Instantiate<TechTreeEntry>
	|-Object.Instantiate<TechTreeGroup>
	|-Object.Instantiate<TechTreeLine>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<Material>
	|-Object.Instantiate<Mesh>
	|-Object.Instantiate<ParticleSystem>
	|-Object.Instantiate<PostProcessEffectSettings>
	|-Object.Instantiate<Texture2D>
	|-Object.Instantiate<Transform>
	|-Object.Instantiate<Dropdown.DropdownItem>
	|-Object.Instantiate<object>
	*/

	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF8A0 Offset: 0x14BECA0 VA: 0x1814BF8A0
	|-Object.Instantiate<ArcadeEntity>
	|-Object.Instantiate<ArcadeEntityController>
	|-Object.Instantiate<BaseArcadeGame>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF7B0 Offset: 0x14BEBB0 VA: 0x1814BF7B0
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	public static T Instantiate<T>(T original, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF670 Offset: 0x14BEA70 VA: 0x1814BF670
	|-Object.Instantiate<ContactsEntry>
	|-Object.Instantiate<HttpImage>
	|-Object.Instantiate<RustText>
	|-Object.Instantiate<SleepingBagButton>
	|-Object.Instantiate<SleepingBagClusterMapMarker>
	|-Object.Instantiate<SleepingBagMapMarker>
	|-Object.Instantiate<UIMapVendingMachineMarker>
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF6F0 Offset: 0x14BEAF0 VA: 0x1814BF6F0
	|-Object.Instantiate<object>
	*/

	[NativeMethodAttribute] // RVA: 0xC5D40 Offset: 0xC5140 VA: 0x1800C5D40
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void Destroy(Object obj) { }

	[NativeMethodAttribute] // RVA: 0xC6010 Offset: 0xC5410 VA: 0x1800C6010
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void DestroyImmediate(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6160 Offset: 0xC5560 VA: 0x1800C6160
	[TypeInferenceRuleAttribute] // RVA: 0xC6160 Offset: 0xC5560 VA: 0x1800C6160
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xC61F0 Offset: 0xC55F0 VA: 0x1800C61F0
	public static void DontDestroyOnLoad(Object target) { }

	public HideFlags get_hideFlags() { }

	public void set_hideFlags(HideFlags value) { }

	public static T[] FindObjectsOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2940 Offset: 0x1AA1D40 VA: 0x181AA2940
	|-Object.FindObjectsOfType<BaseEntity>
	|-Object.FindObjectsOfType<BenchmarkScene>
	|-Object.FindObjectsOfType<BlendedLoopEngineSound>
	|-Object.FindObjectsOfType<DamageRenderer>
	|-Object.FindObjectsOfType<GameSetup>
	|-Object.FindObjectsOfType<LaserBeam>
	|-Object.FindObjectsOfType<RendererBatch>
	|-Object.FindObjectsOfType<PropRenderer>
	|-Object.FindObjectsOfType<SingletonComponent>
	|-Object.FindObjectsOfType<Animator>
	|-Object.FindObjectsOfType<BoxCollider>
	|-Object.FindObjectsOfType<CapsuleCollider>
	|-Object.FindObjectsOfType<Collider>
	|-Object.FindObjectsOfType<LODGroup>
	|-Object.FindObjectsOfType<MeshCollider>
	|-Object.FindObjectsOfType<Object>
	|-Object.FindObjectsOfType<ParticleSystem>
	|-Object.FindObjectsOfType<Renderer>
	|-Object.FindObjectsOfType<Rigidbody>
	|-Object.FindObjectsOfType<SphereCollider>
	|-Object.FindObjectsOfType<Texture>
	|-Object.FindObjectsOfType<Transform>
	|-Object.FindObjectsOfType<WearableShadowLod>
	|-Object.FindObjectsOfType<object>
	*/

	public static T FindObjectOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF480 Offset: 0x14BE880 VA: 0x1814BF480
	|-Object.FindObjectOfType<Client>
	|-Object.FindObjectOfType<CursorManager>
	|-Object.FindObjectOfType<MainCamera>
	|-Object.FindObjectOfType<MusicManager>
	|-Object.FindObjectOfType<Performance>
	|-Object.FindObjectOfType<SoundManager>
	|-Object.FindObjectOfType<Terrain>
	|-Object.FindObjectOfType<WindZone>
	|-Object.FindObjectOfType<object>
	*/

	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9A30 Offset: 0xB8E30 VA: 0x1800B9A30
	public static Object FindObjectOfType(Type type) { }

	public override string ToString() { }

	public static bool op_Equality(Object x, Object y) { }

	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethodAttribute] // RVA: 0xC6330 Offset: 0xC5730 VA: 0x1800C6330
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[FreeFunctionAttribute] // RVA: 0xC6390 Offset: 0xC5790 VA: 0x1800C6390
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunctionAttribute] // RVA: 0xC6390 Offset: 0xC5790 VA: 0x1800C6390
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunctionAttribute] // RVA: 0xC6520 Offset: 0xC5920 VA: 0x1800C6520
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6520 Offset: 0xC5920 VA: 0x1800C6520
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6850 Offset: 0xC5C50 VA: 0x1800C6850
	private static string ToString(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC68F0 Offset: 0xC5CF0 VA: 0x1800C68F0
	private static string GetName(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC69B0 Offset: 0xC5DB0 VA: 0x1800C69B0
	private static void SetName(Object obj, string name) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC6B10 Offset: 0xC5F10 VA: 0x1800C6B10
	[FreeFunctionAttribute] // RVA: 0xC6B10 Offset: 0xC5F10 VA: 0x1800C6B10
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	public void .ctor() { }

	private static void .cctor() { }

	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

}

public class Object : IEnumerable<KeyValuePair<string, Value>>, IEnumerable // TypeDefIndex: 8141
{	private readonly IDictionary<string, Value> values; // 0x10

	public Value Item { get; set; }


	public void .ctor() { }

	public void .ctor(Object other) { }

	public bool ContainsKey(string key) { }

	public Value GetValue(string key) { }

	public string GetString(string key, string strDEFAULT = "") { }

	public double GetNumber(string key, double iDefault = 0) { }

	public int GetInt(string key, int iDefault = 0) { }

	public float GetFloat(string key, float iDefault = 0) { }

	public Object GetObject(string key) { }

	public bool GetBoolean(string key, bool bDefault = False) { }

	public Array GetArray(string key) { }

	public Value get_Item(string key) { }

	public void set_Item(string key, Value value) { }

	public void Add(string key, Value value) { }

	public void Add(KeyValuePair<string, Value> pair) { }

	public static Object Parse(string jsonString) { }

	private static int SkipWhitespace(string str, int pos) { }

	private static string ParseString(string str, ref int startPosition) { }

	private static double ParseNumber(string str, ref int startPosition) { }

	private static Object Fail(char expected, int position) { }

	private static Object Fail(string expected, int position) { }

	public override string ToString() { }

	public IEnumerator<KeyValuePair<string, Value>> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Clear() { }

	public void Remove(string key) { }

}

private enum Object.ParsingState // TypeDefIndex: 8142
{	public int value__; // 0x0
	public const Object.ParsingState Object = 0;
	public const Object.ParsingState Array = 1;
	public const Object.ParsingState EndObject = 2;
	public const Object.ParsingState EndArray = 3;
	public const Object.ParsingState Key = 4;
	public const Object.ParsingState Value = 5;
	public const Object.ParsingState KeyValueSeparator = 6;
	public const Object.ParsingState ValueSeparator = 7;
	public const Object.ParsingState String = 8;
	public const Object.ParsingState Number = 9;
	public const Object.ParsingState Boolean = 10;
	public const Object.ParsingState Null = 11;

}

