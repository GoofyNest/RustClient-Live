public class PhoneDirectoryEntry : MonoBehaviour // TypeDefIndex: 10898
{	public RustText PhoneNumber; // 0x18
	public RustText PhoneName; // 0x20
	public GameObject DeleteIcon; // 0x28
	public GameObject CensorIcon; // 0x30
	private PhoneDialler diallerDialog; // 0x38
	private string rawNumberString; // 0x40
	private string cachedName; // 0x48
	private int cachedNumber; // 0x50
	private PhoneDirectoryEntry.NumberType assignedType; // 0x54


	public void Populate(PhoneDirectory.DirectoryEntry entry, PhoneDialler forDialog, PhoneDirectoryEntry.NumberType type) { }

	private void SetPhoneName(string phoneName, int number, PhoneDirectoryEntry.NumberType type) { }

	public void OnClickedDial() { }

	public void OnClickedDelete() { }

	public void .ctor() { }

}

public enum PhoneDirectoryEntry.NumberType // TypeDefIndex: 10899
{	public int value__; // 0x0
	public const PhoneDirectoryEntry.NumberType Directory = 0;
	public const PhoneDirectoryEntry.NumberType Contact = 1;

}

