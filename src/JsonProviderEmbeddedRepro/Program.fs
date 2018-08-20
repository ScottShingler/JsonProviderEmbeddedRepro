// In order to get this to compile, the following changes need to be made:
// 1. Comment out line 8 (`open MyLib`)
// 2. Use the fully-qualified name to reference loadMyConfig on line 14 (i.e. `MyLib.loadMyConfig).
open System

// Opening MyLib results in the following compilation error:
// Error FS3033 The type provider 'ProviderImplementation.JsonProvider' reported an error: An index satisfying the predicate was not found in the collection.
open MyLib

[<EntryPoint>]
let main argv =
    // When `open MyLib` is used, Intellisense reports "The value or constructor 'loadMyConfig' is not defined."
    // Even when `open MyLib` is not used, observe what happens when dotting into MyLib (i.e. type `MyLib.` and observe that Intellisense shows "<Note> The type provider 'ProviderImplementation.JsonProvider' reported an error: An index satisfying the predicate was not found in the collection.")
    let config = loadMyConfig("config.json")
    printfn "Loaded config: %A" config
    printfn ""
    printfn "Press any key to exit"
    Console.ReadKey() |> ignore
    0
