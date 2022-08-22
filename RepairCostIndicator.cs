public class RepairCostIndicator : SingletonComponent<RepairCostIndicator>, IClientComponent // TypeDefIndex: 11210
{	public RepairCostIndicatorRow[] Rows; // 0x18
	public CanvasGroup Fader; // 0x20
	private TimeSince showTime; // 0x28


	protected override void Awake() { }

	public void ShowCostIndicator(List<ItemAmount> costs, BasePlayer player) { }

	private void UpdateFade() { }

	public void .ctor() { }

}

