public class LootPanelWaterCatcher : LootPanel // TypeDefIndex: 12803
{
	public ItemIcon sourceItem; 
	public Image capacityImage; 
	public CanvasGroup helpCanvas; 
	public CanvasGroup buttonsCanvas; 
	public Button fromButton; 
	public Button toButton; 
	public Button drinkButton; 
	private LootPanelWaterCatcher.TransferMode transferMode; 


	protected override void OnDisable() { }

	public bool CanCopyFrom() { }

	public void CopyFrom() { }

	public bool CanCopyTo() { }

	public void CopyTo() { }

	public void OnCopyFromDown() { }

	public void OnCopyFromUp() { }

	public void OnCopyToDown() { }

	public void OnCopyToUp() { }

	public void OnDrinkDown() { }

	public void OnDrinkUp() { }

	private void InitAutoTransfer(LootPanelWaterCatcher.TransferMode mode, float interval, float delay) { }

	private void AutoTransfer() { }

	private void StopAutoTransfer() { }

	public override void Update() { }

	public bool SelectedValidTarget() { }

	public LiquidContainer GetLiquidContainer() { }

	public bool CanDrink() { }

	public void Drink() { }

	public void .ctor() { }

}

private enum LootPanelWaterCatcher.TransferMode // TypeDefIndex: 12804
{
	public int value__; 
	public const LootPanelWaterCatcher.TransferMode None = 0;
	public const LootPanelWaterCatcher.TransferMode From = 1;
	public const LootPanelWaterCatcher.TransferMode To = 2;
	public const LootPanelWaterCatcher.TransferMode Drink = 3;

}

