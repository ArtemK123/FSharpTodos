module Client.Components.TodoAppPage

open Feliz
open Feliz.Bulma
open Shared
open Client.State

let renderTodoItem (todo: Todo) = Bulma.block todo.Description

let render (model: Model) (_: Msg -> unit) =
    BackgroundContainer.render [
        Bulma.container [
            Bulma.column [
                column.is6
                column.isOffset3
                prop.children [
                    Bulma.box [
                        prop.children [
                            Bulma.block [
                                prop.classes ["is-size-3"]
                                prop.children [ Html.p "Todo app" ]
                            ]
                            Bulma.content [
                                prop.children (model.Todos |> List.map(renderTodoItem))
                            ]
                        ]
                    ]
                    Client.RedirectButtons.ToHomePage.render
                ]
            ]
        ]
    ]