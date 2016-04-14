module Garbage

  //debug last

//  let M2 = array2D [[1;2;2]; [2;3;6] ; [4;3;0]]
//  let arr = [| 4; 2 ; 3; 1|]
//  
//  let make_product (A: int[]) size =
//    let new_size = A.Length - (size - 1)
//    Array.init new_size (fun index -> A.[index..(size + index - 1)] |> Array.fold (*) 1)
//  
//  let scan_matric (M:int[,]) =
//    let size = M.[0,*].Length
//    let rows = Array.init size (fun row -> make_product M.[row,*] 2)
//    let max_rows = Array.max (Array.init rows.Length (fun row-> Array.max rows.[row]))
//    
//    let columns = Array.init size (fun col -> make_product M.[*,col] 2)
//    let max_columns = Array.max (Array.init columns.Length (fun col-> Array.max columns.[col]))
//
//    let diagonal1 = (Array.init size (fun index -> M.[index,index])) |> Array.fold (*) 1
//    let diagonal2 = (Array.init size (fun index -> M.[index,size - 1 - index])) |> Array.fold (*) 1
//    max max_rows (max max_columns (max diagonal2 diagonal1))
//
//  //let prod = make_product arr 2
//
//  debug M2
//  let p = scan_matric M2
//  debug p


//
//  let rec scan_arrary (r: int[]) (m:int) : int =
//    let value = r.[0] * r.[1]    
//    if r.Length = 2 then      
//      max value m
//    else
//      scan_arrary (Array.tail r) (max value m)
//      
//  let scan2 (M: int [,]) =
//    let rec rows (m: int [,]) i ma =
//      if i = 0 then
//        max (ma scan_arrary m.[0,*])
//      else
//        rows (m (i-1) (max scan_arrary m.[i,*] m)))
//    rows M 2 0

    // row
//    let row (r: int[]) m =
//      let v = Array.map (fun )

//  let scan (M: int [,]) =
//    let size = M.[1,*].Length
//    if size = 4 then

//  let m = scan_arrary arr 0
//  printfn "%A"  m
//
//  let M2 = array2D [[1;2;1]; [2;3;6] ; [4;3;0]]
//  printfn "%A"  M2
//
//  //let l = scan M2
//  //printfn "%A"  l

