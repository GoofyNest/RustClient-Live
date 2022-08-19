public class OreHopper : PercentFullStorageContainer // TypeDefIndex: 8284
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform oreOutputMesh; // 0x3D8
	private float visualPercentFull; // 0x3E0
	private Vector3 _oreScale; // 0x3E4
	private MeshRenderer[] orePlaneRenderers; // 0x3F0
	private Nullable<int> lastSetLootTypeIndex; // 0x3F8

	// Methods

	// RVA: 0xA4A210 Offset: 0xA49610 VA: 0x180A4A210 Slot: 155
	protected override void OnPercentFullChanged(float newPercentFull) { }

	// RVA: 0xA4A6D0 Offset: 0xA49AD0 VA: 0x180A4A6D0
	private void SetVisualOreLevel(float percentFull) { }

	// RVA: 0xA4A210 Offset: 0xA49610 VA: 0x180A4A210
	public void VisualLerpToOreLevel() { }

	// RVA: 0xA4A2A0 Offset: 0xA496A0 VA: 0x180A4A2A0
	private void OreVisualLerpUpdate() { }

	// RVA: 0xA4A180 Offset: 0xA49580 VA: 0x180A4A180 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA4A3F0 Offset: 0xA497F0 VA: 0x180A4A3F0
	public void SetOreMat(int lootTypeIndex, ParticleSystem[] unloadingFX, ParticleSystem[] particleFX) { }

	// RVA: 0xA4A780 Offset: 0xA49B80 VA: 0x180A4A780
	public void .ctor() { }

}

