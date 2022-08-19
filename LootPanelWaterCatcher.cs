public class LootPanelWaterCatcher : LootPanel // TypeDefIndex: 11037
{	// Fields
	public ItemIcon sourceItem; // 0x38
	public Image capacityImage; // 0x40
	public CanvasGroup helpCanvas; // 0x48
	public CanvasGroup buttonsCanvas; // 0x50
	public Button fromButton; // 0x58
	public Button toButton; // 0x60
	public Button drinkButton; // 0x68
	private LootPanelWaterCatcher.TransferMode transferMode; // 0x70

	// Methods

	// RVA: 0x56AEF0 Offset: 0x56A2F0 VA: 0x18056AEF0 Slot: 6
	protected override void OnDisable() { }

	// RVA: 0x56A3C0 Offset: 0x5697C0 VA: 0x18056A3C0
	public bool CanCopyFrom() { }

	// RVA: 0x56A890 Offset: 0x569C90 VA: 0x18056A890
	public void CopyFrom() { }

	// RVA: 0x56A5F0 Offset: 0x5699F0 VA: 0x18056A5F0
	public bool CanCopyTo() { }

	// RVA: 0x56A9F0 Offset: 0x569DF0 VA: 0x18056A9F0
	public void CopyTo() { }

	// RVA: 0x56AD90 Offset: 0x56A190 VA: 0x18056AD90
	public void OnCopyFromDown() { }

	// RVA: 0x56ADC0 Offset: 0x56A1C0 VA: 0x18056ADC0
	public void OnCopyFromUp() { }

	// RVA: 0x56AE40 Offset: 0x56A240 VA: 0x18056AE40
	public void OnCopyToDown() { }

	// RVA: 0x56AE70 Offset: 0x56A270 VA: 0x18056AE70
	public void OnCopyToUp() { }

	// RVA: 0x56AF70 Offset: 0x56A370 VA: 0x18056AF70
	public void OnDrinkDown() { }

	// RVA: 0x56AFA0 Offset: 0x56A3A0 VA: 0x18056AFA0
	public void OnDrinkUp() { }

	// RVA: 0x56ACF0 Offset: 0x56A0F0 VA: 0x18056ACF0
	private void InitAutoTransfer(LootPanelWaterCatcher.TransferMode mode, float interval, float delay) { }

	// RVA: 0x56A390 Offset: 0x569790 VA: 0x18056A390
	private void AutoTransfer() { }

	// RVA: 0x56B0C0 Offset: 0x56A4C0 VA: 0x18056B0C0
	private void StopAutoTransfer() { }

	// RVA: 0x56B130 Offset: 0x56A530 VA: 0x18056B130 Slot: 5
	public override void Update() { }

	// RVA: 0x56B020 Offset: 0x56A420 VA: 0x18056B020
	public bool SelectedValidTarget() { }

	// RVA: 0x56AC60 Offset: 0x56A060 VA: 0x18056AC60
	public LiquidContainer GetLiquidContainer() { }

	// RVA: 0x56A770 Offset: 0x569B70 VA: 0x18056A770
	public bool CanDrink() { }

	// RVA: 0x56AB50 Offset: 0x569F50 VA: 0x18056AB50
	public void Drink() { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

private enum LootPanelWaterCatcher.TransferMode // TypeDefIndex: 11038
{	// Fields
	public int value__; // 0x0
	public const LootPanelWaterCatcher.TransferMode None = 0;
	public const LootPanelWaterCatcher.TransferMode From = 1;
	public const LootPanelWaterCatcher.TransferMode To = 2;
	public const LootPanelWaterCatcher.TransferMode Drink = 3;

}

