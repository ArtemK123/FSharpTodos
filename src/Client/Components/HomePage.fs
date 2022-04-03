module Client.Components.HomePage

open Feliz
open Feliz.Bulma
open Client.State

let render (_: Model) (_: Msg -> unit) =
    BackgroundContainer.render [
        Bulma.column [
            column.isOffset3
            column.is6
            prop.children [
                Bulma.box [
                    Bulma.block [
                        prop.classes ["is-size-3"]
                        prop.children [ Html.p "Home page of SAFE stack demo app" ]
                    ]
                    Bulma.block "Made by ArtemK123"
                    Bulma.block [
                        Client.RedirectButtons.ToTodoAppPage.render
                    ]
                    Bulma.block [
                        Client.RedirectButtons.ToTestPage.render
                    ]
                ]
            ]
        ]
    ]
