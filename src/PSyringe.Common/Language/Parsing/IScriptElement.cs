using System.Management.Automation.Language;
using PSyringe.Common.Language.Parsing.Elements.Base;

namespace PSyringe.Common.Language.Parsing;

/// <summary>
///   Abstraction of a script, containing all parsed wrapper elements
///   that are used by the compiler to create a script.
/// </summary>
public interface IScriptElement {
  public ScriptBlockAst ScriptBlockAst { get; }
  public IEnumerable<IElement<Ast>> Elements { get; }

  public void AddElement(IElement<Ast> element);
}