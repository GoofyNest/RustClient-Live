public class AchievementTodo : BaseMonoBehaviour // TypeDefIndex: 10821
{	public Text text; // 0x18
	public RectTransform checkIcon; // 0x20
	public RectTransform checkBox; // 0x28
	public Color AliveColor; // 0x30
	public Color DeadColor; // 0x40
	public Color HighlightColor; // 0x50
	private AchievementGroup.AchievementItem Item; // 0x60
	internal bool State; // 0x68


	private void Awake() { }

	private void OnAchievementStateChanged(Achievement ach, int currentProgress, int progress) { }

	internal void Unlock() { }

	internal void Init(AchievementGroup.AchievementItem item) { }

	private void UpdateState() { }

	public void .ctor() { }

}

