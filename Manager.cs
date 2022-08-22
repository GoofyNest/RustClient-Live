public class Manager : IDisposable // TypeDefIndex: 6709
{	private Dictionary<uint, Group> groups; // 0x10
	internal Provider provider; // 0x18


	public virtual void Dispose() { }

	public void .ctor(Provider p) { }

	public Group TryGet(uint ID) { }

	public Group Get(uint ID) { }

	public Subscriber CreateSubscriber(Connection connection) { }

	public void DestroySubscriber(ref Subscriber subscriber) { }

	public bool IsInside(Group group, Vector3 vPos) { }

	public Group GetGroup(Vector3 vPos) { }

	public void GetVisibleFromFar(Group center, List<Group> groups) { }

	public void GetVisibleFromNear(Group center, List<Group> groups) { }

}

public static class Manager // TypeDefIndex: 7007
{	private static Dictionary<string, GameObject> Prefabs; // 0x2B0AACC


	internal static GameObject CreatePrefab(string name) { }

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

	private static void .cctor() { }

}

public class Manager // TypeDefIndex: 7372
{	private const string hex = "0123456789abcdef";
	private static Manager manager; // 0x0
	private Hashtable handlers; // 0x10
	private Hashtable active; // 0x18
	private Hashtable assemblies; // 0x20
	private static readonly object lockobj; // 0x8

	public static Manager PrimaryManager { get; }


	private void .ctor() { }

	private static void .cctor() { }

	public static Manager get_PrimaryManager() { }

	private static string Normalize(string name) { }

	public Encoding GetEncoding(int codePage) { }

	public Encoding GetEncoding(string name) { }

	public CultureInfo GetCulture(int culture, bool useUserOverride) { }

	public CultureInfo GetCulture(string name, bool useUserOverride) { }

	internal object Instantiate(string name) { }

	private void LoadClassList() { }

	private void LoadInternalClasses() { }

}

