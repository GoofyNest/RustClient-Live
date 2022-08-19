public class MissionsHUDToDo : BaseMonoBehaviour // TypeDefIndex: 11182
{	// Fields
	public Text text; // 0x18
	public RectTransform checkIcon; // 0x20
	public RectTransform checkBox; // 0x28
	public Color AliveColor; // 0x30
	public Color DeadColor; // 0x40
	public Color HighlightColor; // 0x50
	private int index; // 0x60
	internal bool State; // 0x64

	// Methods

	// RVA: 0x766F50 Offset: 0x766350 VA: 0x180766F50
	public void MissionsUpdated() { }

	// RVA: 0x7671E0 Offset: 0x7665E0 VA: 0x1807671E0
	internal void Unlock() { }

	// RVA: 0x766C30 Offset: 0x766030 VA: 0x180766C30
	internal void Init(BaseMission.MissionObjectiveEntry missionObjective, int newIndex) { }

	// RVA: 0x7671A0 Offset: 0x7665A0 VA: 0x1807671A0
	internal void Shutdown() { }

	// RVA: 0x7674C0 Offset: 0x7668C0 VA: 0x1807674C0
	private void UpdateState() { }

	// RVA: 0x7675F0 Offset: 0x7669F0 VA: 0x1807675F0
	public void .ctor() { }

}

