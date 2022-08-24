public static class TerrainCallbacks // TypeDefIndex: 4096
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static TerrainCallbacks.HeightmapChangedCallback heightmapChanged; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static TerrainCallbacks.TextureChangedCallback textureChanged; 


	[RequiredByNativeCodeAttribute] 
internal static void InvokeHeightmapChangedCallback(TerrainData terrainData, RectInt heightRegion, bool synched) { }

	[RequiredByNativeCodeAttribute] 
internal static void InvokeTextureChangedCallback(TerrainData terrainData, string textureName, RectInt texelRegion, bool synched) { }

}

public sealed class TerrainCallbacks.HeightmapChangedCallback : MulticastDelegate // TypeDefIndex: 4097
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }

public virtual IAsyncResult BeginInvoke(Terrain terrain, RectInt heightRegion, bool synched, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class TerrainCallbacks.TextureChangedCallback : MulticastDelegate // TypeDefIndex: 4098
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }

public virtual IAsyncResult BeginInvoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

