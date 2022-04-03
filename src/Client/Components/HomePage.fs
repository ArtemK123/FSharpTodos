module Components.HomePage

open Feliz
open Feliz.Bulma
open State

let render (_: Model) (_: Msg -> unit) =
    BackgroundContainer.render [
        Bulma.column [
            column.isOffset3
            column.is6
            prop.children [
                Bulma.box [
                    Bulma.block "Home page of SAFE stack demo app"
                    Bulma.block "Made by ArtemK123"
                    Bulma.block [
                        RedirectButtons.ToTodoAppPage.render
                    ]
                    Bulma.block [
                        RedirectButtons.ToTestPage.render
                    ]
                ]
            ]
        ]
    ]
