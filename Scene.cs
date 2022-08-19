public struct Scene // TypeDefIndex: 3655
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }
	public string name { get; }
	public bool isLoaded { get; }
	public int buildIndex { get; }
	public int rootCount { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xE16A0 Offset: 0xE0AA0 VA: 0x1800E16A0
	// RVA: 0x19AF7B0 Offset: 0x19AEBB0 VA: 0x1819AF7B0
	private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE16A0 Offset: 0xE0AA0 VA: 0x1800E16A0
	// RVA: 0x19AF450 Offset: 0x19AE850 VA: 0x1819AF450
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE16A0 Offset: 0xE0AA0 VA: 0x1800E16A0
	// RVA: 0x19AF410 Offset: 0x19AE810 VA: 0x1819AF410
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE16A0 Offset: 0xE0AA0 VA: 0x1800E16A0
	// RVA: 0x19AF3D0 Offset: 0x19AE7D0 VA: 0x1819AF3D0
	private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE16A0 Offset: 0xE0AA0 VA: 0x1800E16A0
	// RVA: 0x19AF490 Offset: 0x19AE890 VA: 0x1819AF490
	private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessorAttribute] // RVA: 0xE16A0 Offset: 0xE0AA0 VA: 0x1800E16A0
	// RVA: 0x19AF4D0 Offset: 0x19AE8D0 VA: 0x1819AF4D0
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	public int get_handle() { }

	// RVA: 0x222880 Offset: 0x221C80 VA: 0x180222880
	public bool IsValid() { }

	// RVA: 0x222940 Offset: 0x221D40 VA: 0x180222940
	public string get_name() { }

	// RVA: 0x222900 Offset: 0x221D00 VA: 0x180222900
	public bool get_isLoaded() { }

	// RVA: 0x2228C0 Offset: 0x221CC0 VA: 0x1802228C0
	public int get_buildIndex() { }

	// RVA: 0x222980 Offset: 0x221D80 VA: 0x180222980
	public int get_rootCount() { }

	// RVA: 0x2227C0 Offset: 0x221BC0 VA: 0x1802227C0
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x222870 Offset: 0x221C70 VA: 0x180222870
	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x222740 Offset: 0x221B40 VA: 0x180222740 Slot: 0
	public override bool Equals(object other) { }

}

