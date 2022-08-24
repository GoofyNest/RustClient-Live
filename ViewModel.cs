public class ViewModel : MonoBehaviour, IClientComponent // TypeDefIndex: 9250
{
	public GameObjectRef viewModelPrefab; 
	public HeldEntity targetEntity; 
	public BaseViewModel instance; 

	public bool ironSights { set; }


	public void Deploy(BaseEntity parent) { }

	public void OnDisable() { }

	public void Holster() { }

	public void Clear() { }

	public void OnFrame() { }

	public void Play(string name, int layer = 0) { }

	public void ResetTrigger(string name) { }

	public void ResetTrigger(int hash) { }

	public void Trigger(string name) { }

	public void Trigger(int hash) { }

	public void CrossFade(string name, float duration = 0,2) { }

	public void SetBool(string name, bool bState) { }

	public void SetBool(int hash, bool bState) { }

	public void SetFloat(string name, float fAmount) { }

	public void SetFloat(int hash, float fAmount) { }

	public void set_ironSights(bool value) { }

	public void .ctor() { }

}

