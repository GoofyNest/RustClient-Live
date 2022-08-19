public class Object // TypeDefIndex: 383
{	// Methods

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170 Slot: 0
	public virtual bool Equals(object obj) { }

	// RVA: 0x167E4A0 Offset: 0x167D8A0 VA: 0x18167E4A0
	public static bool Equals(object objA, object objB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 1
	protected virtual void Finalize() { }

	// RVA: 0x167E4D0 Offset: 0x167D8D0 VA: 0x18167E4D0 Slot: 2
	public virtual int GetHashCode() { }

	// RVA: 0x167E4E0 Offset: 0x167D8E0 VA: 0x18167E4E0
	public Type GetType() { }

	// RVA: 0x167E4F0 Offset: 0x167D8F0 VA: 0x18167E4F0
	protected object MemberwiseClone() { }

	// RVA: 0x167E500 Offset: 0x167D900 VA: 0x18167E500 Slot: 3
	public virtual string ToString() { }

	// RVA: 0x167E4D0 Offset: 0x167D8D0 VA: 0x18167E4D0
	internal static int InternalGetHashCode(object o) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void FieldSetter(string typeName, string fieldName, object val) { }

}

public class Object // TypeDefIndex: 3535
{	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x18F30D0 Offset: 0x18F24D0 VA: 0x1818F30D0
	public int GetInstanceID() { }

	// RVA: 0x18F30C0 Offset: 0x18F24C0 VA: 0x1818F30C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18F2CE0 Offset: 0x18F20E0 VA: 0x1818F2CE0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x18F4560 Offset: 0x18F3960 VA: 0x1818F4560
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x18F29F0 Offset: 0x18F1DF0 VA: 0x1818F29F0
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x18F41B0 Offset: 0x18F35B0 VA: 0x1818F41B0
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x1818780 Offset: 0x1817B80 VA: 0x181818780
	private IntPtr GetCachedPtr() { }

	// RVA: 0x18F4380 Offset: 0x18F3780 VA: 0x1818F4380
	public string get_name() { }

	// RVA: 0x18F47E0 Offset: 0x18F3BE0 VA: 0x1818F47E0
	public void set_name(string value) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	// RVA: 0x18F3C30 Offset: 0x18F3030 VA: 0x1818F3C30
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	// RVA: 0x18F3430 Offset: 0x18F2830 VA: 0x1818F3430
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	// RVA: 0x18F3270 Offset: 0x18F2670 VA: 0x1818F3270
	public static Object Instantiate(Object original) { }

	[TypeInferenceRuleAttribute] // RVA: 0xC5A00 Offset: 0xC4E00 VA: 0x1800C5A00
	// RVA: 0x18F37B0 Offset: 0x18F2BB0 VA: 0x1818F37B0
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF7B0 Offset: 0x14BEBB0 VA: 0x1814BF7B0
	|-Object.Instantiate<GameObject>
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF6F0 Offset: 0x14BEAF0 VA: 0x1814BF6F0
	|-Object.Instantiate<object>
	*/

	[NativeMethodAttribute] // RVA: 0xC5D40 Offset: 0xC5140 VA: 0x1800C5D40
	// RVA: 0x18F2BE0 Offset: 0x18F1FE0 VA: 0x1818F2BE0
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F2C30 Offset: 0x18F2030 VA: 0x1818F2C30
	public static void Destroy(Object obj) { }

	[NativeMethodAttribute] // RVA: 0xC6010 Offset: 0xC5410 VA: 0x1800C6010
	// RVA: 0x18F2B90 Offset: 0x18F1F90 VA: 0x1818F2B90
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18F2B20 Offset: 0x18F1F20 VA: 0x1818F2B20
	public static void DestroyImmediate(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC6160 Offset: 0xC5560 VA: 0x1800C6160
	[TypeInferenceRuleAttribute] // RVA: 0xC6160 Offset: 0xC5560 VA: 0x1800C6160
	// RVA: 0x18F3080 Offset: 0x18F2480 VA: 0x1818F3080
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunctionAttribute] // RVA: 0xC61F0 Offset: 0xC55F0 VA: 0x1800C61F0
	// RVA: 0x18F2CA0 Offset: 0x18F20A0 VA: 0x1818F2CA0
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x18F4340 Offset: 0x18F3740 VA: 0x1818F4340
	public HideFlags get_hideFlags() { }

	// RVA: 0x18F47A0 Offset: 0x18F3BA0 VA: 0x1818F47A0
	public void set_hideFlags(HideFlags value) { }

	// RVA: -1 Offset: -1
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

	// RVA: -1 Offset: -1
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

	// RVA: 0x18F2980 Offset: 0x18F1D80 VA: 0x1818F2980
	private static void CheckNullArgument(object arg, string message) { }

	[TypeInferenceRuleAttribute] // RVA: 0xB9A30 Offset: 0xB8E30 VA: 0x1800B9A30
	// RVA: 0x18F2FF0 Offset: 0x18F23F0 VA: 0x1818F2FF0
	public static Object FindObjectOfType(Type type) { }

	// RVA: 0x18F4250 Offset: 0x18F3650 VA: 0x1818F4250 Slot: 3
	public override string ToString() { }

	// RVA: 0x18F43F0 Offset: 0x18F37F0 VA: 0x1818F43F0
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x18F4630 Offset: 0x18F3A30 VA: 0x1818F4630
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethodAttribute] // RVA: 0xC6330 Offset: 0xC5730 VA: 0x1800C6330
	// RVA: 0x18F3240 Offset: 0x18F2640 VA: 0x1818F3240
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[FreeFunctionAttribute] // RVA: 0xC6390 Offset: 0xC5790 VA: 0x1800C6390
	// RVA: 0x18F3F70 Offset: 0x18F3370 VA: 0x1818F3F70
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunctionAttribute] // RVA: 0xC6390 Offset: 0xC5790 VA: 0x1800C6390
	// RVA: 0x18F3F10 Offset: 0x18F3310 VA: 0x1818F3F10
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunctionAttribute] // RVA: 0xC6520 Offset: 0xC5920 VA: 0x1800C6520
	// RVA: 0x18F4120 Offset: 0x18F3520 VA: 0x1818F4120
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6520 Offset: 0xC5920 VA: 0x1800C6520
	// RVA: 0x18F4020 Offset: 0x18F3420 VA: 0x1818F4020
	private static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot) { }

	[FreeFunctionAttribute] // RVA: 0xC6850 Offset: 0xC5C50 VA: 0x1800C6850
	// RVA: 0x18F42C0 Offset: 0x18F36C0 VA: 0x1818F42C0
	private static string ToString(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC68F0 Offset: 0xC5CF0 VA: 0x1800C68F0
	// RVA: 0x18F3200 Offset: 0x18F2600 VA: 0x1818F3200
	private static string GetName(Object obj) { }

	[FreeFunctionAttribute] // RVA: 0xC69B0 Offset: 0xC5DB0 VA: 0x1800C69B0
	// RVA: 0x18F4200 Offset: 0x18F3600 VA: 0x1818F4200
	private static void SetName(Object obj, string name) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xC6B10 Offset: 0xC5F10 VA: 0x1800C6B10
	[FreeFunctionAttribute] // RVA: 0xC6B10 Offset: 0xC5F10 VA: 0x1800C6B10
	// RVA: 0x18F2FB0 Offset: 0x18F23B0 VA: 0x1818F2FB0
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x18F4300 Offset: 0x18F3700 VA: 0x1818F4300
	private static void .cctor() { }

	// RVA: 0x18F40C0 Offset: 0x18F34C0 VA: 0x1818F40C0
	private static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x18F3FB0 Offset: 0x18F33B0 VA: 0x1818F3FB0
	private static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

}

