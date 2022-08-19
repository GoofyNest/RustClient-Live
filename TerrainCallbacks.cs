public static class TerrainCallbacks // TypeDefIndex: 4096
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static TerrainCallbacks.TextureChangedCallback textureChanged; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22B9BF0 Offset: 0x22B8FF0 VA: 0x1822B9BF0
	internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22B9D00 Offset: 0x22B9100 VA: 0x1822B9D00
	internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }

}

public sealed class TerrainCallbacks.HeightmapChangedCallback : MulticastDelegate // TypeDefIndex: 4097
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22B96A0 Offset: 0x22B8AA0 VA: 0x1822B96A0 Slot: 12
	public virtual void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }

	// RVA: 0x22B9600 Offset: 0x22B8A00 VA: 0x1822B9600 Slot: 13
	public virtual IAsyncResult BeginInvoke(Terrain terrain, RectInt heightRegion, bool synched, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class TerrainCallbacks.TextureChangedCallback : MulticastDelegate // TypeDefIndex: 4098
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22BDFC0 Offset: 0x22BD3C0 VA: 0x1822BDFC0 Slot: 12
	public virtual void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }

	// RVA: 0x22BDF10 Offset: 0x22BD310 VA: 0x1822BDF10 Slot: 13
	public virtual IAsyncResult BeginInvoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

