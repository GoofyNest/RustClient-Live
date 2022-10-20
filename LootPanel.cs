public class LootPanel : MonoBehaviour // TypeDefIndex: 12760
{
	public Text Title; 
	public RustText TitleText; 
	public bool hideInvalidIcons; 
	[TooltipAttribute] 
	public CanvasGroup canvasGroup; 
	private ItemIcon[] allIcons; 

	public ItemContainer Container_00 { get; }
	public ItemContainer Container_01 { get; }
	public ItemContainer Container_02 { get; }
	public ItemContainer Container_03 { get; }
	public string lootingEntityName { get; }


	public ItemContainer get_Container_00() { }

	public ItemContainer get_Container_01() { }

	public ItemContainer get_Container_02() { }

	public ItemContainer get_Container_03() { }

	public T GetContainerEntity<T>() { }
	/* GenericInstMethod :
	|
	|-LootPanel.GetContainerEntity<Locker>
	|-LootPanel.GetContainerEntity<ReclaimTerminal>
	|-LootPanel.GetContainerEntity<RepairBench>
	|-LootPanel.GetContainerEntity<object>
	*/

	public BaseEntity GetContainerEntity() { }

	public virtual void OnOpened() { }

	protected virtual void Awake() { }

	public virtual void Update() { }

	protected virtual void OnDisable() { }

	public string get_lootingEntityName() { }

	public void .ctor() { }

}

