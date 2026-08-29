[![](https://img.shields.io/nuget/v/soenneker.documents.typed.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.typed/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.typed/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.documents.typed/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.documents.typed.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.typed/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.typed/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.documents.typed/actions/workflows/codeql.yml)

# Soenneker.Documents.Typed

A generic document type for containers that have multiple types of documents.

## Install

```bash
dotnet add package Soenneker.Documents.Typed
```

## What you get

- `ITypedDocument` — A generic document type for containers that have multiple types of documents.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `ITypedDocument.EntityType` | Does not exist on the entity itself, and only belongs to documents. | Does not exist on the entity itself, and only belongs to documents. |
