public class OreHotSpot : BaseCombatEntity, ILOD // TypeDefIndex: 8811
{	// Fields
	public float visualDistance; // 0x240
	public GameObjectRef visualEffect; // 0x248
	public GameObjectRef finishEffect; // 0x250
	public GameObjectRef damageEffect; // 0x258
	public OreResourceEntity owner; // 0x260
	private GameObject visualInstance; // 0x268
	private LODCell cell; // 0x270

	// Methods

	// RVA: 0xA4A990 Offset: 0xA49D90 VA: 0x180A4A990 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA4AC20 Offset: 0xA4A020 VA: 0x180A4AC20 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0xA4ACB0 Offset: 0xA4A0B0 VA: 0x180A4ACB0 Slot: 146
	public void RefreshLOD() { }

	// RVA: 0xA4A7E0 Offset: 0xA49BE0 VA: 0x180A4A7E0 Slot: 145
	public void ChangeLOD() { }

	// RVA: 0xA4AD30 Offset: 0xA4A130 VA: 0x180A4AD30
	private void SpawnVisual() { }

	// RVA: 0xA4AA20 Offset: 0xA49E20 VA: 0x180A4AA20
	private void DestroyVisual() { }

	// RVA: 0xA4AE80 Offset: 0xA4A280 VA: 0x180A4AE80
	public void .ctor() { }

}

