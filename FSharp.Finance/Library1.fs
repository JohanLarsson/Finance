namespace FSharp.Finance

module something = 

    let ma (s:double[], period:int) = Seq.windowed period s |> Seq.map Array.average

