module Solved
open Methods

//
  //let lst = fib_even |> Seq.takeWhile ( fun x -> x < 4000000I ) |> Seq.toList |> List.sum

  
  //  4.
  //
//  let data = 
//    seq { for i in [100I..999I] do
//            for j in [100I..999I] do
//              if is_palin (unfold(i*j)) then
//                yield i * j }
//  printfn "%A" (Seq.max data)


//  let rec gen n =
//    if n = 2I then
//      factorize n
//    else
//      (factorize n) @ gen (n-1I)
//
//  let fs = List.distinct (gen 20I)
//  let f = List.sort fs
//
//  let rec sieve list =
//    let len = List.length list
//    if len = 0 then
//      []
//    else if len = 1 then
//      list
//    else
//      let a = fst(list.[0])
//      let b = fst(list.[1])
//      if a = b then
//        sieve (List.tail list)
//      else
//        [list.[0]] @ sieve (List.tail list)
//  
//  let factors = sieve f
//  let rec productize list =
//    if list = [] then
//      1I
//    else
//      let number = defactorize (List.head list)
//      number * productize (List.tail list)
//  
//  let result = productize factors 

//  Euler 6
//  let list = [1..100]
//  let a = List.map (fun x -> x*x) list
//  let b = List.sum list
//  let d = (b*b) - List.sum a

//  Euler 7
//  let x = primes |> Seq.item 10000
  
//  let M = Array2D.init 3 3 (fun x y -> x*x - y)
//  printfn "%A"  M

//  Euler 8
//let file = readLines "d:\Temp\e8.txt"
//let line = file |> Seq.toList |> List.take 1
//
//let data = stringToIntArray line.[0]
//let products = make_product data 13
//let max_products = Array.max products
//
//debug max_products

//  euler 9
//  let make_triplet (a:System.Numerics.BigInteger) (b:System.Numerics.BigInteger) =
//    a*a + b*b

//(200, 375, 425)
//1000
//(375, 200, 425)
//1000
//12532
//  let triplets n = seq {
//    for a in [1I..n] do
//      for b in [1I..n] do
//        let c = make_triplet a b
//        if is_perfect_square c then
//          let s = bigintSqrt (c)
//          if (s + a + b) = n then
//            yield (a,b, s) }


//(200, 375, 425)
//1000
//(375, 200, 425)
//1000
//1281
//  let triplets n = seq {
//    for a in [1I..(n-2I)] do
//      for b in [1I..(n-a-1I)] do
//        let c = n - a - b
//        let c_squared = make_triplet a b
//        if c*c = c_squared then
//          yield (a,b,c) }
//  
//  let t = triplets 1000I
//  let l = t |> Seq.toArray
//  
//  let rec p (l:(System.Numerics.BigInteger*System.Numerics.BigInteger*System.Numerics.BigInteger)[] ) =
//    if l <> [||] then
//      let h = Array.head l
//      debug h
//      let s = first_3(h) + second_3(h) + third_3(h)
//      debug s
//      p (Array.tail l)
//
//  p l


//  Euler 10
//  let ps = sieve 2000000
//  let p = ps |>Seq.sum
//  debug p


//  Euler 11
//  let check4x4 (M:int[,]) =
//    let r = Array.init 4 (fun row -> M.[row,*] |> Array.fold (*) 1) |> Array.max
//    let c = Array.init 4 (fun col -> M.[*,col] |> Array.fold (*) 1) |> Array.max
//    let d1 = Array.init 4 (fun i -> M.[i,i]) |> Array.fold (*) 1
//    let d2 = Array.init 4 (fun i -> M.[i,3-i]) |> Array.fold (*) 1
//    [|r; c; d1; d2|] |> Array.max
//  let input = [08;02;22;97;38;15;00;40;00;75;04;05;07;78;52;12;50;77;91;08;49;49;99;40;17;81;18;57;60;87;17;40;98;43;69;48;04;56;62;00;81;49;31;73;55;79;14;29;93;71;40;67;53;88;30;03;49;13;36;65;52;70;95;23;04;60;11;42;69;24;68;56;01;32;56;71;37;02;36;91;22;31;16;71;51;67;63;89;41;92;36;54;22;40;40;28;66;33;13;80;24;47;32;60;99;03;45;02;44;75;33;53;78;36;84;20;35;17;12;50;32;98;81;28;64;23;67;10;26;38;40;67;59;54;70;66;18;38;64;70;67;26;20;68;02;62;12;20;95;63;94;39;63;08;40;91;66;49;94;21;24;55;58;05;66;73;99;26;97;17;78;78;96;83;14;88;34;89;63;72;21;36;23;09;75;00;76;44;20;45;35;14;00;61;33;97;34;31;33;95;78;17;53;28;22;75;31;67;15;94;03;80;04;62;16;14;09;53;56;92;16;39;05;42;96;35;31;47;55;58;88;24;00;17;54;24;36;29;85;57;86;56;00;48;35;71;89;07;05;44;44;37;44;60;21;58;51;54;17;58;19;80;81;68;05;94;47;69;28;73;92;13;86;52;17;77;04;89;55;40;04;52;08;83;97;35;99;16;07;97;57;32;16;26;26;79;33;27;98;66;88;36;68;87;57;62;20;72;03;46;33;67;46;55;12;32;63;93;53;69;04;42;16;73;38;25;39;11;24;94;72;18;08;46;29;32;40;62;76;36;20;69;36;41;72;30;23;88;34;62;99;69;82;67;59;85;74;04;36;16;20;73;35;29;78;31;90;01;74;31;49;71;48;86;81;16;23;57;05;54;01;70;54;71;83;51;54;69;16;92;33;48;61;43;52;01;89;19;67;48]
//  
//  let a = make_2d_matrix 20 20 input
//  let s = seq { 
//    for r in [0..16] do
//      for c in [0..16] do
//        yield check4x4 a.[r..r+3,c..c+3] }
//
//  let m = s |> Seq.toArray |> Array.max
//  debug m
