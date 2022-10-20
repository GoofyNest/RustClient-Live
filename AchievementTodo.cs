public class AchievementTodo : BaseMonoBehaviour // TypeDefIndex: 12552
{
	public Text text; 
	public RectTransform checkIcon; 
	public RectTransform checkBox; 
	public Color AliveColor; 
	public Color DeadColor; 
	public Color HighlightColor; 
	private AchievementGroup.AchievementItem Item; 
	internal bool State; 


	private void Awake() { }

	private void OnAchievementStateChanged(Achievement ach, int currentProgress, int progress) { }

	internal void Unlock() { }

	internal void Init(AchievementGroup.AchievementItem item) { }

	private void UpdateState() { }

	public void .ctor() { }

}

