public class NotifyLOD : LODComponent // TypeDefIndex: 9943
{	public float Distance; // 0x80
	public float MinDistanceMultiplier; // 0x84
	public GameObject TargetGameObject; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94
	private INotifyLOD lodTarget; // 0x98


	protected override void InitLOD() { }

	protected override void EnableLOD() { }

	protected override void DisableLOD() { }

	protected override void Show() { }

	protected override void Hide() { }

	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

