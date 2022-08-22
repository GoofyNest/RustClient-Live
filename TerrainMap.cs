public abstract class TerrainMap : TerrainExtension // TypeDefIndex: 10407
{	internal int res; // 0x30


	public void ApplyFilter(float normX, float normZ, float radius, float fade, Action<int, int, float> action) { }

	public void ForEach(Vector3 worldPos, float radius, Action<int, int> action) { }

	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action, Vector2i min, Vector2i max) { }

	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action, Vector2i min, Vector2i max) { }

	public void ForEach(int x_min, int x_max, int z_min, int z_max, Action<int, int> action) { }

	public void ForEach(Action<int, int> action) { }

	public int Index(float normalized) { }

	public float Coordinate(int index) { }

	protected void .ctor() { }

}

private sealed class TerrainMap.<>c__DisplayClass4_0 // TypeDefIndex: 10408
{	public Vector2i base_min; // 0x10
	public Vector2i base_count; // 0x18
	public TerrainMap <>4__this; // 0x20
	public Vector2i v0; // 0x28
	public Vector2i v1; // 0x30
	public Vector2i v2; // 0x38
	public Action<int, int> action; // 0x40


	public void .ctor() { }

	internal void <ForEachParallel>b__0(int thread_id, int thread_count) { }

}

private sealed class TerrainMap.<>c__DisplayClass9_0 // TypeDefIndex: 10409
{	public Vector2i base_min; // 0x10
	public Vector2i size_y; // 0x18
	public Vector2i size_x; // 0x20
	public TerrainMap <>4__this; // 0x28
	public Vector2i v0; // 0x30
	public Vector2i v1; // 0x38
	public Vector2i v2; // 0x40
	public Vector2i v3; // 0x48
	public Action<int, int> action; // 0x50


	public void .ctor() { }

	internal void <ForEachParallel>b__0(int thread_id, int thread_count) { }

}

