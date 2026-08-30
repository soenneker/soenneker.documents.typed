[![](https://img.shields.io/nuget/v/soenneker.documents.typed.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.typed/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.typed/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.documents.typed/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.documents.typed.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.typed/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.typed/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.documents.typed/actions/workflows/codeql.yml)

# Soenneker.Documents.Typed

Adds an `EntityType` discriminator to the base document model for heterogeneous storage containers.

## Installation

```bash
dotnet add package Soenneker.Documents.Typed
```

## Usage

```csharp
using Soenneker.Documents.Typed;

public sealed class CustomerDocument : TypedDocument
{
    public override string EntityType { get; set; } = "customer";

    public string Email { get; set; } = null!;
}

var customer = new CustomerDocument
{
    DocumentId = "customer-42",
    PartitionKey = "tenant-7",
    CreatedAt = DateTimeOffset.UtcNow,
    Email = "ada@example.com"
};
```

`EntityType` serializes as `entityType` with both System.Text.Json and Newtonsoft.Json. Identity and timestamp fields come from `Document` and retain their existing JSON names.

The discriminator is application-defined. This package does not register polymorphic converters, map discriminator values to CLR types, validate uniqueness, or stop callers from changing a value after construction. Keep values stable and configure your serializer or repository to select the correct concrete type during reads.

`TypedDocument` is abstract because each document family must implement `EntityType`. Use `ITypedDocument` when persistence or routing code only needs the shared identity, timestamp, and discriminator contract.
