namespace HelloPerson

module Person =

  type Person = {first:string; last:string}

  let bob = { first="Bob"; last="Smith" }  // "construct"

  let sibblingTo person firstName =  {person with first=firstName}

  let firstName {first=x; } =
    x

  let toString {first=f;last=l} =
    f + " " + l


//Just some random print examples
  printfn "%A" (firstName bob)
  printfn "%A" (sibblingTo bob "Kim")
