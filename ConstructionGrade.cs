public class ConstructionGrade : PrefabAttribute // TypeDefIndex: 9057
{	// Fields
	public Construction construction; // 0x98
	public BuildingGrade gradeBase; // 0xA0
	public GameObjectRef skinObject; // 0xA8
	internal List<ItemAmount> _costToBuild; // 0xB0

	// Properties
	public float maxHealth { get; }
	public List<ItemAmount> costToBuild { get; }

	// Methods

	// RVA: 0x50BA90 Offset: 0x50AE90 VA: 0x18050BA90
	public float get_maxHealth() { }

	// RVA: 0x50B840 Offset: 0x50AC40 VA: 0x18050B840
	public List<ItemAmount> get_costToBuild() { }

	// RVA: 0x50B780 Offset: 0x50AB80 VA: 0x18050B780 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x50B7E0 Offset: 0x50ABE0 VA: 0x18050B7E0
	public void .ctor() { }

}

