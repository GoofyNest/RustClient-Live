internal class ContentValidator // TypeDefIndex: 2167
{
	private XmlSchemaContentType contentType; 
	private bool isOpen; 
	private bool isEmptiable; 
	public static readonly ContentValidator Empty; 
	public static readonly ContentValidator TextOnly; 
	public static readonly ContentValidator Mixed; 
	public static readonly ContentValidator Any; 

public XmlSchemaContentType ContentType { get; }
public bool PreserveWhitespace { get; }
public virtual bool IsEmptiable { get; }
public bool IsOpen { get; set; }


public void .ctor(XmlSchemaContentType contentType) { }

protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

public XmlSchemaContentType get_ContentType() { }

public bool get_PreserveWhitespace() { }

public virtual bool get_IsEmptiable() { }

public bool get_IsOpen() { }

public void set_IsOpen(bool value) { }

public virtual void InitValidation(ValidationState context) { }

public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

public virtual bool CompleteValidation(ValidationState context) { }

public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

private static void .cctor() { }

}

