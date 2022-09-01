public class OreHopper : PercentFullStorageContainer // TypeDefIndex: 8285
{
	[SerializeField] 
	private Transform oreOutputMesh; 
	private float visualPercentFull; 
	private Vector3 _oreScale; 
	private MeshRenderer[] orePlaneRenderers; 
	private Nullable<int> lastSetLootTypeIndex; 


	protected override void OnPercentFullChanged(float newPercentFull) { }

	private void SetVisualOreLevel(float percentFull) { }

	public void VisualLerpToOreLevel() { }

	private void OreVisualLerpUpdate() { }

	protected override void ClientInit(Entity info) { }

	public void SetOreMat(int lootTypeIndex, ParticleSystem[] unloadingFX, ParticleSystem[] particleFX) { }

	public void .ctor() { }

}

