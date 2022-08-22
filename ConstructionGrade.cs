public class ConstructionGrade : PrefabAttribute // TypeDefIndex: 9057
{	public Construction construction; // 0x98
	public BuildingGrade gradeBase; // 0xA0
	public GameObjectRef skinObject; // 0xA8
	internal List<ItemAmount> _costToBuild; // 0xB0

	public float maxHealth { get; }
	public List<ItemAmount> costToBuild { get; }


	public float get_maxHealth() { }

	public List<ItemAmount> get_costToBuild() { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

