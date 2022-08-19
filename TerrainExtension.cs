public abstract class TerrainExtension : MonoBehaviour // TypeDefIndex: 10388
{	// Fields
	public bool isInitialized; // 0x18
	internal Terrain terrain; // 0x20
	internal TerrainConfig config; // 0x28

	// Methods

	// RVA: 0x7D94C0 Offset: 0x7D88C0 VA: 0x1807D94C0
	public void Init(Terrain terrain, TerrainConfig config) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public virtual void Setup() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void PostSetup() { }

	// RVA: 0x113A640 Offset: 0x1139A40 VA: 0x18113A640
	public void LogSize(object obj, ulong size) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

