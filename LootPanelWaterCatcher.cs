public class LootPanelWaterCatcher : LootPanel // TypeDefIndex: 11037
{	public ItemIcon sourceItem; // 0x38
	public Image capacityImage; // 0x40
	public CanvasGroup helpCanvas; // 0x48
	public CanvasGroup buttonsCanvas; // 0x50
	public Button fromButton; // 0x58
	public Button toButton; // 0x60
	public Button drinkButton; // 0x68
	private LootPanelWaterCatcher.TransferMode transferMode; // 0x70


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

private enum LootPanelWaterCatcher.TransferMode // TypeDefIndex: 11038
{	public int value__; // 0x0
	public const LootPanelWaterCatcher.TransferMode None = 0;
	public const LootPanelWaterCatcher.TransferMode From = 1;
	public const LootPanelWaterCatcher.TransferMode To = 2;
	public const LootPanelWaterCatcher.TransferMode Drink = 3;

}

