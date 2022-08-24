public class OreHotSpot : BaseCombatEntity, ILOD // TypeDefIndex: 8811
{
	public float visualDistance; 
	public GameObjectRef visualEffect; 
	public GameObjectRef finishEffect; 
	public GameObjectRef damageEffect; 
	public OreResourceEntity owner; 
	private GameObject visualInstance; 
	private LODCell cell; 


protected override void ClientInit(Entity info) { }

protected override void DoClientDestroy() { }

public void RefreshLOD() { }

public void ChangeLOD() { }

private void SpawnVisual() { }

private void DestroyVisual() { }

public void .ctor() { }

}