public class Object : IEnumerable<KeyValuePair<string, Value>>, IEnumerable // TypeDefIndex: 8141
{	// Fields
	private readonly IDictionary<string, Value> values; // 0x10

	// Properties
	public Value Item { get; set; }

	// Methods

	// RVA: 0x106DDF0 Offset: 0x106D1F0 VA: 0x18106DDF0
	public void .ctor() { }

	// RVA: 0x106DB40 Offset: 0x106CF40 VA: 0x18106DB40
	public void .ctor(Object other) { }

	// RVA: 0x106C2D0 Offset: 0x106B6D0 VA: 0x18106C2D0
	public bool ContainsKey(string key) { }

	// RVA: 0x106C6A0 Offset: 0x106BAA0 VA: 0x18106C6A0
	public Value GetValue(string key) { }

	// RVA: 0x106C610 Offset: 0x106BA10 VA: 0x18106C610
	public string GetString(string key, string strDEFAULT = "") { }

	// RVA: 0x106C4C0 Offset: 0x106B8C0 VA: 0x18106C4C0
	public double GetNumber(string key, double iDefault = 0) { }

	// RVA: 0x106C4A0 Offset: 0x106B8A0 VA: 0x18106C4A0
	public int GetInt(string key, int iDefault = 0) { }

	// RVA: 0x106C480 Offset: 0x106B880 VA: 0x18106C480
	public float GetFloat(string key, float iDefault = 0) { }

