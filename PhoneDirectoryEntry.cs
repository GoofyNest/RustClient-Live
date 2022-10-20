public class PhoneDirectoryEntry : MonoBehaviour // TypeDefIndex: 12629
{
	public RustText PhoneNumber; 
	public RustText PhoneName; 
	public GameObject DeleteIcon; 
	public GameObject CensorIcon; 
	private PhoneDialler diallerDialog; 
	private string rawNumberString; 
	private string cachedName; 
	private int cachedNumber; 
	private PhoneDirectoryEntry.NumberType assignedType; 


	public void Populate(PhoneDirectory.DirectoryEntry entry, PhoneDialler forDialog, PhoneDirectoryEntry.NumberType type) { }

	private void SetPhoneName(string phoneName, int number, PhoneDirectoryEntry.NumberType type) { }

	public void OnClickedDial() { }

	public void OnClickedDelete() { }

	public void .ctor() { }

}

public enum PhoneDirectoryEntry.NumberType // TypeDefIndex: 12630
{
	public int value__; 
	public const PhoneDirectoryEntry.NumberType Directory = 0;
	public const PhoneDirectoryEntry.NumberType Contact = 1;

}

