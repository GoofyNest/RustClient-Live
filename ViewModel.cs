public class ViewModel : MonoBehaviour, IClientComponent // TypeDefIndex: 9250
{	// Fields
	public GameObjectRef viewModelPrefab; // 0x18
	public HeldEntity targetEntity; // 0x20
	public BaseViewModel instance; // 0x28

	// Properties
	public bool ironSights { set; }

	// Methods

	// RVA: 0xADA5F0 Offset: 0xAD99F0 VA: 0x180ADA5F0
	public void Deploy(BaseEntity parent) { }

	// RVA: 0xADA960 Offset: 0xAD9D60 VA: 0x180ADA960
	public void OnDisable() { }

	// RVA: 0xADA8F0 Offset: 0xAD9CF0 VA: 0x180ADA8F0
	public void Holster() { }

	// RVA: 0xADA480 Offset: 0xAD9880 VA: 0x180ADA480
	public void Clear() { }

	// RVA: 0xADA9D0 Offset: 0xAD9DD0 VA: 0x180ADA9D0
	public void OnFrame() { }

	// RVA: 0xADAB30 Offset: 0xAD9F30 VA: 0x180ADAB30
	public void Play(string name, int layer = 0) { }

	// RVA: 0xADAC60 Offset: 0xADA060 VA: 0x180ADAC60
	public void ResetTrigger(string name) { }

	// RVA: 0xADABD0 Offset: 0xAD9FD0 VA: 0x180ADABD0
	public void ResetTrigger(int hash) { }

	// RVA: 0xADAF70 Offset: 0xADA370 VA: 0x180ADAF70
	public void Trigger(string name) { }

	// RVA: 0xADB000 Offset: 0xADA400 VA: 0x180ADB000
	public void Trigger(int hash) { }

	// RVA: 0xADA550 Offset: 0xAD9950 VA: 0x180ADA550
	public void CrossFade(string name, float duration = 0,2) { }

	// RVA: 0xADAD90 Offset: 0xADA190 VA: 0x180ADAD90
	public void SetBool(string name, bool bState) { }

	// RVA: 0xADACF0 Offset: 0xADA0F0 VA: 0x180ADACF0
	public void SetBool(int hash, bool bState) { }

	// RVA: 0xADAED0 Offset: 0xADA2D0 VA: 0x180ADAED0
	public void SetFloat(string name, float fAmount) { }

	// RVA: 0xADAE30 Offset: 0xADA230 VA: 0x180ADAE30
	public void SetFloat(int hash, float fAmount) { }

	// RVA: 0xADB090 Offset: 0xADA490 VA: 0x180ADB090
	public void set_ironSights(bool value) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

