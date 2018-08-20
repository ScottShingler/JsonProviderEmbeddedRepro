# FSharp.Data.JsonProvider Embedded Resource Error Repro

This repository contains a simple project to demonstrate a problem with using an embedded schema with `FSharp.Data.JsonProvider` that results in "Error FS3033 The type provider 'ProviderImplementation.JsonProvider' reported an error: An index satisfying the predicate was not found in the collection."

## Project structure

### MyLib

Sets up a simple `JsonProvider` that defines an embedded json schema.

### JsonProviderEmbeddedRepro

Program that consumes MyLib and attempts to use it to parse `config.json`. Refer to the comments in `Program.fs` for details.
