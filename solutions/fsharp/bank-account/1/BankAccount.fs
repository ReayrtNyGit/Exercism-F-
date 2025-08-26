module BankAccount

open System

type BankAccount = {
    mutable Balance: decimal option
    Lock: obj
}

let mkBankAccount() = 
    { Balance = None; Lock = obj() }

let openAccount account =
    lock account.Lock (fun () ->
        account.Balance <- Some 0.0m
        account
    )

let closeAccount account =
    lock account.Lock (fun () ->
        account.Balance <- None
        account
    )

let getBalance account =
    lock account.Lock (fun () ->
        account.Balance
    )

let updateBalance amount account =
    lock account.Lock (fun () ->
        match account.Balance with
        | Some currentBalance -> 
            account.Balance <- Some (currentBalance + amount)
            account
        | None -> 
            account // Account is closed, no update allowed
    )