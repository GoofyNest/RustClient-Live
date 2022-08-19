public class PhoneDirectoryEntry : MonoBehaviour // TypeDefIndex: 10898
{	// Fields
	public RustText PhoneNumber; // 0x18
	public RustText PhoneName; // 0x20
	public GameObject DeleteIcon; // 0x28
	public GameObject CensorIcon; // 0x30
	private PhoneDialler diallerDialog; // 0x38
	private string rawNumberString; // 0x40
	private string cachedName; // 0x48
	private int cachedNumber; // 0x50
	private PhoneDirectoryEntry.NumberType assignedType; // 0x54

	// Methods

	// RVA: 0x8CB0C0 Offset: 0x8CA4C0 VA: 0x1808CB0C0
	public void Populate(PhoneDirectory.DirectoryEntry entry, PhoneDialler forDialog, PhoneDirectoryEntry.NumberType type) { }

	// RVA: 0x8CB1C0 Offset: 0x8CA5C0 VA: 0x1808CB1C0
	private void SetPhoneName(string phoneName, int number, PhoneDirectoryEntry.NumberType type) { }

	// RVA: 0x8CB090 Offset: 0x8CA490 VA: 0x1808CB090
	public void OnClickedDial() { }

	// RVA: 0x8CAFD0 Offset: 0x8CA3D0 VA: 0x1808CAFD0
	public void OnClickedDelete() { }

	// RVA: 0x8CB2A0 Offset: 0x8CA6A0 VA: 0x1808CB2A0
	public void .ctor() { }

}

public enum PhoneDirectoryEntry.NumberType // TypeDefIndex: 10899
{	// Fields
	public int value__; // 0x0
	public const PhoneDirectoryEntry.NumberType Directory = 0;
	public const PhoneDirectoryEntry.NumberType Contact = 1;

}

