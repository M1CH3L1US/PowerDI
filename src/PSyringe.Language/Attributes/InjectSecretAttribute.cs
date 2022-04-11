using System.Management.Automation.Language;
using PSyringe.Common.Language.Attributes;
using PSyringe.Common.Language.Parsing.Elements.Base;
using PSyringe.Language.Elements;
using static PSyringe.Common.Language.Attributes.PSAttributeTargets;

namespace PSyringe.Language.Attributes;

[PSAttributeUsage(Variable | Parameter)]
public class InjectSecretAttribute : Attribute, IPSyringeAttribute<AttributedExpressionAst> {
  public bool AsPlainText;

  public InjectSecretAttribute(Type? Target, bool Optional = false) {
  }

  public InjectSecretAttribute(string? Target, bool Optional = false) {
  }

  public IElement<AttributedExpressionAst> CreateElement(AttributedExpressionAst ast) {
    return new InjectSecretElement(ast);
  }
}