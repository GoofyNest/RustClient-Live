public abstract class TerrainMap : TerrainExtension // TypeDefIndex: 10407
{	// Fields
	internal int res; // 0x30

	// Methods

	// RVA: 0x11405C0 Offset: 0x113F9C0 VA: 0x1811405C0
	public void ApplyFilter(float normX, float normZ, float radius, float fade, Action<int, int, float> action) { }

	// RVA: 0x1142650 Offset: 0x1141A50 VA: 0x181142650
	public void ForEach(Vector3 worldPos, float radius, Action<int, int> action) { }

	// RVA: 0x11418C0 Offset: 0x1140CC0 VA: 0x1811418C0
	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	// RVA: 0x11416D0 Offset: 0x1140AD0 VA: 0x1811416D0
	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	// RVA: 0x1142160 Offset: 0x1141560 VA: 0x181142160
	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Action<int, int> action) { }

	// RVA: 0x11420C0 Offset: 0x11414C0 VA: 0x1811420C0
	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action) { }

	// RVA: 0x1140990 Offset: 0x113FD90 VA: 0x181140990
	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Action<int, int> action, Vector2i min, Vector2i max) { }

	// RVA: 0x11410D0 Offset: 0x11404D0 VA: 0x1811410D0
	public void ForEachParallel(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	// RVA: 0x1141D40 Offset: 0x1141140 VA: 0x181141D40
	public void ForEachParallel(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	// RVA: 0x1142980 Offset: 0x1141D80 VA: 0x181142980
	public void ForEach(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, Action<int, int> action) { }

	// RVA: 0x11428D0 Offset: 0x1141CD0 VA: 0x1811428D0
	public void ForEach(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action) { }

	// RVA: 0x1140C90 Offset: 0x1140090 VA: 0x181140C90
	private void ForEachInternal(Vector2i v0, Vector2i v1, Vector2i v2, Vector2i v3, Action<int, int> action, Vector2i min, Vector2i max) { }

	// RVA: 0x1142020 Offset: 0x1141420 VA: 0x181142020
	public void ForEach(int x_min, int x_max, int z_min, int z_max, Action<int, int> action) { }

	// RVA: 0x1141F90 Offset: 0x1141390 VA: 0x181141F90
	public void ForEach(Action<int, int> action) { }

	// RVA: 0x1143000 Offset: 0x1142400 VA: 0x181143000
	public int Index(float normalized) { }

	// RVA: 0x1140970 Offset: 0x113FD70 VA: 0x181140970
	public float Coordinate(int index) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

private sealed class TerrainMap.<>c__DisplayClass4_0 // TypeDefIndex: 10408
{	// Fields
	public Vector2i base_min; // 0x10
	public Vector2i base_count; // 0x18
	public TerrainMap <>4__this; // 0x20
	public Vector2i v0; // 0x28
	public Vector2i v1; // 0x30
	public Vector2i v2; // 0x38
	public Action<int, int> action; // 0x40

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1150260 Offset: 0x114F660 VA: 0x181150260
	internal void <ForEachParallel>b__0(int thread_id, int thread_count) { }

}

private sealed class TerrainMap.<>c__DisplayClass9_0 // TypeDefIndex: 10409
{	// Fields
	public Vector2i base_min; // 0x10
	public Vector2i size_y; // 0x18
	public Vector2i size_x; // 0x20
	public TerrainMap <>4__this; // 0x28
	public Vector2i v0; // 0x30
	public Vector2i v1; // 0x38
	public Vector2i v2; // 0x40
	public Vector2i v3; // 0x48
	public Action<int, int> action; // 0x50

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1150660 Offset: 0x114FA60 VA: 0x181150660
	internal void <ForEachParallel>b__0(int thread_id, int thread_count) { }

}