	// RVA: 0x106C590 Offset: 0x106B990 VA: 0x18106C590
	public Object GetObject(string key) { }

	// RVA: 0x106C3D0 Offset: 0x106B7D0 VA: 0x18106C3D0
	public bool GetBoolean(string key, bool bDefault = False) { }

	// RVA: 0x106C350 Offset: 0x106B750 VA: 0x18106C350
	public Array GetArray(string key) { }

	// RVA: 0x106DE60 Offset: 0x106D260 VA: 0x18106DE60
	public Value get_Item(string key) { }

	// RVA: 0x106DE70 Offset: 0x106D270 VA: 0x18106DE70
	public void set_Item(string key, Value value) { }

	// RVA: 0x106C1A0 Offset: 0x106B5A0 VA: 0x18106C1A0
	public void Add(string key, Value value) { }

	// RVA: 0x106C210 Offset: 0x106B610 VA: 0x18106C210
	public void Add(KeyValuePair<string, Value> pair) { }

	// RVA: 0x106CA30 Offset: 0x106BE30 VA: 0x18106CA30
	public static Object Parse(string jsonString) { }

	// RVA: 0x106D730 Offset: 0x106CB30 VA: 0x18106D730
	private static int SkipWhitespace(string str, int pos) { }

	// RVA: 0x106C920 Offset: 0x106BD20 VA: 0x18106C920
	private static string ParseString(string str, ref int startPosition) { }

	// RVA: 0x106C770 Offset: 0x106BB70 VA: 0x18106C770
	private static double ParseNumber(string str, ref int startPosition) { }

	// RVA: 0x106C330 Offset: 0x106B730 VA: 0x18106C330
	private static Object Fail(char expected, int position) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	private static Object Fail(string expected, int position) { }

	// RVA: 0x106D820 Offset: 0x106CC20 VA: 0x18106D820 Slot: 3
	public override string ToString() { }

	// RVA: 0x106C430 Offset: 0x106B830 VA: 0x18106C430 Slot: 4
	public IEnumerator<KeyValuePair<string, Value>> GetEnumerator() { }

	// RVA: 0x106D7D0 Offset: 0x106CBD0 VA: 0x18106D7D0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x106C280 Offset: 0x106B680 VA: 0x18106C280
	public void Clear() { }

	// RVA: 0x106D6B0 Offset: 0x106CAB0 VA: 0x18106D6B0
	public void Remove(string key) { }

}

private enum Object.ParsingState // TypeDefIndex: 8142
{	// Fields
	public int value__; // 0x0
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

