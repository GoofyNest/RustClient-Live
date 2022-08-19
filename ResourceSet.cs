public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 497
{	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0xFEEBE0 Offset: 0xFEDFE0 VA: 0x180FEEBE0
	protected void .ctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor(bool junk) { }

	// RVA: 0xFEE1A0 Offset: 0xFED5A0 VA: 0x180FEE1A0
	private void CommonInit() { }

	// RVA: 0xFEE200 Offset: 0xFED600 VA: 0x180FEE200 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xFDFAC0 Offset: 0xFDEEC0 VA: 0x180FDFAC0 Slot: 4
	public void Dispose() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0xFEE600 Offset: 0xFEDA00 VA: 0x180FEE600 Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFEE600 Offset: 0xFEDA00 VA: 0x180FEE600 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFEE570 Offset: 0xFED970 VA: 0x180FEE570
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0xFEE7D0 Offset: 0xFEDBD0 VA: 0x180FEE7D0 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0xFEE970 Offset: 0xFEDD70 VA: 0x180FEE970 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0xFEE610 Offset: 0xFEDA10 VA: 0x180FEE610 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0xFEE6E0 Offset: 0xFEDAE0 VA: 0x180FEE6E0 Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0xFEE610 Offset: 0xFEDA10 VA: 0x180FEE610
	private object GetObjectInternal(string name) { }

	// RVA: 0xFEE2A0 Offset: 0xFED6A0 VA: 0x180FEE2A0
	private object GetCaseInsensitiveObjectInternal(string name) { }

}

