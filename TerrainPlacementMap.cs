public class TerrainPlacementMap : TerrainMap<bool> // TypeDefIndex: 12090
{
	private bool isEnabled; 


	public override void Setup() { }

	public override void PostSetup() { }

	public void Enable() { }

	public void Disable() { }

	public void Reset() { }

	public bool GetBlocked(Vector3 worldPos) { }

	public bool GetBlocked(float normX, float normZ) { }

	public bool GetBlocked(int x, int z) { }

	public void SetBlocked(Vector3 worldPos) { }

	public void SetBlocked(float normX, float normZ) { }

	public void SetBlocked(int x, int z) { }

	public bool GetBlocked(Vector3 worldPos, float radius) { }

	public bool GetBlocked(float normX, float normZ, float radius) { }

	public void SetBlocked(Vector3 worldPos, float radius, float fade = 0) { }

	public void SetBlocked(float normX, float normZ, float radius, float fade = 0) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void <SetBlocked>b__15_0(int x, int z, float lerp) { }

}

