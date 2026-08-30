using Newtonsoft.Json;
using Soenneker.Documents.Document.Abstract;
using System.Text.Json.Serialization;

namespace Soenneker.Documents.Typed.Abstract;

/// <summary>
/// Defines a document with an application-defined type discriminator.
/// </summary>
public interface ITypedDocument : IDocument
{
    /// <summary>
    /// Gets or sets the discriminator used to identify the document's entity type.
    /// </summary>
    [JsonPropertyName("entityType")]
    [JsonProperty("entityType")]
    string EntityType { get; set; }
}
