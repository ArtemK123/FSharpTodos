module RedirectButtons

open Routing
open Feliz
open Feliz.Bulma

let private renderButton (text: string) redirectPage =
    Bulma.button.button [
        Bulma.color.isPrimary
        prop.text text
        prop.onClick (fun _ -> navigate redirectPage)
    ]

module ToHomePage =
    let render = renderButton "Go to Home page" Page.Home

module ToTestPage =
    let render = renderButton "Go to Test page" Page.Test

module ToTodoAppPage =
    let render = renderButton "Go to Todo app" Page.TodoApp
