public abstract class TerrainMap : TerrainExtension // TypeDefIndex: 12166
{
	internal int res;


	public void ApplyFilter(float normX, float normZ, float radius, float fade, Action<int, int, float> action) { }

	public void ForEach(Vector3 worldPos, float radius, Action<int, int> action) { }

	public void ForEach(float normX, float normZ, float normRadius, Action<int, int> action) { }

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

private sealed class TerrainMap.<>c__DisplayClass5_0 // TypeDefIndex: 12167
{
	public Vector2i base_min;
	public Vector2i base_count;
	public TerrainMap <>4__this;
	public Vector2i v0;
	public Vector2i v1;
	public Vector2i v2;
	public Action<int, int> action;


	public void .ctor() { }

	internal void <ForEachParallel>

}

private sealed class TerrainMap.<>c__DisplayClass10_0 // TypeDefIndex: 12168
{
	public Vector2i base_min;
	public Vector2i size_y;
	public Vector2i size_x;
	public TerrainMap <>4__this;
	public Vector2i v0;
	public Vector2i v1;
	public Vector2i v2;
	public Vector2i v3;
	public Action<int, int> action;


	public void .ctor() { }

	internal void <ForEachParallel>

}

