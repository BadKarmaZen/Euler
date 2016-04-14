module Methods

open System.IO

let readLines (filePath:string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine () }

let stringToIntArray (s:string) =
  let convert = seq { 
    for d in s.ToCharArray() do
      yield System.Numerics.BigInteger(((int)d - 0x30)) }
  convert |> Seq.toArray

let fib_seq = 
  seq { 
    let mutable a:System.Numerics.BigInteger = 0I
    let mutable b:System.Numerics.BigInteger = 1I
    yield a
    yield b
    while true do
      let s = a + b
      yield s
      a <- b
      b <- s
  }

let N start = 
  let rec f x = 
    seq {
      yield x
      yield! f (x+1I) }
  f(start)

let divisors x =
  let rec div x d =
    if (x < d) then
      []
    else if (x%d) = 0I then
      [d] @ div (x/d) (d)
    else
      div (x) (d+1I)
  div x 2I

let factorize n =
  let d = divisors n
  let rec f l t =
    let len = List.length l
    if len = 0 then
      [t]
    else
      let h = List.head l
      if h = fst (t) then
        let n = (fst (t), 1I + snd(t))
        f (List.tail l) n
      else
        let n = (h, 1I)
        [t] @ f (List.tail l) n
    
  f (List.tail d) (d.[0],1I)

let unfold x =
  let rec f x =
    if x <= 0I then
      []
    else
      f (x / 10I) @ [x % 10I]
  f x

let rec is_palin (value:List<System.Numerics.BigInteger>) =
  let h = List.head value
  let t = List.last value
  if h <> t then
    false 
  else
    let len = List.length value
    if len < 3 then
      true
    else
      let sub = value |> List.skip (1) |> List.take(-2 + len)
      is_palin sub

let rec list_equal (a:List<System.Numerics.BigInteger>) b =
  let ha = List.head a
  let hb = List.head b
  if ha = hb then
    let ta = List.tail (a)
    let tb = List.tail (b)

    if ta = [] && tb = [] then
      true
    else if ta = [] || tb = [] then
      false
    else
      list_equal ta tb
  else
    false

let rec defactorize t =
  let f = snd (t)
  if f = 1I then
    fst (t)
  else
    fst (t) * defactorize (fst(t) , snd(t) - 1I)

let rec primes = 
  seq {
    yield 2I
    let mutable x = 3I
    while true do
      if isprime x then
        yield x
      x <- x + 2I }
and isprime x =
  use e = primes.GetEnumerator()
  let rec f() =
    if e.MoveNext() then
      let p = e.Current
      if p * p > x then true
      elif x % p = 0I then false
      else f()
    else true
  f()


let max a b =
  if a > b then a
  else b

let make_product (A: System.Numerics.BigInteger[]) size =
  let new_size = A.Length - (size - 1)
  Array.init new_size (fun index -> A.[index..(size + index - 1)] |> Array.fold (*) 1I)

let sqrtRoughGuess (num : System.Numerics.BigInteger) =
//  let log10x = log10 (num + 1I)
//  let halfLog = (log10x + 1I) >>> 1  
//  (power10 halfLog)
  num / 2I 

let bigintSqrt(bigNum : System.Numerics.BigInteger) =
  let rec converge prevGuess =
    let nextGuess = (bigNum / prevGuess + prevGuess) >>> 1
    match System.Numerics.BigInteger.Abs (prevGuess - nextGuess) with
    | x when x < 2I -> nextGuess
    | _ -> converge nextGuess
  if bigNum.Sign = -1 then
    failwith "Square root of a negative number is not defined."
  else
    let root = converge (sqrtRoughGuess bigNum)
    if root * root > bigNum then
      root - 1I
    else
      root

let is_perfect_square (n:System.Numerics.BigInteger) =
    let rec binary_search low high =
        let mid = (high + low) / 2I
        let midSquare = mid * mid

        if low > high then false
        elif n = midSquare then true
        else if n < midSquare then binary_search low (mid - 1I)
        else binary_search (mid + 1I) high

    binary_search 1I n

//  prime sieve to int
let sieve limit =
  let d = Array.init (limit+1) (fun i -> 1)
  let unset v =
    for i in [v+v..v..limit] do
      if i < limit then d.[i] <- 0
  
  d.[0] <- 0
  d.[1] <- 0
  let ps:seq<System.Numerics.BigInteger> = seq {
    for index in [0..limit] do
      if d.[index] <> 0 then
        yield bigint(index)
        if index * 2 < limit then
          unset index
    }
  ps

let make_2d_matrix x y (input:List<int>) =
  let m = Array2D.init x y (fun r c -> input.[y*r + c])
  m