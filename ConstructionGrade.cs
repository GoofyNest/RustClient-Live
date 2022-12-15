public class ConstructionGrade : PrefabAttribute // TypeDefIndex: 10794
{
	public Construction construction;
	public BuildingGrade gradeBase;
	public GameObjectRef skinObject;
	internal List<ItemAmount> _costToBuild;

	public float maxHealth { get; }
	public List<ItemAmount> costToBuild { get; }


	public float get_maxHealth() { }

	public List<ItemAmount> get_costToBuild() { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

