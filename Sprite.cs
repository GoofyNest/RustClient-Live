public sealed class Sprite : Object // TypeDefIndex: 3574
{	// Properties
	public Bounds bounds { get; }
	public Rect rect { get; }
	public Vector4 border { get; }
	public Texture2D texture { get; }
	public float pixelsPerUnit { get; }
	public Texture2D associatedAlphaSplitTexture { get; }
	public Vector2 pivot { get; }
	public bool packed { get; }
	public SpritePackingMode packingMode { get; }
	public Rect textureRect { get; }
	public Vector2[] vertices { get; }
	public ushort[] triangles { get; }
	public Vector2[] uv { get; }

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19B2EE0 Offset: 0x19B22E0 VA: 0x1819B2EE0
	private void .ctor() { }

	// RVA: 0x19B2D60 Offset: 0x19B2160 VA: 0x1819B2D60
	internal int GetPackingMode() { }

	// RVA: 0x19B2D20 Offset: 0x19B2120 VA: 0x1819B2D20
	internal int GetPacked() { }

	// RVA: 0x19B2E90 Offset: 0x19B2290 VA: 0x1819B2E90
	internal Rect GetTextureRect() { }

	// RVA: 0x19B2C30 Offset: 0x19B2030 VA: 0x1819B2C30
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x19B2CD0 Offset: 0x19B20D0 VA: 0x1819B2CD0
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x19B2DF0 Offset: 0x19B21F0 VA: 0x1819B2DF0
	internal Vector4 GetPadding() { }

	[FreeFunctionAttribute] // RVA: 0xD2190 Offset: 0xD1590 VA: 0x1800D2190
	// RVA: 0x19B2380 Offset: 0x19B1780 VA: 0x1819B2380
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B3070 Offset: 0x19B2470 VA: 0x1819B3070
	public Bounds get_bounds() { }

	// RVA: 0x19B3240 Offset: 0x19B2640 VA: 0x1819B3240
	public Rect get_rect() { }

	// RVA: 0x19B2FD0 Offset: 0x19B23D0 VA: 0x1819B2FD0
	public Vector4 get_border() { }

	// RVA: 0x19B3360 Offset: 0x19B2760 VA: 0x1819B3360
	public Texture2D get_texture() { }

	[NativeMethodAttribute] // RVA: 0xD2250 Offset: 0xD1650 VA: 0x1800D2250
	// RVA: 0x19B31B0 Offset: 0x19B25B0 VA: 0x1819B31B0
	public float get_pixelsPerUnit() { }

	[NativeMethodAttribute] // RVA: 0xD2410 Offset: 0xD1810 VA: 0x1800D2410
	// RVA: 0x19B2F40 Offset: 0x19B2340 VA: 0x1819B2F40
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethodAttribute] // RVA: 0xD24D0 Offset: 0xD18D0 VA: 0x1800D24D0
	// RVA: 0x19B3160 Offset: 0x19B2560 VA: 0x1819B3160
	public Vector2 get_pivot() { }

	// RVA: 0x19B30D0 Offset: 0x19B24D0 VA: 0x1819B30D0
	public bool get_packed() { }

	// RVA: 0x19B2D60 Offset: 0x19B2160 VA: 0x1819B2D60
	public SpritePackingMode get_packingMode() { }

	// RVA: 0x19B3290 Offset: 0x19B2690 VA: 0x1819B3290
	public Rect get_textureRect() { }

	[FreeFunctionAttribute] // RVA: 0xD25C0 Offset: 0xD19C0 VA: 0x1800D25C0
	// RVA: 0x19B3420 Offset: 0x19B2820 VA: 0x1819B3420
	public Vector2[] get_vertices() { }

	[FreeFunctionAttribute] // RVA: 0xD27F0 Offset: 0xD1BF0 VA: 0x1800D27F0
	// RVA: 0x19B33A0 Offset: 0x19B27A0 VA: 0x1819B33A0
	public ushort[] get_triangles() { }

	[FreeFunctionAttribute] // RVA: 0xD3B60 Offset: 0xD2F60 VA: 0x1800D3B60
	// RVA: 0x19B33E0 Offset: 0x19B27E0 VA: 0x1819B33E0
	public Vector2[] get_uv() { }

	// RVA: 0x19B27D0 Offset: 0x19B1BD0 VA: 0x1819B27D0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B2410 Offset: 0x19B1810 VA: 0x1819B2410
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x19B2610 Offset: 0x19B1A10 VA: 0x1819B2610
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x19B26F0 Offset: 0x19B1AF0 VA: 0x1819B26F0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x19B2470 Offset: 0x19B1870 VA: 0x1819B2470
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x19B2540 Offset: 0x19B1940 VA: 0x1819B2540
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x19B2E40 Offset: 0x19B2240 VA: 0x1819B2E40
	private void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0x19B2BE0 Offset: 0x19B1FE0 VA: 0x1819B2BE0
	private void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19B2C80 Offset: 0x19B2080 VA: 0x1819B2C80
	private void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x19B2DA0 Offset: 0x19B21A0 VA: 0x1819B2DA0
	private void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x19B2300 Offset: 0x19B1700 VA: 0x1819B2300
	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x19B3020 Offset: 0x19B2420 VA: 0x1819B3020
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19B31F0 Offset: 0x19B25F0 VA: 0x1819B31F0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x19B2F80 Offset: 0x19B2380 VA: 0x1819B2F80
	private void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x19B3110 Offset: 0x19B2510 VA: 0x1819B3110
	private void get_pivot_Injected(out Vector2 ret) { }

}

