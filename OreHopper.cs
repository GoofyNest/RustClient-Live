public class OreHopper : PercentFullStorageContainer // TypeDefIndex: 8284
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform oreOutputMesh; // 0x3D8
	private float visualPercentFull; // 0x3E0
	private Vector3 _oreScale; // 0x3E4
	private MeshRenderer[] orePlaneRenderers; // 0x3F0
	private Nullable<int> lastSetLootTypeIndex; // 0x3F8


	protected override void OnPercentFullChanged(float newPercentFull) { }

	private void SetVisualOreLevel(float percentFull) { }

	public void VisualLerpToOreLevel() { }

	private void OreVisualLerpUpdate() { }

	protected override void ClientInit(Entity info) { }

	public void SetOreMat(int lootTypeIndex, ParticleSystem[] unloadingFX, ParticleSystem[] particleFX) { }

	public void .ctor() { }

}

