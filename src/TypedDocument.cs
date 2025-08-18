using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Documents.Typed.Abstract;

namespace Soenneker.Documents.Typed;

/// <summary>
/// A generic document type for containers that have multiple types of documents
/// </summary>
public abstract class TypedDocument : Document.Document, ITypedDocument
{
    [JsonPropertyName("entityType")]
    [JsonProperty("entityType")]
    public abstract string EntityType { get; set; }
}