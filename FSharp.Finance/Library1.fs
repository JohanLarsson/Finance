namespace FSharp.Finance

let ma s period = Seq.windowed period s |> Seq.map Array.average
