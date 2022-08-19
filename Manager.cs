public class Manager : IDisposable // TypeDefIndex: 6709
{	// Fields
	private Dictionary<uint, Group> groups; // 0x10
	internal Provider provider; // 0x18

	// Methods

	// RVA: 0x220A090 Offset: 0x2209490 VA: 0x18220A090 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x220A6B0 Offset: 0x2209AB0 VA: 0x18220A6B0
	public void .ctor(Provider p) { }

	// RVA: 0x220A630 Offset: 0x2209A30 VA: 0x18220A630
	public Group TryGet(uint ID) { }

	// RVA: 0x220A3C0 Offset: 0x22097C0 VA: 0x18220A3C0
	public Group Get(uint ID) { }

	// RVA: 0x2209F80 Offset: 0x2209380 VA: 0x182209F80
	public Subscriber CreateSubscriber(Connection connection) { }

	// RVA: 0x220A020 Offset: 0x2209420 VA: 0x18220A020
	public void DestroySubscriber(ref Subscriber subscriber) { }

	// RVA: 0x220A530 Offset: 0x2209930 VA: 0x18220A530
	public bool IsInside(Group group, Vector3 vPos) { }

	// RVA: 0x220A1F0 Offset: 0x22095F0 VA: 0x18220A1F0
	public Group GetGroup(Vector3 vPos) { }

	// RVA: 0x220A2E0 Offset: 0x22096E0 VA: 0x18220A2E0
	public void GetVisibleFromFar(Group center, List<Group> groups) { }

	// RVA: 0x220A350 Offset: 0x2209750 VA: 0x18220A350
	public void GetVisibleFromNear(Group center, List<Group> groups) { }

}

public static class Manager // TypeDefIndex: 7007
{	// Fields
	private static Dictionary<string, GameObject> Prefabs; // 0x2B0AACC

	// Methods

	// RVA: 0xFBEF90 Offset: 0xFBE390 VA: 0x180FBEF90
	internal static GameObject CreatePrefab(string name) { }

	// RVA: -1 Offset: -1
	internal static T Create<T>(string prefabName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB1F0 Offset: 0x5EA5F0 VA: 0x1805EB1F0
	|-Manager.Create<Blocker>
	|-Manager.Create<Dropdown>
	|-Manager.Create<Menu>
	|-Manager.Create<RustButton>
	|-Manager.Create<RustButtonGroup>
	|-Manager.Create<RustIcon>
	|-Manager.Create<RustInput>
	|-Manager.Create<RustLayout>
	|-Manager.Create<RustOption>
	|-Manager.Create<RustSlider>
	|-Manager.Create<RustText>
	|-Manager.Create<RustToggle>
	|-Manager.Create<RustWrapper>
	|-Manager.Create<TabControl>
	|-Manager.Create<Video>
	|-Manager.Create<object>
	|-Manager.Create<LayoutElement>
	*/

	// RVA: 0xFBF160 Offset: 0xFBE560 VA: 0x180FBF160
	private static void .cctor() { }

}

public class Manager // TypeDefIndex: 7372
{	// Fields
	private const string hex = "0123456789abcdef";
	private static Manager manager; // 0x0
	private Hashtable handlers; // 0x10
	private Hashtable active; // 0x18
	private Hashtable assemblies; // 0x20
	private static readonly object lockobj; // 0x8

	// Properties
	public static Manager PrimaryManager { get; }

	// Methods

	// RVA: 0x22A6FE0 Offset: 0x22A63E0 VA: 0x1822A6FE0
	private void .ctor() { }

	// RVA: 0x22A6F80 Offset: 0x22A6380 VA: 0x1822A6F80
	private static void .cctor() { }

	// RVA: 0x22A70E0 Offset: 0x22A64E0 VA: 0x1822A70E0
	public static Manager get_PrimaryManager() { }

	// RVA: 0x22A6F00 Offset: 0x22A6300 VA: 0x1822A6F00
	private static string Normalize(string name) { }

	// RVA: 0x22A6700 Offset: 0x22A5B00 VA: 0x1822A6700
	public Encoding GetEncoding(int codePage) { }

	// RVA: 0x22A6310 Offset: 0x22A5710 VA: 0x1822A6310
	public Encoding GetEncoding(string name) { }

	// RVA: 0x22A5F00 Offset: 0x22A5300 VA: 0x1822A5F00
	public CultureInfo GetCulture(int culture, bool useUserOverride) { }

	// RVA: 0x22A60F0 Offset: 0x22A54F0 VA: 0x1822A60F0
	public CultureInfo GetCulture(string name, bool useUserOverride) { }

	// RVA: 0x22A67B0 Offset: 0x22A5BB0 VA: 0x1822A67B0
	internal object Instantiate(string name) { }

	// RVA: 0x22A6BE0 Offset: 0x22A5FE0 VA: 0x1822A6BE0
	private void LoadClassList() { }

	// RVA: 0x22A6DA0 Offset: 0x22A61A0 VA: 0x1822A6DA0
	private void LoadInternalClasses() { }

}

