public class TerrainColors : TerrainExtension // TypeDefIndex: 10387
{	// Fields
	private TerrainSplatMap splatMap; // 0x30
	private TerrainBiomeMap biomeMap; // 0x38

	// Methods

	// RVA: 0x11384D0 Offset: 0x11378D0 VA: 0x1811384D0 Slot: 4
	public override void Setup() { }

	// RVA: 0x1137F10 Offset: 0x1137310 VA: 0x181137F10
	public Color GetColor(Vector3 worldPos, int mask = -1) { }

	// RVA: 0x1138090 Offset: 0x1137490 VA: 0x181138090
	public Color GetColor(float normX, float normZ, int mask = -1) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

