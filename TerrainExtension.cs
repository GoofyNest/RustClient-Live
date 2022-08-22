public abstract class TerrainExtension : MonoBehaviour // TypeDefIndex: 10388
{	public bool isInitialized; // 0x18
	internal Terrain terrain; // 0x20
	internal TerrainConfig config; // 0x28


	public void Init(Terrain terrain, TerrainConfig config) { }

	public virtual void Setup() { }

	public virtual void PostSetup() { }

	public void LogSize(object obj, ulong size) { }

	protected void .ctor() { }

}

