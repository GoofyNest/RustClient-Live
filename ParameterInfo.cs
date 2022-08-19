public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 596
{	// Fields
	protected Type ClassImpl; // 0x10
	protected object DefaultValueImpl; // 0x18
	protected MemberInfo MemberImpl; // 0x20
	protected string NameImpl; // 0x28
	protected int PositionImpl; // 0x30
	protected ParameterAttributes AttrsImpl; // 0x34
	internal MarshalAsAttribute marshalAs; // 0x38

	// Properties
	public virtual Type ParameterType { get; }
	public virtual ParameterAttributes Attributes { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public bool IsRetval { get; }
	public virtual MemberInfo Member { get; }
	public virtual string Name { get; }
	public virtual int Position { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x18CCFF0 Offset: 0x18CC3F0 VA: 0x1818CCFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18CC910 Offset: 0x18CBD10 VA: 0x1818CC910
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 8
	public virtual Type get_ParameterType() { }

	// RVA: 0x5FC780 Offset: 0x5FBB80 VA: 0x1805FC780 Slot: 9
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x18CD220 Offset: 0x18CC620 VA: 0x1818CD220
	public bool get_IsIn() { }

	// RVA: 0x18CD240 Offset: 0x18CC640 VA: 0x1818CD240
	public bool get_IsOptional() { }

	// RVA: 0x18CD260 Offset: 0x18CC660 VA: 0x1818CD260
	public bool get_IsOut() { }

	// RVA: 0x18CD280 Offset: 0x18CC680 VA: 0x1818CD280
	public bool get_IsRetval() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 10
	public virtual MemberInfo get_Member() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 11
	public virtual string get_Name() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0 Slot: 12
	public virtual int get_Position() { }

	// RVA: 0x18CCB80 Offset: 0x18CBF80 VA: 0x1818CCB80
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal object GetDefaultValueImpl() { }

	// RVA: 0x18CD1D0 Offset: 0x18CC5D0 VA: 0x1818CD1D0 Slot: 13
	public virtual object get_DefaultValue() { }

	// RVA: 0x18CCB00 Offset: 0x18CBF00 VA: 0x1818CCB00 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CCB40 Offset: 0x18CBF40 VA: 0x1818CCB40 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CCEA0 Offset: 0x18CC2A0 VA: 0x1818CCEA0 Slot: 7
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 16
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CCEF0 Offset: 0x18CC2F0 VA: 0x1818CCEF0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

}

