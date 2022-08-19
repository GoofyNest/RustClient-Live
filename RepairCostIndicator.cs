public class RepairCostIndicator : SingletonComponent<RepairCostIndicator>, IClientComponent // TypeDefIndex: 11210
{	// Fields
	public RepairCostIndicatorRow[] Rows; // 0x18
	public CanvasGroup Fader; // 0x20
	private TimeSince showTime; // 0x28

	// Methods

	// RVA: 0x932B70 Offset: 0x931F70 VA: 0x180932B70 Slot: 6
	protected override void Awake() { }

	// RVA: 0x932BA0 Offset: 0x931FA0 VA: 0x180932BA0
	public void ShowCostIndicator(List<ItemAmount> costs, BasePlayer player) { }

	// RVA: 0x932F20 Offset: 0x932320 VA: 0x180932F20
	private void UpdateFade() { }

	// RVA: 0x9332E0 Offset: 0x9326E0 VA: 0x1809332E0
	public void .ctor() { }

}

