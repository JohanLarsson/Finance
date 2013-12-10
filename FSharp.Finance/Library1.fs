namespace FSharp.Finance

module something = 

    let ma s period = 
        Seq.windowed period s 
        |> Seq.map (fun a-> 
            Seq.averageBy(fun v->float(v)))