public abstract class TileBase : ScriptableObject // TypeDefIndex: 4568
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2319EB0 Offset: 0x23192B0 VA: 0x182319EB0 Slot: 4
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x2319DB0 Offset: 0x23191B0 VA: 0x182319DB0
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x48A4F0 Offset: 0x4898F0 VA: 0x18048A4F0 Slot: 6
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	// RVA: 0x2319D40 Offset: 0x2319140 VA: 0x182319D40
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x48A4F0 Offset: 0x4898F0 VA: 0x18048A4F0 Slot: 7
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	protected void .ctor() { }

}

