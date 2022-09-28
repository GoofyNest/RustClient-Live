public abstract class TerrainExtension : MonoBehaviour // TypeDefIndex: 12067
{
	public bool isInitialized; 
	internal Terrain terrain; 
	internal TerrainConfig config; 


	public void Init(Terrain terrain, TerrainConfig config) { }

	public virtual void Setup() { }

	public virtual void PostSetup() { }

	public void LogSize(object obj, ulong size) { }

	protected void .ctor() { }

}

