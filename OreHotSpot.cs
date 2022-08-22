public class OreHotSpot : BaseCombatEntity, ILOD // TypeDefIndex: 8811
{	public float visualDistance; // 0x240
	public GameObjectRef visualEffect; // 0x248
	public GameObjectRef finishEffect; // 0x250
	public GameObjectRef damageEffect; // 0x258
	public OreResourceEntity owner; // 0x260
	private GameObject visualInstance; // 0x268
	private LODCell cell; // 0x270


	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	private void SpawnVisual() { }

	private void DestroyVisual() { }

	public void .ctor() { }

}

