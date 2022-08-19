public class ObjectManager // TypeDefIndex: 1037
{	// Fields
	private DeserializationEventHandler m_onDeserializationHandler; // 0x10
	private SerializationEventHandler m_onDeserializedHandler; // 0x18
	internal ObjectHolder[] m_objects; // 0x20
	internal object m_topObject; // 0x28
	internal ObjectHolderList m_specialFixupObjects; // 0x30
	internal long m_fixupCount; // 0x38
	internal ISurrogateSelector m_selector; // 0x40
	internal StreamingContext m_context; // 0x48

	// Properties
	internal object TopObject { get; set; }
	internal ObjectHolderList SpecialFixupObjects { get; }

	// Methods

	// RVA: 0x1293410 Offset: 0x1292810 VA: 0x181293410
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	private bool CanCallGetType(object obj) { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	internal void set_TopObject(object value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal object get_TopObject() { }

	// RVA: 0x12934A0 Offset: 0x12928A0 VA: 0x1812934A0
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x12917A0 Offset: 0x1290BA0 VA: 0x1812917A0
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x1291800 Offset: 0x1290C00 VA: 0x181291800
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x128F6D0 Offset: 0x128EAD0 VA: 0x18128F6D0
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x1291C70 Offset: 0x1291070 VA: 0x181291C70
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x1291950 Offset: 0x1290D50 VA: 0x181291950
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x1293200 Offset: 0x1292600 VA: 0x181293200
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x1291180 Offset: 0x1290580 VA: 0x181291180
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x128FC60 Offset: 0x128F060 VA: 0x18128FC60
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x1290FC0 Offset: 0x12903C0 VA: 0x181290FC0
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x1292100 Offset: 0x1291500 VA: 0x181292100 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x12930A0 Offset: 0x12924A0 VA: 0x1812930A0
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x1292A40 Offset: 0x1291E40 VA: 0x181292A40
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x128F970 Offset: 0x128ED70 VA: 0x18128F970
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1291FF0 Offset: 0x12913F0 VA: 0x181291FF0
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x1290BC0 Offset: 0x128FFC0 VA: 0x181290BC0 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x1292890 Offset: 0x1291C90 VA: 0x181292890
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x1292640 Offset: 0x1291A40 VA: 0x181292640 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x1292500 Offset: 0x1291900 VA: 0x181292500 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x12923C0 Offset: 0x12917C0 VA: 0x1812923C0 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x1292210 Offset: 0x1291610 VA: 0x181292210 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x128F840 Offset: 0x128EC40 VA: 0x18128F840 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x128F8C0 Offset: 0x128ECC0 VA: 0x18128F8C0 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x1292260 Offset: 0x1291660 VA: 0x181292260 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x1292310 Offset: 0x1291710 VA: 0x181292310
	public void RaiseOnDeserializingEvent(object obj) { }

}

