public class LootPanelEngine : LootPanel // TypeDefIndex: 12754
{
	[SerializeField] 
	private Image engineImage; 
	[SerializeField] 
	private ItemIcon[] icons; 
	[SerializeField] 
	private GameObject warning; 
	[SerializeField] 
	private RustText hp; 
	[SerializeField] 
	private RustText power; 
	[SerializeField] 
	private RustText acceleration; 
	[SerializeField] 
	private RustText topSpeed; 
	[SerializeField] 
	private RustText fuelEconomy; 


	protected void OnEnable() { }

	public override void Update() { }

	public EngineStorage GetEngineStorage() { }

	private void RefreshStats(EngineStorage engineBayStorage) { }

	public void OnDroppedOnEngine(BaseEventData data) { }

	public void .ctor() { }

}

