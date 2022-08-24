public class NotifyLOD : LODComponent // TypeDefIndex: 9943
{
	public float Distance; 
	public float MinDistanceMultiplier; 
	public GameObject TargetGameObject; 
	private int curlod; 
	private bool force; 
	private INotifyLOD lodTarget; 


	protected override void InitLOD() { }

	protected override void EnableLOD() { }

	protected override void DisableLOD() { }

	protected override void Show() { }

	protected override void Hide() { }

	protected override void SetLOD(int newlod) { }

	protected override int GetLOD(float distance) { }

	public void .ctor() { }

}

