open System

let rec getNatural () =
    printf "Введите натуральное число: "
    let input = Console.ReadLine()
    match Int32.TryParse(input) with
    | (true, n) when n > 0 -> n
    | (true, _) ->
        printfn "Ошибка (число должно быть натуральным)"
        getNatural ()
    | (false, _) ->
        printfn "Ошибка (введено не число)"
        getNatural ()

let countDigits n =
    let rec loop num count =
        if num = 0 then count
        else loop (num / 10) (count + 1)
    if n = 0 then 1 
    else loop n 0

[<EntryPoint>]
let main argv =
    printfn "Программа подсчёта количества цифр в натуральном числе"
    
    let number = getNatural ()
    let digitCount = countDigits number
    
    printfn "Количество цифр в числе %d: %d" number digitCount
    
    printfn "\nНажмите любую клавишу для выхода..."
    Console.ReadKey() |> ignore
    0