public class RepairCostIndicator : SingletonComponent<RepairCostIndicator>, IClientComponent // TypeDefIndex: 12992
{
	public RepairCostIndicatorRow[] Rows; 
	public CanvasGroup Fader; 
	private TimeSince showTime; 


	protected override void Awake() { }

	public void ShowCostIndicator(List<ItemAmount> costs, BasePlayer player) { }

	private void UpdateFade() { }

	public void .ctor() { }

}

