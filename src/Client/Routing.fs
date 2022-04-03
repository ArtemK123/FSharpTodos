module Routing

open Feliz.Router

type Page =
    | Home
    | TodoApp
    | Test
    | NotFound

let parsePage urlSegments =
    match urlSegments with
    | [ ] -> Page.Home
    | [ "todoapp" ] -> Page.TodoApp
    | [ "test" ] -> Page.Test
    | _ -> Page.NotFound

let createUrl page =
    match page with
    | Page.Home -> ""
    | Page.TodoApp -> "todoapp"
    | Page.Test -> "test"
    | Page.NotFound -> ""

let navigate page = createUrl page |> Router.navigate