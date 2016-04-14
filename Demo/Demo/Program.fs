// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
module progeam

open System.Diagnostics
open System.IO
open Methods

let fib_even = 
  seq {
    for v in fib_seq do
      if (v % 2I) = 0I then
        yield v
  }


let debug x =
  printfn "%A" x 

let rec debugA (a: _[]) =
  let split = 16  
  if a.Length > split then
    debug a.[0..]
    debugA a.[split..]
  else
    debug a.[0..]

let first_3 (a,_,_) = a
let second_3 (_,a,_) = a
let third_3 (_,_,a) = a

let make_product (A: int[]) size =
  let new_size = A.Length - (size - 1)
  Array.init new_size (fun index -> A.[index..(size + index - 1)] |> Array.fold (*) 1)





[<EntryPoint>]
let main argv = 
  let sw = Stopwatch()
  sw.Start()


  sw.Stop()
  debug sw.ElapsedMilliseconds
  0