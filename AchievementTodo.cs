public class AchievementTodo : BaseMonoBehaviour // TypeDefIndex: 10821
{	// Fields
	public Text text; // 0x18
	public RectTransform checkIcon; // 0x20
	public RectTransform checkBox; // 0x28
	public Color AliveColor; // 0x30
	public Color DeadColor; // 0x40
	public Color HighlightColor; // 0x50
	private AchievementGroup.AchievementItem Item; // 0x60
	internal bool State; // 0x68

	// Methods

	// RVA: 0xA94640 Offset: 0xA93A40 VA: 0x180A94640
	private void Awake() { }

	// RVA: 0xA948A0 Offset: 0xA93CA0 VA: 0x180A948A0
	private void OnAchievementStateChanged(Achievement ach, int currentProgress, int progress) { }

	// RVA: 0xA94960 Offset: 0xA93D60 VA: 0x180A94960
	internal void Unlock() { }

	// RVA: 0xA946B0 Offset: 0xA93AB0 VA: 0x180A946B0
	internal void Init(AchievementGroup.AchievementItem item) { }

	// RVA: 0xA94C40 Offset: 0xA94040 VA: 0x180A94C40
	private void UpdateState() { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

