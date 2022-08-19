public class ERTerrainData // TypeDefIndex: 7295
{	// Fields
	public int terrainWidth; // 0x10
	public int terrainHeight; // 0x14
	public float originalHeight; // 0x18
	public float flattenedHeight; // 0x1C
	public float outerHeightDifference; // 0x20
	public bool critical; // 0x24
	public float perc; // 0x28
	public Vector3 hitpos; // 0x2C
	public Vector3 outerPos; // 0x38
	public bool ignorePreserveHeights; // 0x44

	// Methods

	// RVA: 0xA63730 Offset: 0xA62B30 VA: 0x180A63730
	public void .ctor(int m_terrainWidth, int m_terrainHeight, float m_originalHeight, float m_flattenedHeight, bool m_critical, float m_perc, float m_outerHeight, Vector3 m_hitPoint, Vector3 m_outerPoint) { }

}

