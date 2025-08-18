using Newtonsoft.Json;
using Soenneker.Documents.Document.Abstract;
using System.Text.Json.Serialization;

namespace Soenneker.Documents.Typed.Abstract;

/// <summary>
/// A generic document type for containers that have multiple types of documents
/// </summary>
public interface ITypedDocument : IDocument
{
    /// <summary>
    /// Does not exist on the entity itself, and only belongs to documents
    /// </summary>
    [JsonPropertyName("entityType")]
    [JsonProperty("entityType")]
    string EntityType { get; set; }
}