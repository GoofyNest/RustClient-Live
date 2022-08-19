public class LootPanel : MonoBehaviour // TypeDefIndex: 11025
{	// Fields
	public Text Title; // 0x18
	public bool hideInvalidIcons; // 0x20
	[TooltipAttribute] // RVA: 0x8FDB0 Offset: 0x8F1B0 VA: 0x18008FDB0
	public CanvasGroup canvasGroup; // 0x28
	private ItemIcon[] allIcons; // 0x30

	// Properties
	public ItemContainer Container_00 { get; }
	public ItemContainer Container_01 { get; }
	public ItemContainer Container_02 { get; }
	public ItemContainer Container_03 { get; }
	public string lootingEntityName { get; }

	// Methods

	// RVA: 0x507CE0 Offset: 0x5070E0 VA: 0x180507CE0
	public ItemContainer get_Container_00() { }

	// RVA: 0x507F20 Offset: 0x507320 VA: 0x180507F20
	public ItemContainer get_Container_01() { }

	// RVA: 0x508160 Offset: 0x507560 VA: 0x180508160
	public ItemContainer get_Container_02() { }

	// RVA: 0x5083A0 Offset: 0x5077A0 VA: 0x1805083A0
	public ItemContainer get_Container_03() { }

	// RVA: -1 Offset: -1
	public T GetContainerEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EB140 Offset: 0x5EA540 VA: 0x1805EB140
	|-LootPanel.GetContainerEntity<Locker>
	|-LootPanel.GetContainerEntity<ReclaimTerminal>
	|-LootPanel.GetContainerEntity<RepairBench>
	|-LootPanel.GetContainerEntity<object>
	*/

	// RVA: 0x507850 Offset: 0x506C50 VA: 0x180507850
	public BaseEntity GetContainerEntity() { }

	// RVA: 0x5077B0 Offset: 0x506BB0 VA: 0x1805077B0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x507B60 Offset: 0x506F60 VA: 0x180507B60 Slot: 5
	public virtual void Update() { }

	// RVA: 0x507A10 Offset: 0x506E10 VA: 0x180507A10 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x5085E0 Offset: 0x5079E0 VA: 0x1805085E0
	public string get_lootingEntityName() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

