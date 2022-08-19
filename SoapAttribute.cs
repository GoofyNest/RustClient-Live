public class SoapAttribute : Attribute // TypeDefIndex: 1210
{
// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivator : MarshalByRefObject // TypeDefIndex: 1209

// Namespace: System.Runtime.Remoting.Metadata
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
public class SoapAttribute : Attribute // TypeDefIndex: 1210
	// Fields
	private bool _useAttribute; // 0x10
	protected string ProtXmlNamespace; // 0x18
	protected object ReflectInfo; // 0x20

	// Properties
	public virtual bool UseAttribute { get; }
	public virtual string XmlNamespace { get; }

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20 Slot: 7
	public virtual bool get_UseAttribute() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 8
	public virtual string get_XmlNamespace() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30 Slot: 9
	internal virtual void SetReflectionObject(object reflectionObject) { }

}

