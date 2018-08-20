module MyLib

open FSharp.Data

type MyJsonConfig = JsonProvider<"sample.json", EmbeddedResource="MyLib, sample.json">

type MyFoo = { Foo : string }

let loadMyConfig (path : string) =
    let config = MyJsonConfig.Load(path)
    { Foo = config.Foo }